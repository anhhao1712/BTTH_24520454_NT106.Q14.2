namespace Lab2
{
    partial class Bai06
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
            trvMonAn = new TreeView();
            ptbHienThi = new PictureBox();
            label1 = new Label();
            btnNCC = new Button();
            btnShowMonAn = new Button();
            btnTim = new Button();
            txtMonAn = new TextBox();
            txtNCC = new TextBox();
            txtQuyenHan = new TextBox();
            txtFile = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnThem = new Button();
            btnHoanTat = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbHienThi).BeginInit();
            SuspendLayout();
            // 
            // trvMonAn
            // 
            trvMonAn.Location = new Point(164, 2);
            trvMonAn.Name = "trvMonAn";
            trvMonAn.Size = new Size(176, 405);
            trvMonAn.TabIndex = 2;
            // 
            // ptbHienThi
            // 
            ptbHienThi.Location = new Point(346, 171);
            ptbHienThi.Name = "ptbHienThi";
            ptbHienThi.Size = new Size(238, 236);
            ptbHienThi.TabIndex = 3;
            ptbHienThi.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 146);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 4;
            label1.Text = "Hình ảnh";
            // 
            // btnNCC
            // 
            btnNCC.Location = new Point(350, 113);
            btnNCC.Name = "btnNCC";
            btnNCC.Size = new Size(170, 29);
            btnNCC.TabIndex = 5;
            btnNCC.Text = "Tên người cung cấp";
            btnNCC.UseVisualStyleBackColor = true;
            // 
            // btnShowMonAn
            // 
            btnShowMonAn.Location = new Point(350, 69);
            btnShowMonAn.Name = "btnShowMonAn";
            btnShowMonAn.Size = new Size(170, 29);
            btnShowMonAn.TabIndex = 6;
            btnShowMonAn.Text = "Tên Món Ăn";
            btnShowMonAn.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(414, 12);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(106, 48);
            btnTim.TabIndex = 7;
            btnTim.Text = "Tìm món ăn";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // txtMonAn
            // 
            txtMonAn.Location = new Point(12, 36);
            txtMonAn.Name = "txtMonAn";
            txtMonAn.Size = new Size(146, 27);
            txtMonAn.TabIndex = 8;
            // 
            // txtNCC
            // 
            txtNCC.Location = new Point(12, 97);
            txtNCC.Name = "txtNCC";
            txtNCC.Size = new Size(146, 27);
            txtNCC.TabIndex = 9;
            // 
            // txtQuyenHan
            // 
            txtQuyenHan.Location = new Point(12, 159);
            txtQuyenHan.Name = "txtQuyenHan";
            txtQuyenHan.Size = new Size(146, 27);
            txtQuyenHan.TabIndex = 10;
            // 
            // txtFile
            // 
            txtFile.Location = new Point(12, 224);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(146, 27);
            txtFile.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 15);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 12;
            label2.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 13;
            label3.Text = "tên người cung cấp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 139);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 14;
            label4.Text = "quyền hạn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 205);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 15;
            label5.Text = "File hình ảnh món ăn";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(34, 257);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(96, 38);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHoanTat
            // 
            btnHoanTat.Location = new Point(22, 347);
            btnHoanTat.Name = "btnHoanTat";
            btnHoanTat.Size = new Size(118, 47);
            btnHoanTat.TabIndex = 17;
            btnHoanTat.Text = "Hoàn Tất";
            btnHoanTat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(34, 301);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 38);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 406);
            Controls.Add(btnXoa);
            Controls.Add(btnHoanTat);
            Controls.Add(btnThem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFile);
            Controls.Add(txtQuyenHan);
            Controls.Add(txtNCC);
            Controls.Add(txtMonAn);
            Controls.Add(btnTim);
            Controls.Add(btnShowMonAn);
            Controls.Add(btnNCC);
            Controls.Add(label1);
            Controls.Add(ptbHienThi);
            Controls.Add(trvMonAn);
            Name = "Bai06";
            Text = "Bai06";
            ((System.ComponentModel.ISupportInitialize)ptbHienThi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView trvMonAn;
        private PictureBox ptbHienThi;
        private Label label1;
        private Button btnNCC;
        private Button btnShowMonAn;
        private Button btnTim;
        private TextBox txtMonAn;
        private TextBox txtNCC;
        private TextBox txtQuyenHan;
        private TextBox txtFile;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnThem;
        private Button btnHoanTat;
        private Button btnXoa;
    }
}