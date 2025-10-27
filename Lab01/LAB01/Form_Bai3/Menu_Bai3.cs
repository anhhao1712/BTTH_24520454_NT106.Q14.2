using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01.Form_Bai3
{
    public partial class Menu_Bai3 : Form
    {
        public Menu_Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Bai3_1 bai3_1 = new Form_Bai3_1();
            bai3_1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Bai3_2 bai3_2 = new Form_Bai3_2();
            bai3_2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_Lab1 menu_Lab1 = new Menu_Lab1();
            menu_Lab1.Show();
            this.Hide();
        }
    }
}
