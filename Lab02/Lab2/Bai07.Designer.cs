namespace Lab2
{
    partial class Bai07
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
            trvDirectory = new TreeView();
            grbCha = new GroupBox();
            ptbHienThi = new PictureBox();
            rtbNoiDung = new RichTextBox();
            grbCha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHienThi).BeginInit();
            SuspendLayout();
            // 
            // trvDirectory
            // 
            trvDirectory.Location = new Point(0, 0);
            trvDirectory.Name = "trvDirectory";
            trvDirectory.Size = new Size(216, 453);
            trvDirectory.TabIndex = 0;
            trvDirectory.BeforeExpand += trvDirectory_BeforeExpand;
            trvDirectory.AfterSelect += trvDirectory_AfterSelect;
            trvDirectory.NodeMouseDoubleClick += trvDirectory_NodeMouseDoubleClick;
            // 
            // grbCha
            // 
            grbCha.Controls.Add(rtbNoiDung);
            grbCha.Controls.Add(ptbHienThi);
            grbCha.Location = new Point(222, 12);
            grbCha.Name = "grbCha";
            grbCha.Size = new Size(576, 441);
            grbCha.TabIndex = 1;
            grbCha.TabStop = false;
            grbCha.Text = "File content";
            // 
            // ptbHienThi
            // 
            ptbHienThi.Dock = DockStyle.Fill;
            ptbHienThi.Location = new Point(3, 23);
            ptbHienThi.Name = "ptbHienThi";
            ptbHienThi.Size = new Size(570, 415);
            ptbHienThi.SizeMode = PictureBoxSizeMode.Zoom;
            ptbHienThi.TabIndex = 0;
            ptbHienThi.TabStop = false;
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.Dock = DockStyle.Fill;
            rtbNoiDung.Location = new Point(3, 23);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.ReadOnly = true;
            rtbNoiDung.Size = new Size(570, 415);
            rtbNoiDung.TabIndex = 1;
            rtbNoiDung.Text = "";
            rtbNoiDung.Visible = false;
            // 
            // Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbCha);
            Controls.Add(trvDirectory);
            Name = "Bai07";
            Text = "Bai07";
            FormClosing += Bai07_FormClosing;
            grbCha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbHienThi).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private TreeView trvDirectory;
        private GroupBox grbCha;
        private PictureBox ptbHienThi;
        private RichTextBox rtbNoiDung;
    }
}