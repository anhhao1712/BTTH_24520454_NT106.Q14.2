namespace LAB01
{
    partial class Form_Bai7
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
            txtBai7 = new TextBox();
            btnTen = new Button();
            btnlistDiem = new Button();
            btnDTB = new Button();
            btnMaxMin = new Button();
            btnDau = new Button();
            lblTen = new Label();
            lblXepLoai = new Label();
            btnXepLoai = new Button();
            lblDiem = new Label();
            lblDTB = new Label();
            lblMaxmin = new Label();
            lblDau = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(85, 19);
            label1.Name = "label1";
            label1.Size = new Size(572, 28);
            label1.TabIndex = 0;
            label1.Text = "nhập 1 chuỗi gồm tên và điểm theo định dạng (Tên, điểm, ...)";
            // 
            // txtBai7
            // 
            txtBai7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtBai7.Location = new Point(93, 50);
            txtBai7.Name = "txtBai7";
            txtBai7.Size = new Size(619, 34);
            txtBai7.TabIndex = 1;
            // 
            // btnTen
            // 
            btnTen.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnTen.Location = new Point(12, 103);
            btnTen.Name = "btnTen";
            btnTen.RightToLeft = RightToLeft.Yes;
            btnTen.Size = new Size(113, 36);
            btnTen.TabIndex = 2;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnlistDiem
            // 
            btnlistDiem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnlistDiem.Location = new Point(12, 154);
            btnlistDiem.Name = "btnlistDiem";
            btnlistDiem.Size = new Size(113, 56);
            btnlistDiem.TabIndex = 3;
            btnlistDiem.Text = "danh sách điểm";
            btnlistDiem.UseVisualStyleBackColor = true;
            btnlistDiem.Click += btnlistDiem_Click;
            // 
            // btnDTB
            // 
            btnDTB.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDTB.Location = new Point(12, 377);
            btnDTB.Name = "btnDTB";
            btnDTB.Size = new Size(113, 61);
            btnDTB.TabIndex = 4;
            btnDTB.Text = "Điểm trung bình";
            btnDTB.UseVisualStyleBackColor = true;
            btnDTB.Click += btnDTB_Click;
            // 
            // btnMaxMin
            // 
            btnMaxMin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnMaxMin.Location = new Point(12, 304);
            btnMaxMin.Name = "btnMaxMin";
            btnMaxMin.Size = new Size(113, 61);
            btnMaxMin.TabIndex = 5;
            btnMaxMin.Text = "Điểm cao, thấp nhất";
            btnMaxMin.UseVisualStyleBackColor = true;
            btnMaxMin.Click += btnMaxMin_Click;
            // 
            // btnDau
            // 
            btnDau.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDau.Location = new Point(12, 230);
            btnDau.Name = "btnDau";
            btnDau.Size = new Size(113, 62);
            btnDau.TabIndex = 6;
            btnDau.Text = "đậu và không đậu";
            btnDau.UseVisualStyleBackColor = true;
            btnDau.Click += btnDau_Click;
            // 
            // lblTen
            // 
            lblTen.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblTen.Location = new Point(131, 97);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(296, 48);
            lblTen.TabIndex = 7;
            lblTen.Text = "                                                         ";
            lblTen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblXepLoai
            // 
            lblXepLoai.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblXepLoai.Location = new Point(542, 103);
            lblXepLoai.Name = "lblXepLoai";
            lblXepLoai.Size = new Size(201, 48);
            lblXepLoai.TabIndex = 9;
            lblXepLoai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnXepLoai
            // 
            btnXepLoai.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnXepLoai.Location = new Point(433, 103);
            btnXepLoai.Name = "btnXepLoai";
            btnXepLoai.Size = new Size(110, 48);
            btnXepLoai.TabIndex = 8;
            btnXepLoai.Text = "Xếp loại";
            btnXepLoai.UseVisualStyleBackColor = true;
            btnXepLoai.Click += btnXepLoai_Click;
            // 
            // lblDiem
            // 
            lblDiem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblDiem.Location = new Point(131, 158);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(622, 48);
            lblDiem.TabIndex = 10;
            lblDiem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDTB
            // 
            lblDTB.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblDTB.Location = new Point(131, 381);
            lblDTB.Name = "lblDTB";
            lblDTB.Size = new Size(117, 48);
            lblDTB.TabIndex = 11;
            lblDTB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMaxmin
            // 
            lblMaxmin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblMaxmin.Location = new Point(131, 309);
            lblMaxmin.Name = "lblMaxmin";
            lblMaxmin.Size = new Size(296, 48);
            lblMaxmin.TabIndex = 12;
            lblMaxmin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDau
            // 
            lblDau.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblDau.Location = new Point(131, 230);
            lblDau.Name = "lblDau";
            lblDau.Size = new Size(589, 62);
            lblDau.TabIndex = 13;
            lblDau.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(494, 296);
            button1.Name = "button1";
            button1.Size = new Size(259, 61);
            button1.TabIndex = 14;
            button1.Text = "Hiển thị tất cả";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(494, 368);
            button2.Name = "button2";
            button2.Size = new Size(114, 61);
            button2.TabIndex = 15;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(639, 368);
            button4.Name = "button4";
            button4.Size = new Size(114, 61);
            button4.TabIndex = 17;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form_Bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblDau);
            Controls.Add(lblMaxmin);
            Controls.Add(lblDTB);
            Controls.Add(lblDiem);
            Controls.Add(lblXepLoai);
            Controls.Add(btnXepLoai);
            Controls.Add(lblTen);
            Controls.Add(btnDau);
            Controls.Add(btnMaxMin);
            Controls.Add(btnDTB);
            Controls.Add(btnlistDiem);
            Controls.Add(btnTen);
            Controls.Add(txtBai7);
            Controls.Add(label1);
            Name = "Form_Bai7";
            Text = "Bài 7 - Nhập 1 chuỗi gồm tên, điểm môn 1, ... xử lí mảng và thực hiện các phép toán";
            Load += Form_Bai7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBai7;
        private Button btnTen;
        private Button btnlistDiem;
        private Button btnDTB;
        private Button btnMaxMin;
        private Button btnDau;
        private Label lblTen;
        private Label lblXepLoai;
        private Button btnXepLoai;
        private Label lblDiem;
        private Label lblDTB;
        private Label lblMaxmin;
        private Label lblDau;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}