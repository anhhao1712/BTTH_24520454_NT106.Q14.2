using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

 

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("text2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            using (StreamReader sr = new StreamReader(fs))
            {
                string content = sr.ReadToEnd();
                lblHienThi.Text = content;
                txtName.Text = Path.GetFileName("text2.txt");
                txtURL.Text = Path.GetFullPath("text2.txt");
                FileInfo fi = new FileInfo("text2.txt");
                txtSize.Text = fi.Length.ToString() + " bytes";
                string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                txtLine.Text = lines.Length.ToString();
                string[] words = content.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                txtWord.Text = words.Length.ToString();
                txtChara.Text = content.Length.ToString();
            }
        }
    }
}
