using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Lab2
{

    public partial class Bai04 : Form
    {
        private List<SinhVien> danhSachSV = new List<SinhVien>();

        private List<SinhVien> danhSachSVDoc = new List<SinhVien>();

        private int currentPage = 0;

        public Bai04()
        {
            InitializeComponent();
        }


        private void btnGhiVaolbl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtID.Text == "" || txtPhone.Text == "" || txtC1.Text == "" || txtC2.Text == "" || txtC3.Text == "")
                {
                    MessageBox.Show("       Vui lòng Thông tin!        ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtPhone.Text) ||
                    txtPhone.Text.Length != 10 ||
                    !txtPhone.Text.StartsWith("0") ||
                    !txtPhone.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                    return;
                }

                if (!float.TryParse(txtC1.Text, out float diem1) || diem1 < 0 || diem1 > 10)
                {
                    MessageBox.Show("Điểm phải từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtC1.Focus();
                    return;
                }

                if (!float.TryParse(txtC2.Text, out float diem2) || diem2 < 0 || diem2 > 10)
                {
                    MessageBox.Show("Điểm phải từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtC2.Focus();
                    return;
                }

                if (!float.TryParse(txtC3.Text, out float diem3) || diem3 < 0 || diem3 > 10)
                {
                    MessageBox.Show("Điểm phải từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtC3.Focus();
                    return;
                }

                SinhVien sv = new SinhVien(txtName.Text, txtID.Text, txtPhone.Text, diem1, diem2, diem3);
                danhSachSV.Add(sv);
                lblHienThi.Text += $"-----------Sinh viên {danhSachSV.Count} ----------\n";
                lblHienThi.Text += $"Họ tên: {txtName.Text}, \t   MSSV: {txtID.Text}\n";
                lblHienThi.Text += $"Điện thoại: {txtPhone.Text}\n";
                lblHienThi.Text += $"Điểm: {txtC1.Text}, {txtC2.Text}, {txtC3.Text}\n";

                txtName.Clear();
                txtID.Clear();
                txtPhone.Clear();
                txtC1.Clear();
                txtC2.Clear();
                txtC3.Clear();
                txtName.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                if (danhSachSV.Count == 0)
                {
                    MessageBox.Show("       Chưa có sinh viên nào để ghi!      ",
                        "Thông báo");
                    return;
                }

                using (FileStream fs = new FileStream("input4.txt", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, danhSachSV);
                }

                MessageBox.Show($"Đã ghi {danhSachSV.Count} sinh viên vào file 'input4.txt'!",
                    "Ghi file thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                danhSachSV.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string pathIn = "input4.txt";

                using (FileStream fs = new FileStream(pathIn, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    if (fs.Length == 0)
                    {
                        MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    BinaryFormatter formatter = new BinaryFormatter();
                    danhSachSVDoc = (List<SinhVien>)formatter.Deserialize(fs);
                }

                if (danhSachSVDoc == null || danhSachSVDoc.Count == 0)
                {
                    MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                foreach (var sv in danhSachSVDoc)
                    sv.TinhDiemTrungBinh();

                string pathOut = "output4.txt";
                using (FileStream fs = new FileStream(pathOut, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, danhSachSVDoc);
                }

                currentPage = 0;
                HienThiSinhVienTrang();

            }
  
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiSinhVienTrang()
        {
            if (danhSachSVDoc.Count == 0)
            {
                txtRName.Clear();
                txtRID.Clear();
                txtRPhone.Clear();
                txtRC1.Clear();
                txtRC2.Clear();
                txtRC3.Clear();
                txtDTB.Clear();
                lblSoTrang.Text = "0/0";
                return;
            }

            if (currentPage < 0) currentPage = 0;
            if (currentPage >= danhSachSVDoc.Count) currentPage = danhSachSVDoc.Count - 1;

            SinhVien sv = danhSachSVDoc[currentPage];

            txtRName.Text = sv.HoTen;
            txtRID.Text = sv.MSSV;
            txtRPhone.Text = sv.DienThoai;
            txtRC1.Text = sv.DiemMon1.ToString("F2");
            txtRC2.Text = sv.DiemMon2.ToString("F2");
            txtRC3.Text = sv.DiemMon3.ToString("F2");
            txtDTB.Text = sv.DiemTrungBinh.ToString("F2");

            lblSoTrang.Text = $"{currentPage + 1}/{danhSachSVDoc.Count}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (danhSachSVDoc.Count == 0)
            {
                MessageBox.Show("\n       Chưa có dữ liệu!       \n",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentPage > 0)
            {
                currentPage--;
                HienThiSinhVienTrang();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (danhSachSVDoc.Count == 0)
            {
                MessageBox.Show("\n       Chưa có dữ liệu!       \n",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentPage < danhSachSVDoc.Count - 1)
            {
                currentPage++;
                HienThiSinhVienTrang();
            }

        }

        private void Bai04_Load(object sender, EventArgs e)
        {

        }
    }

    [Serializable]

    public class SinhVien
    {
        public string HoTen { get; set; }
        public string MSSV { get; set; }
        public string DienThoai { get; set; }
        public float DiemMon1 { get; set; }
        public float DiemMon2 { get; set; }
        public float DiemMon3 { get; set; }
        public float DiemTrungBinh { get; set; }
        public SinhVien() { }
        public SinhVien(string hoTen, string mssv, string dienThoai, float diem1, float diem2, float diem3)
        {
            HoTen = hoTen;
            MSSV = mssv;
            DienThoai = dienThoai;
            DiemMon1 = diem1;
            DiemMon2 = diem2;
            DiemMon3 = diem3;
            DiemTrungBinh = 0;
        }

        public void TinhDiemTrungBinh()
        {
            DiemTrungBinh = (DiemMon1 + DiemMon2 + DiemMon3) / 3;
        }
    }
}