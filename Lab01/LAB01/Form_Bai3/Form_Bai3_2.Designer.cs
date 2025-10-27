namespace LAB01
{
    partial class Form_Bai3_2
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
            btnHienThi = new Button();
            label1 = new Label();
            btnXoa = new Button();
            txtSo = new TextBox();
            btnThoat = new Button();
            btnDoc = new Button();
            SuspendLayout();
            // 
            // btnHienThi
            // 
            btnHienThi.BackColor = Color.FromArgb(224, 224, 224);
            btnHienThi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHienThi.Location = new Point(-2, 284);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(720, 123);
            btnHienThi.TabIndex = 11;
            btnHienThi.UseVisualStyleBackColor = false;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(185, 55);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 10;
            label1.Text = "nhập vào 1 số nguyên";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 128, 0);
            btnXoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(301, 190);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 47);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtSo
            // 
            txtSo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSo.Location = new Point(185, 83);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(341, 38);
            txtSo.TabIndex = 8;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 128, 0);
            btnThoat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnThoat.Location = new Point(478, 190);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 47);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDoc
            // 
            btnDoc.BackColor = Color.FromArgb(255, 128, 0);
            btnDoc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDoc.Location = new Point(121, 190);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(107, 47);
            btnDoc.TabIndex = 6;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = false;
            btnDoc.Click += btnDoc_Click;
            // 
            // Form_Bai3_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 407);
            Controls.Add(btnHienThi);
            Controls.Add(label1);
            Controls.Add(btnXoa);
            Controls.Add(txtSo);
            Controls.Add(btnThoat);
            Controls.Add(btnDoc);
            Name = "Form_Bai3_2";
            Text = "Bài 3.2 - nhập số tối đa 12 chữ só và in ra chữ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHienThi;
        private Label label1;
        private Button btnXoa;
        private TextBox txtSo;
        private Button btnThoat;
        private Button btnDoc;
    }
}