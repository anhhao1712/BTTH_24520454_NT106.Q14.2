namespace LAB01
{
    partial class Form_Bai1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            btnTinh = new Button();
            btnThoat = new Button();
            btnKetqua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(181, 60);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 0;
            label1.Text = "Số nguyên 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(181, 112);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 1;
            label2.Text = "Số nguyên 2";
            // 
            // txtSo1
            // 
            txtSo1.BackColor = Color.Silver;
            txtSo1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtSo1.Location = new Point(312, 60);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(208, 34);
            txtSo1.TabIndex = 2;
            // 
            // txtSo2
            // 
            txtSo2.BackColor = Color.Silver;
            txtSo2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtSo2.Location = new Point(312, 106);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(208, 34);
            txtSo2.TabIndex = 3;
            // 
            // btnTinh
            // 
            btnTinh.BackColor = Color.FromArgb(255, 128, 128);
            btnTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTinh.Location = new Point(181, 209);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(128, 53);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "Tính toán";
            btnTinh.UseVisualStyleBackColor = false;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Yellow;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThoat.Location = new Point(414, 209);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(128, 53);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnKetqua
            // 
            btnKetqua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnKetqua.ForeColor = Color.Red;
            btnKetqua.Location = new Point(242, 293);
            btnKetqua.Name = "btnKetqua";
            btnKetqua.Size = new Size(255, 53);
            btnKetqua.TabIndex = 6;
            btnKetqua.TabStop = false;
            btnKetqua.Text = "Kết quả";
            btnKetqua.UseVisualStyleBackColor = true;
            // 
            // Form_Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(708, 411);
            Controls.Add(btnKetqua);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Bai1";
            Text = "Bài 1 - Tính tổng 2 số nguyên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Button btnTinh;
        private Button btnThoat;
        private Button btnKetqua;
    }
}