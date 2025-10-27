using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB01
{
    public partial class Form_Bai1 : Form
    {
        public Form_Bai1()
        {
            InitializeComponent();
        }


        private void btnTinh_Click(object sender, EventArgs e)
        {
            int so1, so2;
            if (!int.TryParse(txtSo1.Text, out so1) || !int.TryParse(txtSo2.Text, out so2))
            {
                MessageBox.Show("       Vui lòng nhập lại         ",
                    "Bạn Nhập sai");
                return;
            }

            if (txtSo1.Text == "" || txtSo2.Text == "")
            {
                MessageBox.Show("       Vui lòng nhập lại         ",
                    "Bạn chưa nhập số");
                return;
            }

            int tong = so1 + so2;
            btnKetqua.Text = ""+ tong;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Menu_Lab1 menu = new Menu_Lab1();
            menu.Show();
            this.Hide();

        }
    }
}
