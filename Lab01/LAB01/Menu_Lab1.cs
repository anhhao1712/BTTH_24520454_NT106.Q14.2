using LAB01.Bai04;
using LAB01.Form_Bai3;

namespace LAB01
{
    public partial class Menu_Lab1 : Form
    {
        public Menu_Lab1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form_Bai1 bai1 = new Form_Bai1();
            bai1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Bai2 bai2 = new Form_Bai2();
            bai2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_Bai3 menu_Bai3 = new Menu_Bai3();
            menu_Bai3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormChonPhim chonPhim = new FormChonPhim();
            chonPhim.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)//bai5
        {
            Form_Bai5 bai5 = new Form_Bai5();
            bai5.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)//bai6
        {
            Form_Bai6 bai6 = new Form_Bai6();
            bai6.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)//bai 7
        {
            Form_Bai7 bai7 = new Form_Bai7();
            bai7.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)//bai8
        {
            Form_Bai8 bai8 = new Form_Bai8();
            bai8.Show();
            this.Hide();
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            Form_Bai3_2 bai3_2 = new Form_Bai3_2();
            bai3_2.Show();
            this.Hide();
        }

        
    }
}
