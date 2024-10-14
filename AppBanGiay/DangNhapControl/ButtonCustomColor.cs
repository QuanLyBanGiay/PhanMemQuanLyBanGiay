using System;
using System.Drawing;
using System.Windows.Forms;

namespace DangNhapControl
{
    public class ButtonCustomColor : Button
    {
        public Color BorderColor { get; set; } = Color.White; // Màu viền mặc định
        public int BorderSize { get; set; } = 2; // Độ dày viền mặc định
        public Color HoverBorderColor { get; set; } = Color.Blue; // Màu viền khi hover
        private bool isHovered = false; // Biến trạng thái hover

        public ButtonCustomColor()
        {
            this.FlatStyle = FlatStyle.Flat; // Loại bỏ viền mặc định
            this.FlatAppearance.BorderSize = 0; // Loại bỏ viền mặc định của Button
            this.BackColor = ColorTranslator.FromHtml("#0033FF"); // Màu nền mặc định

            // Thiết lập màu chữ là trắng và kiểu chữ in đậm
            this.ForeColor = Color.White;
            this.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Bold);

            // Sự kiện để thay đổi màu khi di chuột vào và ra khỏi button
            this.MouseEnter += (s, e) => { isHovered = true; this.Invalidate(); };
            this.MouseLeave += (s, e) => { isHovered = false; this.Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Kiểm tra trạng thái hover để đổi màu viền
            Color currentBorderColor = isHovered ? HoverBorderColor : BorderColor;

            // Vẽ viền với màu sắc và độ dày tùy chỉnh
            using (Pen pen = new Pen(currentBorderColor, BorderSize))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                Rectangle rect = this.ClientRectangle;

                // Giảm kích thước hình chữ nhật để viền không bị cắt
                rect.X += BorderSize / 2;
                rect.Y += BorderSize / 2;
                rect.Width -= BorderSize;
                rect.Height -= BorderSize;

                pevent.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}
