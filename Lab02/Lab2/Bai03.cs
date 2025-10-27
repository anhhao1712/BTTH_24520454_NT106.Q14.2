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
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream("Text3.txt", FileMode.OpenOrCreate, FileAccess.Read))
            using (var sr = new StreamReader(fs))
            {
                string text = sr.ReadToEnd();
                btnHienThi1.Text = text;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Text3.txt");
            using (var fs1 = new FileStream("output3.txt", FileMode.Create, FileAccess.Write))
            using (var sw = new StreamWriter(fs1))
            {
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    try
                    {
                        double result = Evaluate(line); //Evaluate là hàm tính toán kết quả từng hàm và ghi vào output3.txt
                        sw.WriteLine($"{line} = {result}");
                    }
                    catch (Exception ex)
                    {
                        sw.WriteLine($"{line} = Lỗi ({ex.Message})");
                    }
                }
            }
            MessageBox.Show("Đã tính xong và ghi vào output3.txt!");
        }

        private void btnDocFileKetQua_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream("output3.txt", FileMode.Open, FileAccess.Read))
            using (var sr = new StreamReader(fs))
            {
                string text = sr.ReadToEnd();
                btnHienThi2.Text = text;
            }
        }

        private double Evaluate(string expr)
        {
            Stack<double> values = new Stack<double>();
            Stack<char> ops = new Stack<char>();

            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];

                if (c == ' ')
                    continue;

                if (char.IsDigit(c))
                {
                    string num = "";
                    while (i < expr.Length && (char.IsDigit(expr[i]) || expr[i] == '.'))
                    {
                        num += expr[i];
                        i++;
                    }
                    i--; // quay lại 1 bước
                    values.Push(double.Parse(num));
                }
                else if (c == '(')
                {
                    ops.Push(c);
                }
                else if (c == ')')
                {
                    while (ops.Peek() != '(')
                        values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                    ops.Pop(); // bỏ '('
                }
                else if (IsOperator(c))
                {
                    while (ops.Count > 0 && Precedence(ops.Peek()) >= Precedence(c))
                        values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                    ops.Push(c);
                }
            }

            while (ops.Count > 0)
                values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));

            return values.Pop();
        }

        private bool IsOperator(char c)
        {
            return (c == '+' || c == '-' || c == '*' || c == '/');
        }

        private int Precedence(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return 0;
        }

        private double ApplyOp(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return b == 0 ? double.NaN : a / b;
            }
            return 0;
        }
    }
}
