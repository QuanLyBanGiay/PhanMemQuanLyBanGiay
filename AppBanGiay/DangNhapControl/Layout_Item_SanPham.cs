using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //this.pictureBox1.Image = Image.FromFile("");
            
            //hanghoa.MaHangHoa = 1;
            //hanghoa.TenHangHoa = "Áo thun";
            //hanghoa.GiaBan = 100000;
            //hanghoa.SoLuongTon = 10;
            this.lbl_GiaBan.Text = hanghoa.GiaBan.ToString();
            this.lbl_TenHangHoa.Text = hanghoa.TenHangHoa;
            this.lbl_SoLuongTon.Text = hanghoa.SoLuongTon.ToString();
            
        }

        private void Btn_Giam_Click(object sender, EventArgs e)
        {
            if(int.Parse(txt_SoLuongMua.Text) > 0)
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
            if(txt_SoLuongMua.Text == "")
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
