using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class Frm_LapHoaDon : DevExpress.XtraEditors.XtraForm
    {
        NhanVien_BLL nv = new NhanVien_BLL();
        public Frm_LapHoaDon()
        {
            InitializeComponent();
            dtGV_HD.DataSource=nv.LayDanhSachNhanVien();
        }

    }
}