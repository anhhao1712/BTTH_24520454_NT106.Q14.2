

namespace Lab2
{
    public partial class Menu_Lab2 : Form
    {
        public Menu_Lab2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai01 bai01 = new Bai01();
            this.Hide();
            bai01.ShowDialog();
            this.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Bai02 bai02 = new Bai02();
            this.Hide();
            bai02.ShowDialog();
            this.Show();

        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Bai03 bai03 = new Bai03();
            this.Hide();
            bai03.ShowDialog();
            this.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Bai04 bai04 = new Bai04();
            this.Hide();
            bai04.ShowDialog();
            this.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Bai05 bai05 = new Bai05();
            this.Hide();
            bai05.ShowDialog();
            this.Show();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            Bai07 bai07 = new Bai07();
            this.Hide();
            bai07.ShowDialog();
            this.Show();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            Bai06 bai06 = new Bai06();
            this.Hide();
            bai06.ShowDialog();
            this.Show();

        }

        /*
        private void btnBai7_Click(object sender, EventArgs e)
        {
            Bai07 bai07 = new Bai07();
            this.Hide();
            bai07.ShowDialog();
            this.Show();
        }
        */
    }
}
