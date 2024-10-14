using System;
using System.Drawing;
using System.Windows.Forms;

namespace DangNhapControl
{
    public class DataGridViewCustom : DataGridView
    {
        public DataGridViewCustom()
        {
            // Cấu hình mặc định
            CustomizeAppearance();
        }

        // Phương thức tùy chỉnh giao diện
        private void CustomizeAppearance()
        {
            // Màu nền tổng thể cho DataGridView
            this.BackgroundColor = Color.White;

            // Màu xen kẽ giữa các dòng
            this.RowsDefaultCellStyle.BackColor = Color.LightBlue;  // Màu của dòng chẵn
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.White;  // Màu của dòng lẻ

            // Màu chữ của các dòng
            this.RowsDefaultCellStyle.ForeColor = Color.Black;  // Màu chữ của dòng chẵn
            this.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;  // Màu chữ của dòng lẻ

            // Màu tiêu đề của cột
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;  // Màu nền tiêu đề cột
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;  // Màu chữ tiêu đề cột
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);  // Chữ in đậm và lớn hơn

            // Căn giữa chữ trong tiêu đề cột
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Màu viền ô và đường lưới
            this.GridColor = Color.Blue;  // Màu đường lưới
            this.CellBorderStyle = DataGridViewCellBorderStyle.Single;  // Viền đơn quanh ô

            // Bật kẻ lưới giữa các cột và hàng
            this.EnableHeadersVisualStyles = false; // Để dùng màu tự định nghĩa cho header
        }
    }
}
