using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frm_LapHoaDon : Form
    {
        HangHoa_BLL hh = new HangHoa_BLL();
        public frm_LapHoaDon()
        {
            InitializeComponent();
            this.Load += Frm_LapHoaDon_Load;
        }

        private void Frm_LapHoaDon_Load(object sender, EventArgs e)
        {
            this.panel_DanhSachSanPham.Controls.Clear();
            var dsHangHoa = hh.layDanhSachHangHoa();

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
                this.panel_DanhSachSanPham.Controls.Add(layoutItem);
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
