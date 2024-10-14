using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormMain()
        {
            InitializeComponent();
            this.Load += FormMain_Load;
            this.WindowState = FormWindowState.Maximized;
            this.btn_LapPhieuDichVu.Click += Btn_LapPhieuDichVu_Click;
            this.btn_Kho.Click += Btn_Kho_Click;
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadForm(new frm_KhoHang(), mainPanel);
        }

        private void Btn_Kho_Click(object sender, EventArgs e)
        {
            LoadForm(new frm_KhoHang(), mainPanel);
        }

        private void Btn_LapPhieuDichVu_Click(object sender, EventArgs e)
        {
            LoadForm(new frm_LapPhieuDichVu(), mainPanel);
        }

        public void LoadForm(Form form, Panel panel)
        {
            // Đóng các form hiện tại trong panel
            if (panel.Controls.Count > 0)
            {
                panel.Controls.Clear(); // Xóa các điều khiển hiện có
            }

            // Thiết lập form
            form.TopLevel = false; // Đặt TopLevel là false để có thể thêm vào panel
            form.FormBorderStyle = FormBorderStyle.None; // Ẩn viền form
            form.Dock = DockStyle.Fill; // Đặt dock cho form

            // Thêm form vào panel
            panel.Controls.Add(form);
            form.Show(); // Hiển thị form
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }

        private void btn_LapHoaDon_Click(object sender, EventArgs e)
        {
            LoadForm(new frm_LapHoaDon(),mainPanel);
        }
    }
}
