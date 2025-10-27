namespace LAB01
{
    partial class Form_Bai5
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
            cbbChon = new ComboBox();
            label1 = new Label();
            txtA = new TextBox();
            label2 = new Label();
            txtB = new TextBox();
            btnTinh = new Button();
            button2 = new Button();
            button3 = new Button();
            btnHienThi1 = new Button();
            btnHienThi2 = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // cbbChon
            // 
            cbbChon.BackColor = Color.FromArgb(128, 255, 255);
            cbbChon.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cbbChon.FormattingEnabled = true;
            cbbChon.Location = new Point(236, 86);
            cbbChon.Name = "cbbChon";
            cbbChon.Size = new Size(223, 31);
            cbbChon.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 1;
            label1.Text = "Số nguyên A: ";
            // 
            // txtA
            // 
            txtA.BackColor = Color.FromArgb(128, 255, 255);
            txtA.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtA.Location = new Point(133, 30);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 30);
            txtA.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(418, 33);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 3;
            label2.Text = "Số nguyên B:";
            // 
            // txtB
            // 
            txtB.BackColor = Color.FromArgb(128, 255, 255);
            txtB.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtB.Location = new Point(525, 30);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 30);
            txtB.TabIndex = 4;
            // 
            // btnTinh
            // 
            btnTinh.BackColor = Color.FromArgb(255, 128, 0);
            btnTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinh.Location = new Point(98, 136);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(117, 54);
            btnTinh.TabIndex = 5;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = false;
            btnTinh.Click += btnTinh_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button2.Location = new Point(299, 149);
            button2.Name = "button2";
            button2.Size = new Size(113, 41);
            button2.TabIndex = 6;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button3.Location = new Point(496, 149);
            button3.Name = "button3";
            button3.Size = new Size(113, 41);
            button3.TabIndex = 7;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnHienThi1
            // 
            btnHienThi1.BackColor = Color.FromArgb(224, 224, 224);
            btnHienThi1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnHienThi1.Location = new Point(-2, 196);
            btnHienThi1.Name = "btnHienThi1";
            btnHienThi1.Size = new Size(371, 338);
            btnHienThi1.TabIndex = 8;
            btnHienThi1.TextAlign = ContentAlignment.TopLeft;
            btnHienThi1.UseVisualStyleBackColor = false;
            // 
            // btnHienThi2
            // 
            btnHienThi2.BackColor = Color.FromArgb(224, 224, 224);
            btnHienThi2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnHienThi2.Location = new Point(366, 196);
            btnHienThi2.Name = "btnHienThi2";
            btnHienThi2.Size = new Size(354, 338);
            btnHienThi2.TabIndex = 9;
            btnHienThi2.TextAlign = ContentAlignment.TopLeft;
            btnHienThi2.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 128, 0);
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(299, 136);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(117, 54);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 128, 0);
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(492, 136);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(117, 54);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // Form_Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(717, 531);
            Controls.Add(btnHienThi2);
            Controls.Add(btnHienThi1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnTinh);
            Controls.Add(txtB);
            Controls.Add(label2);
            Controls.Add(txtA);
            Controls.Add(label1);
            Controls.Add(cbbChon);
            Name = "Form_Bai5";
            Text = "Bài 5 - chọn bảng cửu chương A và B hoặc tính các giá trị (A-B)! & A^1 + ... +A^B";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbChon;
        private Label label1;
        private TextBox txtA;
        private Label label2;
        private TextBox txtB;
        private Button btnTinh;
        private Button button2;
        private Button button3;
        private Button btnHienThi1;
        private Button btnHienThi2;
        private Button btnXoa;
        private Button btnThoat;
    }
}