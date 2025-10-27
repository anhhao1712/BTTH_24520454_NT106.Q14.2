namespace LAB01
{
    partial class Form_Bai6
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
            txtNhap = new TextBox();
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lblHienThi = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 70);
            label1.Name = "label1";
            label1.Size = new Size(429, 25);
            label1.TabIndex = 0;
            label1.Text = "nhập vào ngày tháng năm sinh (Tháng/Ngày/Năm)";
            // 
            // txtNhap
            // 
            txtNhap.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtNhap.Location = new Point(147, 98);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(420, 38);
            txtNhap.TabIndex = 1;
            txtNhap.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(128, 255, 128);
            btnTim.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnTim.Location = new Point(132, 212);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(106, 50);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(128, 255, 128);
            btnXoa.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnXoa.Location = new Point(307, 212);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 50);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(128, 255, 128);
            btnThoat.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnThoat.Location = new Point(484, 212);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 50);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblHienThi
            // 
            lblHienThi.AllowDrop = true;
            lblHienThi.AutoEllipsis = true;
            lblHienThi.BackColor = Color.FromArgb(192, 255, 255);
            lblHienThi.CausesValidation = false;
            lblHienThi.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHienThi.ForeColor = Color.FromArgb(255, 128, 0);
            lblHienThi.Location = new Point(0, 289);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(725, 110);
            lblHienThi.TabIndex = 5;
            lblHienThi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(722, 396);
            Controls.Add(lblHienThi);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(txtNhap);
            Controls.Add(label1);
            Name = "Form_Bai6";
            Text = "Bài 6 - Nhập ngày tháng năm sinh, xuất ra cung hoàng đạo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhap;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
        public Label lblHienThi;
        protected internal Label label2;
    }
}