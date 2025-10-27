using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class Form_Bai5 : Form
    {
        public Form_Bai5()
        {
            InitializeComponent();
            // Thêm items vào ComboBox
            cbbChon.Items.Add("Bảng cửu chương");
            cbbChon.Items.Add("Tính toán giá trị");
            cbbChon.SelectedIndex = 0;
        }

        public string BangCuuChuong(int n)
        {
            StringBuilder ketQua = new StringBuilder();
            ketQua.AppendLine($"Bảng cửu chương {n}");
            ketQua.AppendLine("-------------------");

            for (int i = 1; i <= 10; i++)
            {
                ketQua.AppendLine($"{n} x {i} = {n * i}");
            }

            return ketQua.ToString();
        }

        // Tính giai thừa
        private long TinhGiaiThua(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            long ketQua = 1;
            for (int i = 2; i <= n; i++)
            {
                ketQua *= i;
            }
            return ketQua;
        }

        // Tính A^i
        private long TinhLuyThua(int a, int i)
        {
            long ketQua = 1;
            for (int j = 0; j < i; j++)
            {
                ketQua *= a;
            }
            return ketQua;
        }

        private void btnTinh_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra input hợp lệ
            if (!int.TryParse(txtA.Text, out int A) || !int.TryParse(txtB.Text, out int B))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus();
                return;
            }


            // Kiểm tra ComboBox đã chọn
            if (cbbChon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tùy chọn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xử lý theo lựa chọn
            if (cbbChon.SelectedIndex == 0) // Bảng cửu chương
            {
                // Kiểm tra phạm vi hợp lệ (1-9) cho bảng cửu chương
                if (A < 1 || A > 9)
                {
                    MessageBox.Show("Số nguyên A phải từ 1 đến 9 cho bảng cửu chương!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtA.Focus();
                    return;
                }

                if (B < 1 || B > 9)
                {
                    MessageBox.Show("Số nguyên B phải từ 1 đến 9 cho bảng cửu chương!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtB.Focus();
                    return;
                }

                btnHienThi1.Text = BangCuuChuong(A);
                btnHienThi2.Text = BangCuuChuong(B);
            }
            else if (cbbChon.SelectedIndex == 1) // Tính toán giá trị
            {
                // Tính (B-A)!
                if (B > A)
                {
                    MessageBox.Show("A phải lớn hơn hoặc bằng B để tính (A-B)!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int hieu = A - B;
                long giaiThua = TinhGiaiThua(hieu);

                StringBuilder ketQua1 = new StringBuilder();
                ketQua1.AppendLine($"Tính (A - B)!");
                ketQua1.AppendLine("-------------------");
                ketQua1.AppendLine($"A - B = {A} - {B} = {hieu}");
                ketQua1.AppendLine($"({hieu})! = {giaiThua}");

                btnHienThi1.Text = ketQua1.ToString();

                // Tính A^1 + A^2 + ... + A^B
                StringBuilder ketQua2 = new StringBuilder();
                ketQua2.AppendLine($"Tính A^1 + A^2 + ... + A^B");
                ketQua2.AppendLine("-------------------");

                long tong = 0;
                for (int i = 1; i <= B; i++)
                {
                    long luyThua = TinhLuyThua(A, i);
                    tong += luyThua;
                    ketQua2.AppendLine($"{A}^{i} = {luyThua}");
                }

                ketQua2.AppendLine("-------------------");
                ketQua2.AppendLine($"Tổng = {tong}");

                btnHienThi2.Text = ketQua2.ToString();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            btnHienThi1.Text = "";
            btnHienThi2.Text = "";
            cbbChon.SelectedIndex = 0;
            txtA.Focus();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Menu_Lab1 menu_Lab1 = new Menu_Lab1();
            menu_Lab1.Show();
            this.Hide();

        }
    }
}