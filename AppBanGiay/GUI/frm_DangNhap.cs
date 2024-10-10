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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
            this.dangNhapControl1.DangNhapThanhCong += DangNhapControl1_DangNhapThanhCong;   
        }

        private void DangNhapControl1_DangNhapThanhCong(object sender, EventArgs e)
        {
            Form f = new frm_Main();
            this.Hide();
            f.Show();
        }
    }
}
