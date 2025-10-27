namespace LAB01.Bai04
{
    partial class FormChonPhim
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
            btnPhim1 = new Button();
            btnPhim2 = new Button();
            btnPhim3 = new Button();
            btnPhim4 = new Button();
            btnPhong1 = new Button();
            btnPhong2 = new Button();
            btnPhong3 = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // btnPhim1
            // 
            btnPhim1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnPhim1.Location = new Point(80, 53);
            btnPhim1.Name = "btnPhim1";
            btnPhim1.Size = new Size(201, 67);
            btnPhim1.TabIndex = 0;
            btnPhim1.Text = "Đào, phở và piano";
            btnPhim1.UseVisualStyleBackColor = true;
            // 
            // btnPhim2
            // 
            btnPhim2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnPhim2.Location = new Point(80, 156);
            btnPhim2.Name = "btnPhim2";
            btnPhim2.Size = new Size(201, 67);
            btnPhim2.TabIndex = 1;
            btnPhim2.Text = "Mai";
            btnPhim2.UseVisualStyleBackColor = true;
            // 
            // btnPhim3
            // 
            btnPhim3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnPhim3.Location = new Point(350, 53);
            btnPhim3.Name = "btnPhim3";
            btnPhim3.Size = new Size(201, 67);
            btnPhim3.TabIndex = 2;
            btnPhim3.Text = "Gặp lại chị bầu";
            btnPhim3.UseVisualStyleBackColor = true;
            // 
            // btnPhim4
            // 
            btnPhim4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnPhim4.Location = new Point(350, 157);
            btnPhim4.Name = "btnPhim4";
            btnPhim4.Size = new Size(201, 67);
            btnPhim4.TabIndex = 3;
            btnPhim4.Text = "Tarot";
            btnPhim4.UseVisualStyleBackColor = true;
            // 
            // btnPhong1
            // 
            btnPhong1.BackColor = Color.FromArgb(255, 192, 192);
            btnPhong1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPhong1.ForeColor = Color.Red;
            btnPhong1.Location = new Point(70, 278);
            btnPhong1.Name = "btnPhong1";
            btnPhong1.Size = new Size(136, 45);
            btnPhong1.TabIndex = 4;
            btnPhong1.Text = "Phòng 1";
            btnPhong1.UseVisualStyleBackColor = false;
            // 
            // btnPhong2
            // 
            btnPhong2.BackColor = Color.FromArgb(255, 192, 192);
            btnPhong2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPhong2.ForeColor = Color.Red;
            btnPhong2.Location = new Point(258, 278);
            btnPhong2.Name = "btnPhong2";
            btnPhong2.Size = new Size(136, 45);
            btnPhong2.TabIndex = 5;
            btnPhong2.Text = "Phòng 2";
            btnPhong2.UseVisualStyleBackColor = false;
            // 
            // btnPhong3
            // 
            btnPhong3.BackColor = Color.FromArgb(255, 192, 192);
            btnPhong3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPhong3.ForeColor = Color.Red;
            btnPhong3.Location = new Point(446, 278);
            btnPhong3.Name = "btnPhong3";
            btnPhong3.Size = new Size(136, 45);
            btnPhong3.TabIndex = 6;
            btnPhong3.Text = "phòng 3";
            btnPhong3.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(483, 354);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(111, 41);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormChonPhim
            // 
            AcceptButton = btnPhong3;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnPhong3);
            Controls.Add(btnPhong2);
            Controls.Add(btnPhong1);
            Controls.Add(btnPhim4);
            Controls.Add(btnPhim3);
            Controls.Add(btnPhim2);
            Controls.Add(btnPhim1);
            Name = "FormChonPhim";
            Text = "Chọn Phim";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPhim1;
        private Button btnPhim2;
        private Button btnPhim3;
        private Button btnPhim4;
        private Button btnPhong1;
        private Button btnPhong2;
        private Button btnPhong3;
        private Button btnThoat;
    }
}