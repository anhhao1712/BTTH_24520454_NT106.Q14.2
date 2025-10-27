using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai06 : Form
    {
        private readonly FoodRepo _repo = new FoodRepo();

        public Bai06()
        {
            InitializeComponent();

            this.Load += Bai06_Load;
            btnThem.Click += btnThem_Click;
            btnHoanTat.Click += btnHoanTat_Click;
            btnTim.Click += btnTim_Click;
        }

        private void Bai06_Load(object sender, EventArgs e)
        {
            DbCreator.CreateDatabaseFromFile();
            LoadTreeNamesOnly();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenMon = txtMonAn.Text.Trim();
            var tenNcc = txtNCC.Text.Trim();
            var quyen = string.IsNullOrWhiteSpace(txtQuyenHan.Text) ? null : txtQuyenHan.Text.Trim();
            var img = txtFile.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenMon) || string.IsNullOrWhiteSpace(tenNcc) || string.IsNullOrWhiteSpace(img))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ: Tên món ăn và Tên người cung cấp và file hình ảnh món ăn.", "Thiếu dữ liệu");
                return;
            }

            try
            {
                _repo.AddMonAn(tenMon, img, tenNcc, quyen);
                MessageBox.Show("Đã lưu vào SQL.", "OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu SQL: " + ex.Message);
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            LoadTreeNamesOnly();
        }

        private void LoadTreeNamesOnly()
        {
            try
            {
                var tb = _repo.GetAllTenMon();

                trvMonAn.BeginUpdate();
                trvMonAn.Nodes.Clear();

                var root = trvMonAn.Nodes.Add("Danh sách món ăn");
                foreach (DataRow r in tb.Rows)
                {
                    var n = root.Nodes.Add(r["TenMonAn"].ToString());
                    n.Tag = (int)r["IDMA"]; 
                }
                root.Expand();
                trvMonAn.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                var row = _repo.GetRandomMon();
                if (row == null)
                {
                    MessageBox.Show("Chưa có dữ liệu món ăn trong SQL.");
                    return;
                }

                var ten = row.Field<string>("TenMonAn");
                var ncc = row.Field<string>("HoVaTen");     
                var qh = row.Field<string>("QuyenHan");
                var img = row.Field<string>("HinhAnhPath");   

                btnShowMonAn.Text = string.IsNullOrWhiteSpace(ten) ? "Tên Món Ăn" : ten;
                btnNCC.Text = string.IsNullOrWhiteSpace(ncc) ? "Tên người cung cấp" : ncc;

                LoadImageToPictureBox(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm ngẫu nhiên: " + ex.Message);
            }
        }


        private void LoadImageToPictureBox(string pathOrNull)
        {
            ptbHienThi.Image = null;
            if (string.IsNullOrWhiteSpace(pathOrNull)) return;

            try
            {
                string path = pathOrNull;
                if (!Path.IsPathRooted(path))
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pathOrNull);

                if (File.Exists(path))
                {
                    using var img = Image.FromFile(path);
                    ptbHienThi.Image = new Bitmap(img);
                    ptbHienThi.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch { /* bỏ qua lỗi ảnh */ }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
        "Bạn chắc chắn muốn XÓA TOÀN BỘ dữ liệu ",
        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                _repo.DeleteAllData();
                trvMonAn.Nodes.Clear();
                txtMonAn.Clear(); txtNCC.Clear(); txtQuyenHan.Clear(); txtFile.Clear();
                btnShowMonAn.Text = "Tên Món Ăn";
                btnNCC.Text = "Tên người cung cấp";
                ptbHienThi.Image = null;

                MessageBox.Show("Đã xóa toàn bộ dữ liệu.", "Hoàn tất");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
            }
        }

        
    }

    internal static class ConnectionStrings
    {
        public static readonly string Db =
            "Data Source=localhost;Initial Catalog=QuanLyMonAn;Integrated Security=True;";
    }


    internal class FoodRepo
    {
        private readonly string _cs = ConnectionStrings.Db;

      
        public void AddMonAn(string ten, string imgPathOrNull, string tenNcc, string quyenOrNull)
        {
            using var con = new SqlConnection(_cs);
            con.Open();

            int idNcc = EnsureNcc(con, tenNcc, quyenOrNull);

            using var cmd = new SqlCommand(
                "INSERT INTO MonAn(TenMonAn, HinhAnh, IDNCC) VALUES(@t, @img, @id)", con);
            cmd.Parameters.AddWithValue("@t", ten);
            cmd.Parameters.AddWithValue("@img", (object?)imgPathOrNull ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", idNcc);
            cmd.ExecuteNonQuery();
        }

        public void DeleteAllData()
        {
            using var con = new SqlConnection(_cs);
            con.Open();
            using var tx = con.BeginTransaction();

            try
            {
                using (var cmd = new SqlCommand(@"
            DELETE FROM MonAn;
            DELETE FROM NguoiDung;
            DBCC CHECKIDENT ('MonAn', RESEED, 0);
            DBCC CHECKIDENT ('NguoiDung', RESEED, 0);
        ", con, tx))
                {
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }


        public DataTable GetAllTenMon()
        {
            using var con = new SqlConnection(_cs);
            using var da = new SqlDataAdapter(
                "SELECT IDMA, TenMonAn FROM MonAn ORDER BY TenMonAn", con);
            var tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public DataRow? GetRandomMon()
        {
            using var con = new SqlConnection(_cs);
            using var da = new SqlDataAdapter(@"
                SELECT TOP 1 
                       ma.IDMA,
                       ma.TenMonAn,
                       ma.HinhAnh           AS HinhAnhPath, 
                       nd.TenNguoiCungCap   AS HoVaTen,
                       nd.QuyenHan
                FROM MonAn ma
                JOIN NguoiDung nd ON nd.IDNCC = ma.IDNCC
                ORDER BY NEWID()", con);
            var tb = new DataTable();
            da.Fill(tb);
            return tb.Rows.Count == 0 ? null : tb.Rows[0];
        }

        private int EnsureNcc(SqlConnection con, string hoTen, string? quyen)
        {
            using (var find = new SqlCommand(
                "SELECT IDNCC FROM NguoiDung WHERE TenNguoiCungCap = @t", con))
            {
                find.Parameters.AddWithValue("@t", hoTen);
                var id = find.ExecuteScalar();
                if (id != null && id != DBNull.Value) return Convert.ToInt32(id);
            }

            using (var ins = new SqlCommand(
                "INSERT INTO NguoiDung(TenNguoiCungCap, QuyenHan) OUTPUT INSERTED.IDNCC VALUES(@t, @q)", con))
            {
                ins.Parameters.AddWithValue("@t", hoTen);
                ins.Parameters.AddWithValue("@q", (object?)quyen ?? DBNull.Value);
                return Convert.ToInt32(ins.ExecuteScalar());
            }
        }
    }

    internal static class DbCreator
    {
       
        public static void CreateDatabaseFromFile()
        {
            try
            {

                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string scriptPath = Path.Combine(baseDir, "QuanLyMonAn.sql");
                if (!File.Exists(scriptPath)) return;

                string sqlScript = File.ReadAllText(scriptPath);

                sqlScript = Regex.Replace(sqlScript, @"^\s*CREATE\s+DATABASE\b.*?$", "",
                    RegexOptions.IgnoreCase | RegexOptions.Multiline);
                sqlScript = Regex.Replace(sqlScript, @"^\s*USE\s+\w+\s*;?\s*$", "",
                    RegexOptions.IgnoreCase | RegexOptions.Multiline);

                string[] batches = Regex.Split(sqlScript, @"^\s*GO\s*$",
                    RegexOptions.Multiline | RegexOptions.IgnoreCase);

                using (SqlConnection con2 = new SqlConnection(ConnectionStrings.Db))
                {
                    con2.Open();
                    foreach (string batch in batches)
                    {
                        string q = batch.Trim();
                        if (string.IsNullOrWhiteSpace(q)) continue;
                        try
                        {
                            using var c = new SqlCommand(q, con2);
                            c.ExecuteNonQuery();
                        }
                        catch
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo DB từ file SQL: " + ex.Message, "Lỗi");
            }
        }
    }
}
