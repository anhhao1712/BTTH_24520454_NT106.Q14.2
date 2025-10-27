using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Bai05 : Form
    {


        private struct PhimInfo
        {
            public string tenPhim;
            public int giaVeChuan;
            public string[] phongChieu;
        }

        private PhimInfo[] danhSachPhim = new PhimInfo[]
        {
            new PhimInfo { tenPhim = "Đào, phở và piano", giaVeChuan = 45000, phongChieu = new string[] { "1", "2", "3" } },
            new PhimInfo { tenPhim = "Mai", giaVeChuan = 100000, phongChieu = new string[] { "2", "3" } },
            new PhimInfo { tenPhim = "Gặp lại chị bầu", giaVeChuan = 70000, phongChieu = new string[] { "1" } },
            new PhimInfo { tenPhim = "Tarot", giaVeChuan = 90000, phongChieu = new string[] { "3" } }
        };

        public Bai05()
        {
            InitializeComponent();
            KhoiTaoDuLieu();

            cboPhongChieu.SelectedIndexChanged += cboPhongChieu_SelectedIndexChanged;
            this.FormClosed += (s, e) => XoaNoiDung2File();
        }


        private void XoaNoiDung2File()
        {
            XoaNoiDungFile("Input5.txt");
            XoaNoiDungFile("Output5.txt");
        }

        private void XoaNoiDungFile(string path)
        {
            try
            {
                using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
                {
                    fs.SetLength(0); // clear nội dung
                }
            }
            catch (Exception ex)
            {
            }
        }


        private void KhoiTaoDuLieu()
        {
            cboTenPhim.Items.Clear();
            cboTenPhim.Items.Add("Chọn tên phim");
            foreach (var phim in danhSachPhim)
            {
                cboTenPhim.Items.Add(phim.tenPhim);
            }
            cboTenPhim.SelectedIndex = 0;

            cboPhongChieu.Items.Clear();
            cboPhongChieu.Items.Add("Chọn phim trước");
            cboPhongChieu.SelectedIndex = 0;
            cboPhongChieu.Enabled = false;

            cboGheNgoi.Items.Clear();
            cboGheNgoi.Items.Add("Chọn ghế ngồi");
            string[] hang = { "A", "B", "C" };
            foreach (string h in hang)
            {
                for (int i = 1; i <= 5; i++)
                {
                    cboGheNgoi.Items.Add(h + i);
                }
            }
            cboGheNgoi.SelectedIndex = 0;

            cboLoaiGhe.Items.Clear();
            cboLoaiGhe.Items.Add("Chọn ghế trước");
            cboLoaiGhe.SelectedIndex = 0;
            cboLoaiGhe.Enabled = false;

            cboGiaVe.Items.Clear();
            cboGiaVe.Items.Add("Chọn ghế trước");
            cboGiaVe.SelectedIndex = 0;
            cboGiaVe.Enabled = false;
        }

        private void cboTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenPhim.SelectedIndex > 0)
            {
                PhimInfo phim = danhSachPhim[cboTenPhim.SelectedIndex - 1];
                cboPhongChieu.Items.Clear();
                cboPhongChieu.Enabled = true;

                cboPhongChieu.Items.Add("Chọn phòng chiếu");

                foreach (string phong in phim.phongChieu)
                {
                    cboPhongChieu.Items.Add(phong);
                }

                cboPhongChieu.SelectedIndex = 0;

                if (cboGheNgoi.SelectedIndex > 0)
                {
                    CapNhatLoaiGheVaGiaVe();
                }
                else
                {
                    cboLoaiGhe.Items.Clear();
                    cboLoaiGhe.Items.Add("Chọn ghế trước");
                    cboLoaiGhe.SelectedIndex = 0;
                    cboLoaiGhe.Enabled = false;

                    cboGiaVe.Items.Clear();
                    cboGiaVe.Items.Add("Chọn ghế trước");
                    cboGiaVe.SelectedIndex = 0;
                    cboGiaVe.Enabled = false;
                }

                CapNhatDanhSachGhe();
            }
            else
            {

                cboPhongChieu.Items.Clear();
                cboPhongChieu.Items.Add("Chọn phim trước");
                cboPhongChieu.SelectedIndex = 0;
                cboPhongChieu.Enabled = false;

                // Reset loại ghế và giá vé
                cboLoaiGhe.Items.Clear();
                cboLoaiGhe.Items.Add("Chọn ghế trước");
                cboLoaiGhe.SelectedIndex = 0;
                cboLoaiGhe.Enabled = false;

                cboGiaVe.Items.Clear();
                cboGiaVe.Items.Add("Chọn ghế trước");
                cboGiaVe.SelectedIndex = 0;
                cboGiaVe.Enabled = false;

                CapNhatDanhSachGhe();
            }
        }

        private void cboGheNgoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenPhim.SelectedIndex > 0 && cboGheNgoi.SelectedIndex > 0)
            {
                CapNhatLoaiGheVaGiaVe();
            }
        }

        private void CapNhatLoaiGheVaGiaVe()
        {
            string gheNgoi = cboGheNgoi.SelectedItem.ToString();
            PhimInfo phim = danhSachPhim[cboTenPhim.SelectedIndex - 1];

            string loaiGhe = "";
            double heSo = 0;

            // Xác định loại ghế
            if (gheNgoi == "A1" || gheNgoi == "A5" || gheNgoi == "C1" || gheNgoi == "C5")
            {
                loaiGhe = "Vé vớt";
                heSo = 0.25; // 1/4
            }
            else if (gheNgoi == "A2" || gheNgoi == "A3" || gheNgoi == "A4" || gheNgoi == "B1" || gheNgoi == "B5" ||
                     gheNgoi == "C2" || gheNgoi == "C3" || gheNgoi == "C4")
            {
                loaiGhe = "Vé thường";
                heSo = 1;
            }
            else if (gheNgoi == "B2" || gheNgoi == "B3" || gheNgoi == "B4")
            {
                loaiGhe = "Vé VIP";
                heSo = 2;
            }
            else
            {
                loaiGhe = "Không khả dụng";
                heSo = 0;
            }

            cboLoaiGhe.Enabled = true;
            cboGiaVe.Enabled = true;

            cboLoaiGhe.Items.Clear();
            cboLoaiGhe.Items.Add(loaiGhe);
            cboLoaiGhe.SelectedIndex = 0;

            int giaVe = (int)(phim.giaVeChuan * heSo);
            cboGiaVe.Items.Clear();
            cboGiaVe.Items.Add(giaVe.ToString("N0") + " đ");
            cboGiaVe.SelectedIndex = 0;

            cboLoaiGhe.Enabled = false;
            cboGiaVe.Enabled = false;
        }

        private void btnGhiVaolbl_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTenPhim.SelectedIndex <= 0 || cboPhongChieu.SelectedIndex <= 0 ||
                    cboGheNgoi.SelectedIndex <= 0 || cboLoaiGhe.SelectedIndex < 0 ||
                    cboGiaVe.SelectedIndex < 0 || txtTen.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenNguoiMua = txtTen.Text.Trim();
                string? tenPhim = cboTenPhim.SelectedItem.ToString();
                string? phongChieu = cboPhongChieu.SelectedItem.ToString();
                string gheNgoi = cboGheNgoi.SelectedItem.ToString();
                string loaiGhe = cboLoaiGhe.SelectedItem.ToString();
                string giaVe = cboGiaVe.SelectedItem.ToString().Replace(" đ", "").Replace(",", "");

                string duLieuInput = $"{tenPhim}|{phongChieu}|{gheNgoi}|{loaiGhe}|{giaVe}";
                using (StreamWriter sw = new StreamWriter("Input5.txt", true))
                {
                    sw.WriteLine(duLieuInput);
                }

                string duLieuOutput = $"{tenNguoiMua}|{tenPhim}|{phongChieu}|{gheNgoi}|{loaiGhe}|{giaVe}";
                using (StreamWriter sw = new StreamWriter("Output5.txt", true))
                {
                    sw.WriteLine(duLieuOutput);
                }

                MessageBox.Show("Đã thêm thông tin vào file thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                string key = $"{tenPhim}|{phongChieu}";
                if (!gheDaDat.TryGetValue(key, out var set))
                {
                    set = new HashSet<string>();
                    gheDaDat[key] = set;
                }
                set.Add(gheNgoi);

                CapNhatDanhSachGhe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "";
            try
            {
                if (!File.Exists("Output5.txt"))
                {
                    MessageBox.Show("Không có thông tin người mua", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string[] lines = File.ReadAllLines("Output5.txt");

                var thongTinTheoNguoi = new Dictionary<string, List<string[]>>();
                var tongTienTheoNguoi = new Dictionary<string, double>();

                var statsByRoom = new Dictionary<string, Dictionary<string, Dictionary<string, (int count, double money)>>>();
                var roomTotals = new Dictionary<string, (int count, double money)>();

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] thongTin = line.Split('|');
                    if (thongTin.Length != 6) continue;

                    string tenNguoiMua = thongTin[0];
                    string tenPhim = thongTin[1];
                    string phongChieu = thongTin[2]; // "1" / "2" / "3"
                    string gheNgoi = thongTin[3];
                    string loaiGhe = thongTin[4]; // Vé vớt / Vé thường / Vé VIP
                    double giaVe = double.Parse(thongTin[5]);

                    if (!thongTinTheoNguoi.ContainsKey(tenNguoiMua))
                    {
                        thongTinTheoNguoi[tenNguoiMua] = new List<string[]>();
                        tongTienTheoNguoi[tenNguoiMua] = 0;
                    }
                    thongTinTheoNguoi[tenNguoiMua].Add(thongTin);
                    tongTienTheoNguoi[tenNguoiMua] += giaVe;

                    if (!statsByRoom.ContainsKey(phongChieu))
                        statsByRoom[phongChieu] = new Dictionary<string, Dictionary<string, (int, double)>>();

                    if (!statsByRoom[phongChieu].ContainsKey(tenPhim))
                        statsByRoom[phongChieu][tenPhim] = new Dictionary<string, (int, double)>();

                    if (!statsByRoom[phongChieu][tenPhim].ContainsKey(loaiGhe))
                        statsByRoom[phongChieu][tenPhim][loaiGhe] = (0, 0);

                    var cur = statsByRoom[phongChieu][tenPhim][loaiGhe];
                    statsByRoom[phongChieu][tenPhim][loaiGhe] = (cur.count + 1, cur.money + giaVe);

                    if (!roomTotals.ContainsKey(phongChieu))
                        roomTotals[phongChieu] = (0, 0);
                    var rt = roomTotals[phongChieu];
                    roomTotals[phongChieu] = (rt.count + 1, rt.money + giaVe);
                }

                string ketQua = "THỐNG KÊ VÉ THEO NGƯỜI MUA:\n";

                double tongDoanhThuToanBo = 0;
                foreach (var nguoiMua in thongTinTheoNguoi.Keys)
                {
                    ketQua += $"Người mua: {nguoiMua}\n";

                    int stt = 1;
                    foreach (var thongTin in thongTinTheoNguoi[nguoiMua])
                    {
                        string tenPhim = thongTin[1];
                        string phongChieu = thongTin[2];
                        string gheNgoi = thongTin[3];
                        string loaiGhe = thongTin[4];
                        double giaVe = double.Parse(thongTin[5]);

                        ketQua += $" [{stt}]Phim: {tenPhim} |Phòng: {phongChieu} |Ghế: {gheNgoi}";
                        ketQua += $"|Loại: {loaiGhe} |Giá: {giaVe:N0} đ\n";
                        stt++;
                    }

                    double tongTien = tongTienTheoNguoi[nguoiMua];
                    tongDoanhThuToanBo += tongTien;
                    ketQua += $"  => Tổng số vé: {thongTinTheoNguoi[nguoiMua].Count}\n";
                    ketQua += $"  => Tổng tiền phải trả: {tongTien:N0} đ\n";
                }

                ketQua += $"TỔNG DOANH THU TOÀN BỘ: {tongDoanhThuToanBo:N0} đ\n";
                ketQua += $"TỔNG SỐ KHÁCH HÀNG: {thongTinTheoNguoi.Keys.Count}\n";

                ketQua += "THỐNG KÊ THEO PHÒNG CHIẾU\n";

                foreach (var phong in new[] { "1", "2", "3" }.Where(p => statsByRoom.ContainsKey(p)))
                {
                    var (countRoom, moneyRoom) = roomTotals[phong];
                    ketQua += $"Phòng {phong}: Tổng vé = {countRoom}, Doanh thu = {moneyRoom:N0} đ\n";
                }

                lblHienThi.Text = ketQua;

                gheDaDat.Clear();
                foreach (var nguoi in thongTinTheoNguoi.Keys)
                {
                    foreach (var info in thongTinTheoNguoi[nguoi])
                    {
                        string tenPhim = info[1];
                        string phong = info[2];
                        string ghe = info[3];
                        string key = $"{tenPhim}|{phong}";

                        if (!gheDaDat.TryGetValue(key, out var set))
                        {
                            set = new HashSet<string>();
                            gheDaDat[key] = set;
                        }
                        set.Add(ghe);
                    }
                }
                CapNhatDanhSachGhe();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private readonly Dictionary<string, HashSet<string>> gheDaDat = new Dictionary<string, HashSet<string>>();

        private string CurrentKey()
        {
            var phim = (cboTenPhim.SelectedIndex > 0) ? cboTenPhim.SelectedItem?.ToString() : null;
            var phong = (cboPhongChieu.SelectedIndex > 0) ? cboPhongChieu.SelectedItem?.ToString() : null;
            return (string.IsNullOrEmpty(phim) || string.IsNullOrEmpty(phong)) ? "" : $"{phim}|{phong}";
        }

        private void CapNhatDanhSachGhe()
        {
            cboGheNgoi.Items.Clear();
            cboGheNgoi.Items.Add("Chọn ghế ngồi");

            string key = CurrentKey();
            gheDaDat.TryGetValue(key, out var daDat);

            string[] hang = { "A", "B", "C" };
            foreach (string h in hang)
            {
                for (int i = 1; i <= 5; i++)
                {
                    string ghe = h + i;
                    if (daDat == null || !daDat.Contains(ghe))
                        cboGheNgoi.Items.Add(ghe);
                }
            }
            cboGheNgoi.SelectedIndex = 0;
        }


        private void cboPhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatDanhSachGhe();

            cboLoaiGhe.Items.Clear();
            cboLoaiGhe.Items.Add("Chọn ghế trước");
            cboLoaiGhe.SelectedIndex = 0;
            cboLoaiGhe.Enabled = false;

            cboGiaVe.Items.Clear();
            cboGiaVe.Items.Add("Chọn ghế trước");
            cboGiaVe.SelectedIndex = 0;
            cboGiaVe.Enabled = false;
        }


    }



}