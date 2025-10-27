/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB01.Bai04;
using LAB01.Form_Bai4;
namespace LAB01.Form_Bai4
{
    public partial class Form_ChonViTri : Form
    {
        public Form_ChonViTri()
        {
            InitializeComponent();
        }


        public List<int> PHIM1 = new List<int>() { 90000, 45000, 45000 / 4 };
        public List<int> PHIM2 = new List<int>() { 200000, 100000, 100000 / 4 };
        public List<int> PHIM3 = new List<int>() { 140000, 70000, 70000 / 4 };
        public List<int> PHIM4 = new List<int>() { 180000, 90000, 90000 / 4 };


        private int Ghe = -1;
        private readonly HashSet<string> Vot = new() { "A1", "A5", "C1", "C5" };
        private readonly HashSet<string> Vip = new() { "B2", "B3", "B4" };

        private void Form_ChonViTri_Load(object sender, EventArgs e)
        {
            // gắn 1 handler cho tất cả button ghế
            foreach (var btn in this.Controls.OfType<Button>()) // hoặc this.Controls
                btn.Click += Seat_Click;
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            // Lấy mã ghế; ưu tiên Tag nếu bạn có set Tag="A1"...,
            // không thì lấy Text, cuối cùng fallback từ Name "btnA1" -> "A1"
            string seat = btn.Tag?.ToString() ?? (btn.Text?.Trim().Length > 0 ? btn.Text.Trim() : btn.Name[3..]);

            // gán Ghe theo quy tắc
            Ghe = seat switch
            {
                "B2" or "B3" or "B4" => 0,         // VIP
                "A1" or "A5" or "C1" or "C5" => 2,         // vé vớt
                _ => 1          // còn lại: thường
            };
        }


        public int GiaVe()
        {
            FormChonPhim Phim = new FormChonPhim();
            int phim = Phim.SelectedMovieIndex;
            if (phim == 0 && Ghe == 0) return PHIM1[0];
            else if (phim == 0 && Ghe == 1) return PHIM1[1];
            else if (phim == 0 && Ghe == 2) return PHIM1[2];
            else if (phim == 1 && Ghe == 0) return PHIM2[0];
            else if (phim == 1 && Ghe == 1) return PHIM2[1];
            else if (phim == 1 && Ghe == 2) return PHIM2[2];
            else if (phim == 2 && Ghe == 0) return PHIM3[0];
            else if (phim == 2 && Ghe == 1) return PHIM3[1];
            else if (phim == 2 && Ghe == 2) return PHIM3[2];
            else if (phim == 3 && Ghe == 0) return PHIM4[0];
            else if (phim == 3 && Ghe == 1) return PHIM4[1];
            else if (phim == 3 && Ghe == 2) return PHIM4[2];
            else return -1;
        }


        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            FormChonPhim Phim = new FormChonPhim();
            int phim = Phim.SelectedMovieIndex;
            int phong = Phim.SelectedRoom;
            int gia = GiaVe();
            if (gia == -1)
                MessageBox.Show("Vui lòng chọn ghế ngồi hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show($"Giá vé của bạn là: {gia} VND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LAB01.Bai04;

namespace LAB01.Form_Bai4
{
    public partial class Form_ChonViTri : Form
    {
        // Lưu thông tin phim được chọn
        private int _selectedMovieIndex = -1;
        private int _selectedRoom = -1;
        private string _selectedSeat = "";

        public List<int> PHIM1 = new List<int>() { 90000, 45000, 45000 / 4 };
        public List<int> PHIM2 = new List<int>() { 200000, 100000, 100000 / 4 };
        public List<int> PHIM3 = new List<int>() { 140000, 70000, 70000 / 4 };
        public List<int> PHIM4 = new List<int>() { 180000, 90000, 90000 / 4 };

        private int Ghe = -1;
        private readonly HashSet<string> Vot = new() { "A1", "A5", "C1", "C5" };
        private readonly HashSet<string> Vip = new() { "B2", "B3", "B4" };

        public Form_ChonViTri(int movieIndex, int room)
        {
            InitializeComponent();
            _selectedMovieIndex = movieIndex;
            _selectedRoom = room;
            WireSeatClicks();   // <= gắn sự kiện click cho tất cả ghế
        }

        private void WireSeatClicks()
        {
            // nếu các nút ở ngay trên form:
            var seats = new[]
            {
                btnA1, btnA2, btnA3, btnA4, btnA5,
                btnB1, btnB2, btnB3, btnB4, btnB5,
                btnC1, btnC2, btnC3, btnC4, btnC5
            };
            foreach (var b in seats)
                b.Click += Seat_Click;
        }


        private void Seat_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            // Lấy mã ghế từ Text của button
            _selectedSeat = btn.Text.Trim();

            if (_bookedSeats.Contains(_selectedSeat)) return;


            // Xác định loại ghế
            if (Vip.Contains(_selectedSeat))
                Ghe = 0;  // VIP
            else if (Vot.Contains(_selectedSeat))
                Ghe = 2;  // Vé vớt
            else
                Ghe = 1;  // Vé thường

            // Highlight button được chọn (tất cả button khác màu nhạt, button chọn màu đậm)
            foreach (var b in this.Controls.OfType<Button>())
            {
                if (b.Name.StartsWith("btn") && b.Name != "btnXacNhan")
                {
                    if (b == btn)
                        b.BackColor = System.Drawing.Color.Yellow;  // Highlight
                    else
                        b.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);  // Màu gốc
                }
            }
        }

        private int GiaVe()
        {
            if (_selectedMovieIndex < 0 || Ghe < 0)
                return -1;

            // Sử dụng mảng để lấy giá
            List<int>[] prices = { PHIM1, PHIM2, PHIM3, PHIM4 };
            return prices[_selectedMovieIndex][Ghe];
        }


        // GHẾ ĐÃ ĐẶT
        private readonly HashSet<string> _bookedSeats = new();

        private Button? GetSeatButton(string seat)
        {
            var found = this.Controls.Find("btn" + seat, true);
            return found.Length > 0 ? found[0] as Button : null;
        }

        // Đánh dấu ghế đã đặt: đổi màu + disable
        private void BookSeat(string seat)
        {
            var btn = this.Controls.Find("btn" + seat, true).FirstOrDefault() as Button;
            if (btn == null) return;

            _bookedSeats.Add(seat);
            btn.Enabled = false;                 // quan trọng: đã đặt thì khóa hẳn
            btn.BackColor = Color.Gray;          // xám
            btn.ForeColor = Color.White;
        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            int gia = GiaVe();

            if (_selectedMovieIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn phim!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(_selectedSeat))
            {
                MessageBox.Show("Vui lòng chọn ghế ngồi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gia < 0)
            {
                MessageBox.Show("Lỗi tính giá vé!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ten = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập tên của bạn:", "Thông tin khách hàng", "");

            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] movieNames = { "Đào, phở và piano", "Mai", "Gặp lại chị bầu", "Tarot" };
            string ticketType = Ghe == 0 ? "VIP" : (Ghe == 2 ? "Vé vớt" : "Vé thường");

            MessageBox.Show(
                $"            Khách: {ten}\n" +
                $"            Phim: {movieNames[_selectedMovieIndex]}            \n" +
                $"            Phòng: {_selectedRoom}              \n" +
                $"            Ghế: {_selectedSeat}            \n" +
                $"            Loại vé: {ticketType}           \n" +
                $"            Giá vé: {gia} VND          ",
                "Xác nhận đặt vé",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            BookSeat(_selectedSeat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormChonPhim phim = new FormChonPhim();
            phim.Show();
            this.Hide();
        }
    }
}