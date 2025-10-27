namespace Lab2
{
    partial class Bai05
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
            lblHienThi = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGhiVaolbl = new Button();
            btnDoc = new Button();
            lblSoTrang = new Label();
            cboTenPhim = new ComboBox();
            cboPhongChieu = new ComboBox();
            cboGheNgoi = new ComboBox();
            cboLoaiGhe = new ComboBox();
            cboGiaVe = new ComboBox();
            txtTen = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblHienThi
            // 
            lblHienThi.Location = new Point(234, 7);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(544, 401);
            lblHienThi.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 283);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 224);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 170);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 114);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 64);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 43;
            // 
            // btnGhiVaolbl
            // 
            btnGhiVaolbl.BackColor = Color.Cyan;
            btnGhiVaolbl.Location = new Point(62, 314);
            btnGhiVaolbl.Name = "btnGhiVaolbl";
            btnGhiVaolbl.Size = new Size(103, 29);
            btnGhiVaolbl.TabIndex = 42;
            btnGhiVaolbl.Text = "Add";
            btnGhiVaolbl.UseVisualStyleBackColor = false;
            btnGhiVaolbl.Click += btnGhiVaolbl_Click;
            // 
            // btnDoc
            // 
            btnDoc.BackColor = Color.Cyan;
            btnDoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoc.Location = new Point(62, 361);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(127, 53);
            btnDoc.TabIndex = 50;
            btnDoc.Text = "Read to File";
            btnDoc.UseVisualStyleBackColor = false;
            btnDoc.Click += btnDoc_Click;
            // 
            // lblSoTrang
            // 
            lblSoTrang.AutoSize = true;
            lblSoTrang.Location = new Point(626, 335);
            lblSoTrang.Name = "lblSoTrang";
            lblSoTrang.Size = new Size(0, 20);
            lblSoTrang.TabIndex = 51;
            // 
            // cboTenPhim
            // 
            cboTenPhim.FormattingEnabled = true;
            cboTenPhim.Location = new Point(8, 87);
            cboTenPhim.Name = "cboTenPhim";
            cboTenPhim.Size = new Size(220, 28);
            cboTenPhim.TabIndex = 52;
            cboTenPhim.Text = "Tên phim";
            cboTenPhim.SelectedIndexChanged += cboTenPhim_SelectedIndexChanged;
            // 
            // cboPhongChieu
            // 
            cboPhongChieu.FormattingEnabled = true;
            cboPhongChieu.Location = new Point(8, 137);
            cboPhongChieu.Name = "cboPhongChieu";
            cboPhongChieu.Size = new Size(220, 28);
            cboPhongChieu.TabIndex = 53;
            cboPhongChieu.Text = "Phòng chiếu";
            // 
            // cboGheNgoi
            // 
            cboGheNgoi.FormattingEnabled = true;
            cboGheNgoi.Location = new Point(8, 182);
            cboGheNgoi.Name = "cboGheNgoi";
            cboGheNgoi.Size = new Size(220, 28);
            cboGheNgoi.TabIndex = 54;
            cboGheNgoi.Text = "Ghế ngồi";
            cboGheNgoi.SelectedIndexChanged += cboGheNgoi_SelectedIndexChanged;
            // 
            // cboLoaiGhe
            // 
            cboLoaiGhe.FormattingEnabled = true;
            cboLoaiGhe.Location = new Point(8, 233);
            cboLoaiGhe.Name = "cboLoaiGhe";
            cboLoaiGhe.Size = new Size(220, 28);
            cboLoaiGhe.TabIndex = 55;
            cboLoaiGhe.Text = "Loại ghế";
            // 
            // cboGiaVe
            // 
            cboGiaVe.FormattingEnabled = true;
            cboGiaVe.Location = new Point(8, 280);
            cboGiaVe.Name = "cboGiaVe";
            cboGiaVe.Size = new Size(220, 28);
            cboGiaVe.TabIndex = 56;
            cboGiaVe.Text = "Giá vé";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(46, 28);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(167, 27);
            txtTen.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 28);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 58;
            label6.Text = "Tên";
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 417);
            Controls.Add(label6);
            Controls.Add(txtTen);
            Controls.Add(cboGiaVe);
            Controls.Add(cboLoaiGhe);
            Controls.Add(cboGheNgoi);
            Controls.Add(cboPhongChieu);
            Controls.Add(cboTenPhim);
            Controls.Add(lblSoTrang);
            Controls.Add(btnDoc);
            Controls.Add(lblHienThi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGhiVaolbl);
            Name = "Bai05";
            Text = "Bai05";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lblHienThi;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGhiVaolbl;
        private Button btnDoc;
        private Label lblSoTrang;
        private ComboBox cboTenPhim;
        private ComboBox cboPhongChieu;
        private ComboBox cboGheNgoi;
        private ComboBox cboLoaiGhe;
        private ComboBox cboGiaVe;
        private TextBox txtTen;
        private Label label6;
    }
}