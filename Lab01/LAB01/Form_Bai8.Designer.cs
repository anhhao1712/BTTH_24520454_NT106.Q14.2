namespace LAB01
{
    partial class Form_Bai8
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
            lstMonAn = new ListBox();
            button1 = new Button();
            txtMonAn = new TextBox();
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lstMonAn
            // 
            lstMonAn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstMonAn.FormattingEnabled = true;
            lstMonAn.ItemHeight = 23;
            lstMonAn.Location = new Point(407, 43);
            lstMonAn.Name = "lstMonAn";
            lstMonAn.Size = new Size(198, 234);
            lstMonAn.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.Location = new Point(153, 136);
            button1.Name = "button1";
            button1.Size = new Size(151, 56);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtMonAn
            // 
            txtMonAn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtMonAn.Location = new Point(100, 73);
            txtMonAn.Name = "txtMonAn";
            txtMonAn.Size = new Size(251, 34);
            txtMonAn.TabIndex = 2;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(255, 128, 0);
            btnTim.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnTim.Location = new Point(100, 294);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(151, 56);
            btnTim.TabIndex = 3;
            btnTim.Text = "Tìm Món Ăn";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(128, 128, 255);
            btnXoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(300, 294);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(151, 56);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(128, 128, 255);
            btnThoat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnThoat.Location = new Point(490, 294);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(151, 56);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 50);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 6;
            label1.Text = "nhập tên món ăn";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(0, 387);
            label2.Name = "label2";
            label2.Size = new Size(735, 83);
            label2.TabIndex = 7;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(275, 359);
            label3.Name = "label3";
            label3.Size = new Size(189, 28);
            label3.TabIndex = 8;
            label3.Text = "Món ăn hôm nay là";
            // 
            // Form_Bai8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(728, 467);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(txtMonAn);
            Controls.Add(button1);
            Controls.Add(lstMonAn);
            Name = "Form_Bai8";
            Text = "Bài 8 - Nhập tên món ăn rồi random 1 món";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMonAn;
        private Button button1;
        private TextBox txtMonAn;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}