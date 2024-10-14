using System;
using System.Drawing;
using System.Windows.Forms;

namespace DangNhapControl
{
    public class LabelCustom : Label
    {
        public LabelCustom()
        {
            // Thiết lập font mặc định là Arial, kích thước 14
            this.Font = new Font("Arial", 14, FontStyle.Regular);

            // Thiết lập màu sắc mặc định
            this.BackColor = Color.Transparent; // Nền trong suốt
            this.ForeColor = Color.Black; // Màu chữ đen

            // Thiết lập căn chỉnh văn bản ở giữa
            this.TextAlign = ContentAlignment.MiddleCenter;
        }

        // Phương thức in đậm
        public void SetBold()
        {
            this.Font = new Font(this.Font, FontStyle.Bold);
        }

        // Phương thức in nghiêng
        public void SetItalic()
        {
            this.Font = new Font(this.Font, FontStyle.Italic);
        }

        // Phương thức đặt lại font thường
        public void SetRegular()
        {
            this.Font = new Font(this.Font, FontStyle.Regular);
        }

        // Phương thức gạch chân
        public void SetUnderline()
        {
            this.Font = new Font(this.Font, FontStyle.Underline);
        }

        // Phương thức đặt màu chữ báo lỗi
        public void SetErrorStyle()
        {
            this.ForeColor = Color.Red; // Đặt màu chữ là màu đỏ cho lỗi
        }

        // Phương thức đặt màu chữ báo thành công
        public void SetSuccessStyle()
        {
            this.ForeColor = Color.Green; // Đặt màu chữ là màu xanh cho thành công
        }

        // Phương thức đặt màu chữ cảnh báo
        public void SetWarningStyle()
        {
            this.ForeColor = Color.Orange; // Đặt màu chữ là màu cam cho cảnh báo
        }

        // Phương thức đặt màu chữ mặc định
        public void ResetColor()
        {
            this.ForeColor = Color.Black; // Màu chữ đen mặc định
        }
    }
}
