using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhapControl
{
    public partial class Layout_Item_SanPham : UserControl
    {
        public HANGHOA hanghoa = new HANGHOA();
        public Layout_Item_SanPham()
        {
            InitializeComponent();
            this.Load += Layout_Item_SanPham_Load;
            this.btn_Tang.Click += Btn_Tang_Click;
            this.btn_Giam.Click += Btn_Giam_Click;
        }

        private void Layout_Item_SanPham_Load(object sender, EventArgs e)
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Hiển thị thông tin sản phẩm
            this.lbl_GiaBan.Text = hanghoa.GiaBan.ToString();
            this.lbl_TenHangHoa.Text = hanghoa.TenHangHoa;
            this.lbl_SoLuongTon.Text = hanghoa.SoLuongTon.ToString();

            // Hiển thị hình ảnh sản phẩm
            if (!string.IsNullOrEmpty(hanghoa.UrlHinhAnh))
            {
                string url = Path.Combine(Application.StartupPath, @"Resources\"+hanghoa.UrlHinhAnh);
                // Đảm bảo rằng HinhAnh là đường dẫn hợp lệ
                if (File.Exists(url))
                {
                    this.pictureBox1.Image = Image.FromFile(url);
                }
                else
                {
                    // Xử lý nếu đường dẫn hình ảnh không hợp lệ (có thể đặt hình ảnh mặc định)
                    this.pictureBox1.Image = null; // Hoặc một hình ảnh mặc định
                }
            }
        }

        private void Btn_Giam_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_SoLuongMua.Text) > 0)
            {
                txt_SoLuongMua.Text = (int.Parse(txt_SoLuongMua.Text) - 1).ToString();
            }
            else
            {
                txt_SoLuongMua.Text = "0";
            }
        }

        private void Btn_Tang_Click(object sender, EventArgs e)
        {
            if (txt_SoLuongMua.Text == "")
            {
                txt_SoLuongMua.Text = "1";
            }
            else
            {
                txt_SoLuongMua.Text = (int.Parse(txt_SoLuongMua.Text) + 1).ToString();
            }
        }
    }
}
