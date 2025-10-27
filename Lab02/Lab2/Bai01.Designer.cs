namespace Lab2
{
    partial class Bai01
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
            btnGhi = new Button();
            btnHienThi = new Button();
            btnDOC2 = new Button();
            btnHienThi2 = new Button();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(95, 42);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(139, 53);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "Đọc File";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(95, 110);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(139, 53);
            btnGhi.TabIndex = 1;
            btnGhi.Text = "Ghi File";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click_1;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(308, 42);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(290, 121);
            btnHienThi.TabIndex = 2;
            btnHienThi.TextAlign = ContentAlignment.TopLeft;
            btnHienThi.UseVisualStyleBackColor = true;
            // 
            // btnDOC2
            // 
            btnDOC2.Location = new Point(95, 207);
            btnDOC2.Name = "btnDOC2";
            btnDOC2.Size = new Size(139, 46);
            btnDOC2.TabIndex = 3;
            btnDOC2.Text = "Đọc File vừa Ghi";
            btnDOC2.UseVisualStyleBackColor = true;
            btnDOC2.Click += btnDOC2_Click;
            // 
            // btnHienThi2
            // 
            btnHienThi2.Location = new Point(308, 207);
            btnHienThi2.Name = "btnHienThi2";
            btnHienThi2.Size = new Size(290, 121);
            btnHienThi2.TabIndex = 4;
            btnHienThi2.TextAlign = ContentAlignment.TopLeft;
            btnHienThi2.UseVisualStyleBackColor = true;
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 363);
            Controls.Add(btnHienThi2);
            Controls.Add(btnDOC2);
            Controls.Add(btnHienThi);
            Controls.Add(btnGhi);
            Controls.Add(btnDoc);
            Name = "Bai01";
            Text = "Bài 1 - Đọc và ghi File";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoc;
        private Button btnGhi;
        private Button btnHienThi;
        private Button btnDOC2;
        private Button btnHienThi2;
    }
}