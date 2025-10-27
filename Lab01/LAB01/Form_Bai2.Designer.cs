namespace LAB01
{
    partial class Form_Bai2
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
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnMax = new Button();
            btnMin = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt1.Location = new Point(67, 55);
            txt1.Name = "txt1";
            txt1.Size = new Size(167, 34);
            txt1.TabIndex = 0;
            // 
            // txt2
            // 
            txt2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt2.Location = new Point(303, 55);
            txt2.Name = "txt2";
            txt2.Size = new Size(167, 34);
            txt2.TabIndex = 1;
            // 
            // txt3
            // 
            txt3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt3.Location = new Point(557, 55);
            txt3.Name = "txt3";
            txt3.Size = new Size(167, 34);
            txt3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(67, 29);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 3;
            label1.Text = "Số thứ 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(303, 29);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 4;
            label2.Text = "Số thứ 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(557, 29);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 5;
            label3.Text = "Số thứ 3";
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTim.Location = new Point(164, 143);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(109, 58);
            btnTim.TabIndex = 6;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(341, 143);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 58);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThoat.Location = new Point(521, 143);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(109, 58);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnMax
            // 
            btnMax.BackColor = SystemColors.Control;
            btnMax.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnMax.Location = new Point(310, 261);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(233, 39);
            btnMax.TabIndex = 9;
            btnMax.UseVisualStyleBackColor = false;
            // 
            // btnMin
            // 
            btnMin.BackColor = SystemColors.Control;
            btnMin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnMin.Location = new Point(310, 319);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(233, 39);
            btnMin.TabIndex = 10;
            btnMin.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(179, 261);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 11;
            label4.Text = "Số Lớn nhất:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(191, 322);
            label5.Name = "label5";
            label5.Size = new Size(118, 28);
            label5.TabIndex = 12;
            label5.Text = "Số bé nhất:";
            // 
            // Form_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnMin);
            Controls.Add(btnMax);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Name = "Form_Bai2";
            Text = "Bài 2 - Tìm số nguyên lớn nhất và nhỏ nhất";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnMax;
        private Button btnMin;
        private Label label4;
        private Label label5;
    }
}