using LAB01.Form_Bai3;
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
    public partial class Form_Bai3_1 : Form
    {
        public Form_Bai3_1()
        {
            InitializeComponent();
        }


        private string DocChuSo(int so)
        {
            string[] mangChu = { "không", "một", "hai", "ba", "bốn",
                        "năm", "sáu", "bảy", "tám", "chín" };
            return mangChu[so];
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSo.Text))
                {
                    MessageBox.Show("Vui lòng nhập số!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSo.Focus();
                    return;
                }

                // Kiểm tra có phải số hợp lệ không
                if (!long.TryParse(txtSo.Text, out long so))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSo.Focus();
                    txtSo.SelectAll();
                    return;
                }

                // Kiểm tra số âm
                if (so < 0)
                {
                    MessageBox.Show("Vui lòng nhập số dương!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSo.Focus();
                    txtSo.SelectAll();
                    return;
                }

                // Kiểm tra độ dài tối đa 12 chữ số
                if (txtSo.Text.Length > 1)
                {
                    MessageBox.Show("Số không được quá 1 chữ số!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSo.Focus();
                    txtSo.SelectAll();
                    return;
                }

                // Đọc số thành chữ
                string ketQua = DocSo(so);

                // Hiển thị kết quả
                if (btnHienThi != null)
                    btnHienThi.Text = ketQua;
                else
                    MessageBox.Show(ketQua, "Kết quả",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private string DocSo1ChuSo(int so)
        {
            return DocChuSo(so);
        }

        // Hàm đọc số có 2 chữ số
        private string DocSo2ChuSo(int so)
        {
            if (so < 10)
                return DocChuSo(so);

            int chuc = so / 10;
            int donvi = so % 10;

            string ketQua = "";

            if (chuc == 1)
                ketQua = "mười";
            else
                ketQua = DocChuSo(chuc) + " mươi";

            if (donvi == 1 && chuc >= 1)
                ketQua += " mốt";
            else if (donvi == 5 && chuc >= 1)
                ketQua += " lăm";
            else if (donvi == 0)
                return ketQua;
            else
                ketQua += " " + DocChuSo(donvi);

            return ketQua;
        }

        // Hàm đọc số có 3 chữ số
        private string DocSo3ChuSo(int so)
        {
            if (so < 100)
                return DocSo2ChuSo(so);

            int tram = so / 100;
            int duoi = so % 100;

            string ketQua = DocChuSo(tram) + " trăm";

            if (duoi == 0)
                return ketQua;

            if (duoi < 10)
                ketQua += " lẻ " + DocChuSo(duoi);
            else
                ketQua += " " + DocSo2ChuSo(duoi);

            return ketQua;
        }

        // Hàm đọc số chính (tối đa 12 chữ số)
        private string DocSo(long so)
        {
            if (so == 0)
                return "Không";
            string ketQua = "";
            // Tỷ (12 chữ số: xxx,xxx,xxx,xxx)
            long ty = so / 1000000000;
            long trieu = (so % 1000000000) / 1000000;
            long ngan = (so % 1000000) / 1000;
            long donvi = so % 1000;
            if (ty > 0)
                ketQua += DocSo3ChuSo((int)ty) + " tỷ";
            if (trieu > 0)
            {
                if (ketQua != "")
                    ketQua += ", ";

                if (trieu < 10 && ty > 0)
                    ketQua += "không trăm lẻ " + DocChuSo((int)trieu) + " triệu";
                else if (trieu < 100 && ty > 0)
                    ketQua += "không trăm " + DocSo2ChuSo((int)trieu) + " triệu";
                else
                    ketQua += DocSo3ChuSo((int)trieu) + " triệu";
            }
            else if (ty > 0 && (ngan > 0 || donvi > 0))
                ketQua += ", không triệu";
            if (ngan > 0)
            {
                if (ketQua != "")
                    ketQua += ", ";

                if (ngan < 10 && (ty > 0 || trieu > 0))
                    ketQua += "không trăm lẻ " + DocChuSo((int)ngan) + " ngàn";
                else if (ngan < 100 && (ty > 0 || trieu > 0))
                    ketQua += "không trăm " + DocSo2ChuSo((int)ngan) + " ngàn";
                else
                    ketQua += DocSo3ChuSo((int)ngan) + " ngàn";
            }
            else if ((ty > 0 || trieu > 0) && donvi > 0)
            {
                ketQua += ", không ngàn";
            }
            if (donvi > 0)
            {
                if (ketQua != "")
                    ketQua += ", ";

                if (donvi < 10 && (ty > 0 || trieu > 0 || ngan > 0))
                    ketQua += "không trăm lẻ " + DocChuSo((int)donvi);
                else if (donvi < 100 && (ty > 0 || trieu > 0 || ngan > 0))
                    ketQua += "không trăm " + DocSo2ChuSo((int)donvi);
                else
                    ketQua += DocSo3ChuSo((int)donvi);
            }

            // Viết hoa chữ cái đầu
            if (ketQua.Length > 0)
                ketQua = char.ToUpper(ketQua[0]) + ketQua.Substring(1);

            return ketQua;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Menu_Bai3 menu = new Menu_Bai3();
            menu.Show();
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo.Clear();
        }
    }
}
