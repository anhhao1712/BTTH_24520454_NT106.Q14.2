using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class Form_Bai8 : Form
    {
        public Form_Bai8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMonAn.Text == "")
            {
                MessageBox.Show("               Vui lòng nhập món ăn!               ");
                return;
            }
            lstMonAn.Items.Add(txtMonAn.Text);
            txtMonAn.Clear();
        }



        private void btnTim_Click(object sender, EventArgs e)
        {
            if (lstMonAn.Items.Count == 0)
            {
                label2.Text = "Vui lòng nhập món ăn!";
                return;
            }    
            Random rd = new Random();
            int index = rd.Next(0, lstMonAn.Items.Count);
            
            label2.Text = "" + lstMonAn.Items[index].ToString();
        }

      

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstMonAn.Items.Clear();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Menu_Lab1 menu = new Menu_Lab1();
            menu.Show();
            this.Hide();
        }
    }
}
