using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
            ptbHienThi.SizeMode = PictureBoxSizeMode.Zoom;
            ptbHienThi.Dock = DockStyle.Fill;

            LoadDrives();
        }

        private void LoadDrives()
        {
            trvDirectory.Nodes.Clear();

            try
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    if (drive.IsReady)
                    {
                        TreeNode driveNode = new TreeNode($"{drive.Name}")
                        {
                            Tag = drive.RootDirectory.FullName
                        };

                        driveNode.Nodes.Add(new TreeNode());
                        trvDirectory.Nodes.Add(driveNode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load ổ đĩa: {ex.Message}");
            }
        }

        private void trvDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;

            if (node.Nodes.Count == 1 && node.Nodes[0].Tag == null)
            {
                node.Nodes.Clear();
                LoadDirectoryContent(node);
            }
        }

        private void LoadDirectoryContent(TreeNode parentNode)
        {
            string path = parentNode.Tag as string;
            if (string.IsNullOrEmpty(path)) return;

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);

                DirectoryInfo[] directories = dirInfo.GetDirectories();
                foreach (DirectoryInfo dir in directories)
                {

                    if ((dir.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden ||
                        (dir.Attributes & FileAttributes.System) == FileAttributes.System)
                        continue;

                    TreeNode dirNode = new TreeNode(dir.Name)
                    {
                        Tag = dir.FullName
                    };

                    try
                    {
                        if (dir.GetDirectories().Length > 0 || dir.GetFiles().Length > 0)
                        {
                            dirNode.Nodes.Add(new TreeNode()); 
                        }
                    }
                    catch { }

                    parentNode.Nodes.Add(dirNode);
                }

                FileInfo[] files = dirInfo.GetFiles();
                foreach (FileInfo file in files)
                {
                    if ((file.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden ||
                        (file.Attributes & FileAttributes.System) == FileAttributes.System)
                        continue;

                    TreeNode fileNode = new TreeNode(file.Name)
                    {
                        Tag = file.FullName,
                        ForeColor = Color.Blue
                    };
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                TreeNode errorNode = new TreeNode("Access Denied")
                {
                    ForeColor = Color.Red
                };
                parentNode.Nodes.Add(errorNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void trvDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            string path = node.Tag as string;

            if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                if (!node.IsExpanded)
                {
                    node.Expand();
                }
                else
                {
                    node.Collapse();
                }
            }
        }



        private void trvDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag as string;
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                if (ptbHienThi.Image != null) { ptbHienThi.Image.Dispose(); ptbHienThi.Image = null; }
                ptbHienThi.Visible = false;
                rtbNoiDung.Visible = false;
                return;
            }

            if (ptbHienThi.Image != null)
            {
                ptbHienThi.Image.Dispose();
                ptbHienThi.Image = null;
            }
            rtbNoiDung.Clear();

            string extension = Path.GetExtension(path).ToLower();

            string[] imgExt = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".ico" };
            string[] txtExt = { ".txt", ".log", ".sql", ".cs", ".json", ".xml", ".html", ".ini", ".md" };

            try
            {
                if (imgExt.Contains(extension))
                {
                    rtbNoiDung.Visible = false;
                    ptbHienThi.Visible = true;

                    using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        ptbHienThi.Image = Image.FromStream(stream);
                    }
                    ptbHienThi.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else if (txtExt.Contains(extension))
                {

                    ptbHienThi.Visible = false;
                    rtbNoiDung.Visible = true;
                    string content;
                    try
                    {
                        content = File.ReadAllText(path, Encoding.UTF8);
                    }
                    catch
                    {
                        content = File.ReadAllText(path, Encoding.Default);
                    }

                    const long maxBytes = 2 * 1024 * 1024;
                    var fi = new FileInfo(path);
                    if (fi.Length > maxBytes)
                    {
                        using var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        using var sr = new StreamReader(fs, Encoding.UTF8, true);
                        char[] buf = new char[200000]; 
                        int read = sr.Read(buf, 0, buf.Length);
                        rtbNoiDung.Text = new string(buf, 0, read) +
                            $"\r\n\r\n--- (Tệp lớn: chỉ xem trước ~{read:N0} ký tự) ---";
                    }
                    else
                    {
                        rtbNoiDung.Text = content;
                    }
                }
                else
                {
                    // Loại file khác: thông báo
                    ptbHienThi.Visible = false;
                    rtbNoiDung.Visible = true;
                    rtbNoiDung.Text = $"Không thể xem nội dung của loại file: {extension}";
                }
            }
            catch (Exception ex)
            {
                ptbHienThi.Visible = false;
                rtbNoiDung.Visible = true;
                rtbNoiDung.Text = $"Lỗi khi mở tệp:\r\n{ex.Message}";
            }
        }


        private void Bai07_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ptbHienThi?.Image != null)
            {
                ptbHienThi.Image.Dispose();
                ptbHienThi.Image = null;
            }
        }
    }
}