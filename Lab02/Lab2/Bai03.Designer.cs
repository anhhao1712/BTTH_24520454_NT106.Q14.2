namespace Lab2
{
    partial class Bai03
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
            btnHienThi1 = new Button();
            btnHienThi2 = new Button();
            btnDocFile = new Button();
            btnGhi = new Button();
            btnDocFileKetQua = new Button();
            SuspendLayout();
            // 
            // btnHienThi1
            // 
            btnHienThi1.Location = new Point(0, 2);
            btnHienThi1.Name = "btnHienThi1";
            btnHienThi1.Size = new Size(403, 306);
            btnHienThi1.TabIndex = 0;
            btnHienThi1.UseVisualStyleBackColor = true;
            // 
            // btnHienThi2
            // 
            btnHienThi2.Location = new Point(399, 2);
            btnHienThi2.Name = "btnHienThi2";
            btnHienThi2.Size = new Size(408, 306);
            btnHienThi2.TabIndex = 1;
            btnHienThi2.UseVisualStyleBackColor = true;
            // 
            // btnDocFile
            // 
            btnDocFile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDocFile.Location = new Point(166, 346);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(119, 67);
            btnDocFile.TabIndex = 2;
            btnDocFile.Text = "Đọc File";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnGhi
            // 
            btnGhi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnGhi.Location = new Point(337, 346);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(119, 67);
            btnGhi.TabIndex = 3;
            btnGhi.Text = "Ghi File kết quả";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btnDocFileKetQua
            // 
            btnDocFileKetQua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDocFileKetQua.Location = new Point(503, 346);
            btnDocFileKetQua.Name = "btnDocFileKetQua";
            btnDocFileKetQua.Size = new Size(119, 67);
            btnDocFileKetQua.TabIndex = 4;
            btnDocFileKetQua.Text = "Đọc File kết quả";
            btnDocFileKetQua.UseVisualStyleBackColor = true;
            btnDocFileKetQua.Click += btnDocFileKetQua_Click;
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDocFileKetQua);
            Controls.Add(btnGhi);
            Controls.Add(btnDocFile);
            Controls.Add(btnHienThi2);
            Controls.Add(btnHienThi1);
            Name = "Bai03";
            Text = "Bai03";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHienThi1;
        private Button btnHienThi2;
        private Button btnDocFile;
        private Button btnGhi;
        private Button btnDocFileKetQua;
    }
}