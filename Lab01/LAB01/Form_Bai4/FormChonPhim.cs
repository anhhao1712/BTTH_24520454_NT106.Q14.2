using LAB01.Form_Bai4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01.Bai04
{
    public partial class FormChonPhim : Form
    {
        public readonly string[] _movies =
        {
            "Đào, phở và piano", // btnPhim1
            "Mai",               // btnPhim2
            "Gặp lại chị bầu",   // btnPhim3
            "Tarot"              // btnPhim4
        };

        // Danh sách phòng hợp lệ theo index phim
        // 0: Đào, phở và piano -> 1,2,3
        // 1: Mai                 -> 2,3
        // 2: Gặp lại chị bầu     -> 1
        // 3: Tarot               -> 3
        private readonly int[][] _allowedRooms =
        {
            new[] {1,2,3},
            new[] {2,3},
            new[] {1},
            new[] {3}
        };

        private int _selectedMovieIndex = -1;
        private int _selectedRoom = 0;

        public FormChonPhim()
        {
            InitializeComponent();

            // Gán sự kiện cho nút Phim (theo thứ tự)
            btnPhim1.Click += (_, __) => SelectMovie(0, btnPhim1);
            btnPhim2.Click += (_, __) => SelectMovie(1, btnPhim2);
            btnPhim3.Click += (_, __) => SelectMovie(2, btnPhim3);
            btnPhim4.Click += (_, __) => SelectMovie(3, btnPhim4);

            // Gán sự kiện cho nút Phòng
            btnPhong1.Click += (_, __) => SelectRoom(1);
            btnPhong2.Click += (_, __) => SelectRoom(2);
            btnPhong3.Click += (_, __) => SelectRoom(3);

            // Ban đầu khoá các phòng
            EnableRooms(Array.Empty<int>());
        }


        private void SelectMovie(int movieIndex, Button pressedBtn)
        {
            _selectedMovieIndex = movieIndex;
            _selectedRoom = 0;

            HighlightMovieButton(pressedBtn);

            var ok = _allowedRooms[movieIndex];
            EnableRooms(ok);

            // Nếu chỉ có 1 phòng hợp lệ -> auto chọn
            if (ok.Length == 1)
                SelectRoom(ok[0]);
        }


        private void SelectRoom(int room)
        {
            if (_selectedMovieIndex < 0) return;  // chưa chọn phim

            var ok = _allowedRooms[_selectedMovieIndex];
            if (!ok.Contains(room)) return;       // phòng không hợp lệ (đã disable rồi)

            _selectedRoom = room;

            // Demo: hiện thông tin. Bạn có thể mở form chọn ghế ở đây.
            MessageBox.Show(
                $"            Phim: {_movies[_selectedMovieIndex]}\n            Phòng: {_selectedRoom}            ",
                "Đã chọn",
                MessageBoxButtons.OK);
            Form_ChonViTri frm = new Form_ChonViTri(_selectedMovieIndex, _selectedRoom);
            frm.ShowDialog();
            this.Hide();
        }


        private void EnableRooms(int[] allowed)
        {
            btnPhong1.Enabled = allowed.Contains(1);
            btnPhong2.Enabled = allowed.Contains(2);
            btnPhong3.Enabled = allowed.Contains(3);

            // (tuỳ chọn) đổi màu để thấy "tối" hơn khi disable:
            ApplyRoomStyle(btnPhong1);
            ApplyRoomStyle(btnPhong2);
            ApplyRoomStyle(btnPhong3);
        }

        private void HighlightMovieButton(Button active)
        {
            var allMovieButtons = new[] { btnPhim1, btnPhim2, btnPhim3, btnPhim4 };
            foreach (var b in allMovieButtons)
            {
                b.FlatStyle = FlatStyle.Standard;
                b.BackColor = System.Drawing.SystemColors.Control;
            }
            active.FlatStyle = FlatStyle.Popup;
        }


        private void ApplyRoomStyle(Button b)
        {
            if (b.Enabled)
                b.BackColor = System.Drawing.Color.MistyRose; // sáng
            else
                b.BackColor = System.Drawing.Color.Gainsboro; // tối
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Menu_Lab1 A = new Menu_Lab1();
            A.Show();
            this.Hide();
        }

        public int SelectedMovieIndex => _selectedMovieIndex;
        public int SelectedRoom => _selectedRoom;

    }
}
