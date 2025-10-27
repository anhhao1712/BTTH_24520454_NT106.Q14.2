namespace Lab2
{
    partial class Bai02
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
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSize = new TextBox();
            txtURL = new TextBox();
            txtLine = new TextBox();
            txtWord = new TextBox();
            txtChara = new TextBox();
            lblHienThi = new Label();
            btnHienThi = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(277, 27);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 91);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Size:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 152);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 3;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 211);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 4;
            label4.Text = "Line count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 266);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 5;
            label5.Text = "Word cound";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 326);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 6;
            label6.Text = "Character count";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(124, 91);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(277, 27);
            txtSize.TabIndex = 7;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(124, 149);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(277, 27);
            txtURL.TabIndex = 8;
            // 
            // txtLine
            // 
            txtLine.Location = new Point(124, 208);
            txtLine.Name = "txtLine";
            txtLine.Size = new Size(277, 27);
            txtLine.TabIndex = 9;
            // 
            // txtWord
            // 
            txtWord.Location = new Point(124, 263);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(277, 27);
            txtWord.TabIndex = 10;
            // 
            // txtChara
            // 
            txtChara.Location = new Point(124, 319);
            txtChara.Name = "txtChara";
            txtChara.Size = new Size(277, 27);
            txtChara.TabIndex = 11;
            // 
            // lblHienThi
            // 
            lblHienThi.Location = new Point(407, 31);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(254, 259);
            lblHienThi.TabIndex = 12;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(441, 309);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(109, 54);
            btnHienThi.TabIndex = 13;
            btnHienThi.Text = "Đọc";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(587, 309);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(109, 54);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 381);
            Controls.Add(btnThoat);
            Controls.Add(btnHienThi);
            Controls.Add(lblHienThi);
            Controls.Add(txtChara);
            Controls.Add(txtWord);
            Controls.Add(txtLine);
            Controls.Add(txtURL);
            Controls.Add(txtSize);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "Bai02";
            Text = "Bài 2 - Thông tin các File txt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSize;
        private TextBox txtURL;
        private TextBox txtLine;
        private TextBox txtWord;
        private TextBox txtChara;
        private Label lblHienThi;
        private Button btnHienThi;
        private Button btnThoat;
    }
}