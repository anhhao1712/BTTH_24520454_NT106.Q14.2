using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream("input1.txt", FileMode.OpenOrCreate, FileAccess.Read))
            using (var sr = new StreamReader(fs))
            {
                string text = sr.ReadToEnd();
                btnHienThi.Text = text;
            }
        }


        private void btnDOC2_Click(object sender, EventArgs e)
        {
            if (!File.Exists("output1.txt")) File.WriteAllText("output1.txt", "");

            using (var fs = new FileStream("output1.txt", FileMode.Open, FileAccess.Read))
            using (var sr = new StreamReader(fs))
            {
                string text = sr.ReadToEnd();
                btnHienThi2.Text = text;
            }
        }

        private void btnGhi_Click_1(object sender, EventArgs e)
        {
            string content = btnHienThi.Text;
            string upper = content.ToUpper();

            using (var fs1 = new FileStream("output1.txt", FileMode.Create, FileAccess.Write))
            using (var sw = new StreamWriter(fs1))
            {
                sw.Write(upper);
            }

            MessageBox.Show("       Ghi file thành công!        ");
        }
    }
}
