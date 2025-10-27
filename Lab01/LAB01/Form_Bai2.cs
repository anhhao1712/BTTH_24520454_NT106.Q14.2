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
    public partial class Form_Bai2 : Form
    {
        public Form_Bai2()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            double so1, so2, so3;

            if (!double.TryParse(txt1.Text, out so1) 
                || !double.TryParse(txt2.Text, out so2) 
                || !double.TryParse(txt3.Text, out so3))
            {
                MessageBox.Show("       Vui lòng nhập lại         ",
                    "Bạn Nhập sai");
                return;
            }

            if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "")
            {
                MessageBox.Show("       Vui lòng nhập         ",
                    "Bạn chưa nhập");
                return;
            }
            List<double> numbers = new List<double> { so1, so2, so3 };
            double max = numbers[0];
            double min = numbers[0];
            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

            }

            btnMax.Text = "" + max;

            btnMin.Text = "" + min;


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            btnMax.Text = "";
            btnMin.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Menu_Lab1 menu = new Menu_Lab1();
            menu.Show();
            this.Hide();

        }


    }
}
