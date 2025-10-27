namespace LAB01
{
    partial class Form_Bai3_1
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
            btnDoc = new Button();
            btnThoat = new Button();
            txtSo = new TextBox();
            btnXoa = new Button();
            label1 = new Label();
            btnHienThi = new Button();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.BackColor = Color.FromArgb(255, 128, 0);
            btnDoc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDoc.Location = new Point(124, 215);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(107, 47);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = false;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 128, 0);
            btnThoat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnThoat.Location = new Point(481, 215);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 47);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtSo
            // 
            txtSo.Font = new Font("Segoe UI", 12F);
            txtSo.Location = new Point(184, 97);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(336, 34);
            txtSo.TabIndex = 2;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 128, 0);
            btnXoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(304, 215);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 47);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(184, 69);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 4;
            label1.Text = "nhập vào 1 số nguyên";
            // 
            // btnHienThi
            // 
            btnHienThi.BackColor = Color.FromArgb(224, 224, 224);
            btnHienThi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHienThi.Location = new Point(257, 296);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(215, 67);
            btnHienThi.TabIndex = 5;
            btnHienThi.UseVisualStyleBackColor = false;
            // 
            // Form_Bai3_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 450);
            Controls.Add(btnHienThi);
            Controls.Add(label1);
            Controls.Add(btnXoa);
            Controls.Add(txtSo);
            Controls.Add(btnThoat);
            Controls.Add(btnDoc);
            Name = "Form_Bai3_1";
            Text = "Bài 3 - in ra dạng chữ của 1 chữ số";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoc;
        private Button btnThoat;
        private TextBox txtSo;
        private Button btnXoa;
        private Label label1;
        private Button btnHienThi;
    }
}