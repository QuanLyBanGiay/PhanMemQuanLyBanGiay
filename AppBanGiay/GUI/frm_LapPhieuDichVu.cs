using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_LapPhieuDichVu : Form
    {
        public frm_LapPhieuDichVu()
        {
            InitializeComponent();
            this.Load += Frm_LapPhieuDichVu_Load;
        }

        private void Frm_LapPhieuDichVu_Load(object sender, EventArgs e)
        {
            var dsHangHoa = new List<DTO.HANGHOA>
            {
                new DTO.HANGHOA
                {
                    MaHangHoa = 1,
                    TenHangHoa = "Áo thun",
                    GiaBan = 100000,
                    SoLuongTon = 10
                },
                new DTO.HANGHOA
                {
                    MaHangHoa = 2,
                    TenHangHoa = "Quần jean",
                    GiaBan = 200000,
                    SoLuongTon = 20
                },
                new DTO.HANGHOA
                {
                    MaHangHoa = 3,
                    TenHangHoa = "Áo sơ mi",
                    GiaBan = 300000,
                    SoLuongTon = 30
                }
            };
            int itemsPerRow = 5;
            int itemWidth = 100;
            int itemHeight = 50;
            int spacing = itemWidth + 10;
            int currentRow = 0;
            int currentColumn = 0;

            foreach (var item in dsHangHoa)
            {
                var layoutItem = new DangNhapControl.Layout_Item_SanPham();
                layoutItem.hanghoa = item;
                layoutItem.Left = currentColumn * (itemWidth + spacing);
                layoutItem.Top = currentRow * (itemHeight + spacing);

                this.panel1.Controls.Add(layoutItem);

                currentColumn++;
                if (currentColumn >= itemsPerRow)
                {
                    currentColumn = 0;
                    currentRow++;
                }
            }
        }
    }
}
