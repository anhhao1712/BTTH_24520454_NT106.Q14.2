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
    public partial class Form_Bai7 : Form
    {
        public Form_Bai7()
        {
            InitializeComponent();
        }

        string Ten = "";
        List<double> listDiem = new List<double>();
        List<string> listMon = new List<string>();


        private bool EnsureParsed()
        {
            if (string.IsNullOrWhiteSpace(Ten) || listDiem.Count == 0)
                ParseData();
            return !string.IsNullOrWhiteSpace(Ten) && listDiem.Count > 0;
        }


        private void ParseData()
        {
            string c = txtBai7.Text.Trim();
            // Tìm vị trí dấu phẩy đầu tiên (phân cách tên và điểm)
            int firstCommaIndex = c.IndexOf(',');
            if (firstCommaIndex == -1)
            {
                MessageBox.Show("Định dạng không hợp lệ!");return;
            }
            Ten = c.Substring(0, firstCommaIndex).Trim();
            string diemPart = c.Substring(firstCommaIndex + 1).Trim();
            string[] diem_arr = diemPart.Split(',');
            listDiem.Clear();
            foreach (string diem in diem_arr)
            {
                string d = diem.Trim();
                if (d == "") continue;
                if (double.TryParse(d, out double diemSo))
                {
                    if(diemSo < 0 || diemSo > 10)
                    {
                        MessageBox.Show("Dữ liệu điểm không hợp lệ: " + d);
                        listDiem.Clear();
                        return;
                    }
                    listDiem.Add(diemSo);
                }
                else
                {
                    MessageBox.Show("Dữ liệu điểm không hợp lệ: " + d);
                    listDiem.Clear();
                    return;
                }
            }

            makeListMon();
        }

        public void makeListMon()
        {
            listMon.Clear();
            int i = 1;
            foreach (double diem in listDiem)
            {
                string mon = "Môn " + i + ": " + diem;
                i++;
                listMon.Add(mon);
            }
        }

        private void Form_Bai7_Load(object sender, EventArgs e)
        {

        }

        private void btnTen_Click(object sender, EventArgs e)
        {

            if (!EnsureParsed()) 
            { 
                MessageBox.Show("       Vui lòng nhập dữ liệu!      "); 
                return; 
            }
            lblTen.Text = "Tên: " + Ten;
        }

        private void btnlistDiem_Click(object sender, EventArgs e)
        {
            if (!EnsureParsed())
            {
                MessageBox.Show("       Vui lòng nhập dữ liệu!      ");
                return;
            }
            lblDiem.Text = "";
            foreach (string diem in listMon)
            {
                lblDiem.Text += diem + " ";
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            if (!EnsureParsed())
            {
                MessageBox.Show("       Vui lòng nhập dữ liệu!      ");
                return;
            }
            lblDau.Text = "Các môn đậu: ";
            foreach (double diem in listDiem)
            {
                if (diem >= 5)
                    lblDau.Text += diem + " ";
            }
            lblDau.Text += "\nCác môn không đậu: ";
            foreach (double diem in listDiem)
            {
                if (diem < 5)
                    lblDau.Text += diem + " ";
            }
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (!EnsureParsed())
            {
                MessageBox.Show("       Vui lòng nhập dữ liệu!      ");
                return;
            }
            double max = listDiem.Max();
            double min = listDiem.Min();
            lblMaxmin.Text = "Điểm cao nhất: " + max + "\nĐiểm thấp nhất: " + min;
        }

        private void btnDTB_Click(object sender, EventArgs e)
        {
            if (!EnsureParsed())
            {
                MessageBox.Show("       Vui lòng nhập dữ liệu!      ");
                return;
            }
            double dtb = listDiem.Average();
            lblDTB.Text = "Điểm trung bình: " + dtb.ToString("F2");
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {

            if (!EnsureParsed())
            {
                MessageBox.Show("       Vui lòng nhập dữ liệu!      ");
                return;
            }

            double dtb = listDiem.Average();
            double min = listDiem.Min();


            if (dtb >= 8 && min >= 6.5)
                lblXepLoai.Text = "Xếp loại: Giỏi";  
            else if (dtb >= 6.5 && min >= 5)
                lblXepLoai.Text = "Xếp loại: Khá";
            else if (dtb >= 5 && min >= 3.5)
                lblXepLoai.Text = "Xếp loại: Trung bình";
            else if (dtb >= 3.5 && min >= 2)
                lblXepLoai.Text = "Xếp loại: Yếu";
            else
                lblXepLoai.Text = "Xếp loại: Kém";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParseData();

            if (listDiem.Count > 0)
            {
                btnTen_Click(sender, e);
                btnlistDiem_Click(sender, e);
                btnDau_Click(sender, e);
                btnDTB_Click(sender, e);
                btnMaxMin_Click(sender, e);
                btnXepLoai_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblMaxmin.Text = "";
            lblTen.Text = "";
            lblDau.Text = "";
            lblDTB.Text = "";
            lblXepLoai.Text = "";
            lblDiem.Text = "";
            txtBai7.Text = "";
            Ten = "";
            listDiem.Clear();
            listMon.Clear();
            txtBai7.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu_Lab1 f = new Menu_Lab1();
            this.Hide();
            f.ShowDialog();
        }
    }
}
