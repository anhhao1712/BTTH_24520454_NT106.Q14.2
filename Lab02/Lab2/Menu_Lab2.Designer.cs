namespace Lab2
{
    partial class Menu_Lab2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBai1 = new Button();
            btnBai2 = new Button();
            btnBai3 = new Button();
            btnBai4 = new Button();
            btnBai5 = new Button();
            btnBai6 = new Button();
            btnBai7 = new Button();
            SuspendLayout();
            // 
            // btnBai1
            // 
            btnBai1.Location = new Point(108, 38);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(127, 52);
            btnBai1.TabIndex = 0;
            btnBai1.Text = "Bài 1";
            btnBai1.UseVisualStyleBackColor = true;
            btnBai1.Click += button1_Click;
            // 
            // btnBai2
            // 
            btnBai2.Location = new Point(108, 125);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(127, 52);
            btnBai2.TabIndex = 1;
            btnBai2.Text = "Bài 2";
            btnBai2.UseVisualStyleBackColor = true;
            btnBai2.Click += btnBai2_Click;
            // 
            // btnBai3
            // 
            btnBai3.Location = new Point(108, 219);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(127, 52);
            btnBai3.TabIndex = 2;
            btnBai3.Text = "Bài 3";
            btnBai3.UseVisualStyleBackColor = true;
            btnBai3.Click += btnBai3_Click;
            // 
            // btnBai4
            // 
            btnBai4.Location = new Point(340, 38);
            btnBai4.Name = "btnBai4";
            btnBai4.Size = new Size(127, 52);
            btnBai4.TabIndex = 3;
            btnBai4.Text = "Bài 4";
            btnBai4.UseVisualStyleBackColor = true;
            btnBai4.Click += btnBai4_Click;
            // 
            // btnBai5
            // 
            btnBai5.Location = new Point(340, 125);
            btnBai5.Name = "btnBai5";
            btnBai5.Size = new Size(127, 52);
            btnBai5.TabIndex = 6;
            btnBai5.Text = "Bài 5";
            btnBai5.UseVisualStyleBackColor = true;
            btnBai5.Click += btnBai5_Click;
            // 
            // btnBai6
            // 
            btnBai6.Location = new Point(340, 219);
            btnBai6.Name = "btnBai6";
            btnBai6.Size = new Size(127, 52);
            btnBai6.TabIndex = 5;
            btnBai6.Text = "Bài 6";
            btnBai6.UseVisualStyleBackColor = true;
            btnBai6.Click += btnBai6_Click;
            // 
            // btnBai7
            // 
            btnBai7.Location = new Point(225, 306);
            btnBai7.Name = "btnBai7";
            btnBai7.Size = new Size(127, 52);
            btnBai7.TabIndex = 4;
            btnBai7.Text = "Bài 7";
            btnBai7.UseVisualStyleBackColor = true;
            btnBai7.Click += btnBai7_Click;
            // 
            // Menu_Lab2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 400);
            Controls.Add(btnBai5);
            Controls.Add(btnBai6);
            Controls.Add(btnBai7);
            Controls.Add(btnBai4);
            Controls.Add(btnBai3);
            Controls.Add(btnBai2);
            Controls.Add(btnBai1);
            Name = "Menu_Lab2";
            Text = "Menu - Lab 2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBai1;
        private Button btnBai2;
        private Button btnBai3;
        private Button btnBai4;
        private Button btnBai5;
        private Button btnBai6;
        private Button btnBai7;
    }
}
