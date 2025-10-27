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
    public partial class Form_Bai6 : Form
    {
        public Form_Bai6()
        {
            InitializeComponent();
        }



        private void btnTim_Click(object sender, EventArgs e)
        {
            DateTime Bir = new DateTime();
            if (txtNhap.Text == "")
            {
                MessageBox.Show("              Bạn Chưa Nhập\n\n              Vui lòng nhập              ",
                    "Lỗi");
                return;
            }

            if (!DateTime.TryParse(txtNhap.Text, out Bir))
            {
                MessageBox.Show("\n  Vui lòng nhập lại theo định dạng (Tháng/Ngày/Năm)  \n",
                    "Lỗi");
                txtNhap.Text = "";
                return;
            }
            int day = Bir.Day;
            int month = Bir.Month;
            int year = Bir.Year;

            // Xác định cung hoàng đạo
            string zodiac = CungHoangDao(day, month);


            lblHienThi.Text = $"                 Ngày sinh: {day:D2}/{month:D2}/{year}                " +
                $"\n                Cung hoàng đạo: {zodiac}";
            txtNhap.Clear();
            txtNhap.Focus();
        }

        private string CungHoangDao(int day, int month)
        {
            switch (month)
            {
                case 1:
                    return day >= 21 ? "♒ Cung Bảo Bình (Aquarius)" : "♑ Cung Ma Kết (Capricorn)";
                case 2:
                    return day <= 19 ? "♒ Cung Bảo Bình (Aquarius)" : "♓ Cung Song Ngư (Pisces)";
                case 3:
                    return day <= 20 ? "♓ Cung Song Ngư (Pisces)" : "♈ Cung Bạch Dương (Aries)";
                case 4:
                    return day <= 20 ? "♈ Cung Bạch Dương (Aries)" : "♉ Cung Kim Ngưu (Taurus)";
                case 5:
                    return day <= 21 ? "♉ Cung Kim Ngưu (Taurus)" : "♊ Cung Song Tử (Gemini)";
                case 6:
                    return day <= 21 ? "♊ Cung Song Tử (Gemini)" : "♋ Cung Cự Giải (Cancer)";
                case 7:
                    return day <= 22 ? "♋ Cung Cự Giải (Cancer)" : "♌ Cung Sư Tử (Leo)";
                case 8:
                    return day <= 22 ? "♌ Cung Sư Tử (Leo)" : "♍ Cung Xử Nữ (Virgo)";
                case 9:
                    return day <= 23 ? "♍ Cung Xử Nữ (Virgo)" : "♎ Cung Thiên Bình (Libra)";
                case 10:
                    return day <= 23 ? "♎ Cung Thiên Bình (Libra)" : "♏ Cung Thần Nông (Scorpio)";
                case 11:
                    return day <= 22 ? "♏ Cung Thần Nông (Scorpio)" : "♐ Cung Nhân Mã (Sagittarius)";
                case 12:
                    return day <= 21 ? "♐ Cung Nhân Mã (Sagittarius)" : "♑ Cung Ma Kết (Capricorn)";
                default:
                    return "Không xác định";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtNhap.Focus();
            lblHienThi.Text = "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Menu_Lab1 menu = new Menu_Lab1();
            menu.Show();    
            this.Hide();

        }
    }
}
