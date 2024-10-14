using BLL;
using DevExpress.Data.Utils;
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

namespace GUI
{
    public partial class frm_NhaCungCap : Form
    {
        NhaCungCap_BLL nhaCungCap = new NhaCungCap_BLL();
        public frm_NhaCungCap()
        {
            InitializeComponent();
            setUp();
            this.Load += frm_NhaCungCap_Load;
            this.dgv_DanhSachNhaCungCap.SelectionChanged += dgv_DanhSachNhaCungCap_SelectionChanged;
            this.btn_Them.Click += Btn_Them_Click;
            this.btn_CapNhat.Click += Btn_CapNhat_Click;
        }
        private void Btn_CapNhat_Click(object sender, EventArgs e)
        {
            string strMaNCC = txt_MaNCC.Text;
            string tenNCC = txt_TenNCC.Text;
            string soDT = txt_SDT.Text;
            string diaChi = txt_DiaChi.Text;
            string email = txt_Email.Text;
            int maNCC = int.Parse(strMaNCC);
            NHACUNGCAP ncc = createNCC(tenNCC, diaChi, email, soDT);
            if (nhaCungCap.CapNhatNhaCungCapByMa(maNCC, ncc))
            {
                MessageBox.Show("Thêm thành công");
                load();
                return;
            }
            else
            {
                MessageBox.Show("Thất bại");
                return;
            }

        }
        private void Btn_Them_Click(object sender, EventArgs e)
        {
            string tenNCC = txt_TenNCC.Text;
            string diaChi = txt_DiaChi.Text;
            string email = txt_Email.Text;
            string soDT = txt_SDT.Text;
            NHACUNGCAP ncc = createNCC(tenNCC, diaChi, email, soDT);
            if (nhaCungCap.ThemNhaCungCap(ncc))
            {
                MessageBox.Show("Thêm thành công");
                load();
                return;
            }
            else
            {
                MessageBox.Show("Thất bại");
                return;
            }
        }
        private void dgv_DanhSachNhaCungCap_SelectionChanged(object sender, EventArgs e)
        {
            string maNCC = this.dgv_DanhSachNhaCungCap.CurrentRow.Cells["MaNCC"].Value.ToString();
            string tenNCC = this.dgv_DanhSachNhaCungCap.CurrentRow.Cells["TenNCC"].Value.ToString();
            string diaChi = this.dgv_DanhSachNhaCungCap.CurrentRow.Cells["DiaChi"].Value.ToString();    
            string email = this.dgv_DanhSachNhaCungCap.CurrentRow.Cells["DiaChiEmail"].Value.ToString();
            string soDienThoai = this.dgv_DanhSachNhaCungCap.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            this.txt_MaNCC.Text = maNCC;
            this.txt_TenNCC.Text = tenNCC;
            this.txt_DiaChi.Text = diaChi;
            this.txt_Email.Text = email;
            this.txt_SDT.Text = soDienThoai;
            txt_TenNCC.Focus();
        }
        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            load();
            this.dgv_DanhSachNhaCungCap.Columns["MaNCC"].HeaderText = "Mã NCC";
            this.dgv_DanhSachNhaCungCap.Columns["TenNCC"].HeaderText = "Tên NCC";
            this.dgv_DanhSachNhaCungCap.Columns["DiaChi"].HeaderText = "Địa chỉ";
            this.dgv_DanhSachNhaCungCap.Columns["SoDienThoai"].HeaderText = "Số điện thoại";       
            this.dgv_DanhSachNhaCungCap.Columns["DiaChiEmail"].Visible = false;
            this.txt_MaDonDatHang.Enabled = false;
            this.txt_MaNCC.Enabled = false;
        }
        private void setUp()
        {
            this.dgv_DanhSachNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  
            this.dgv_DanhSachDonDatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;      
            this.dgv_DanhSachNhaCungCap.ReadOnly = true;
        }
        private void clear()
        {
            txt_MaNCC.Text = "";
            txt_TenNCC.Text = "";
            txt_DiaChi.Text = "";
            txt_Email.Text = "";
            txt_SDT.Text = "";
        }
        private void load()
        {
            this.dgv_DanhSachNhaCungCap.DataSource = nhaCungCap.LayDanhSachNhaCungCap();
        }
        private NHACUNGCAP createNCC(string tenNCC, string diaChi, string email, string soDT)
        {
            NHACUNGCAP ncc = new NHACUNGCAP();
            ncc.TenNCC = tenNCC;
            ncc.DiaChi = diaChi;
            ncc.DiaChiEmail = email;
            ncc.SoDienThoai = soDT;
            return ncc;
        }
    }
}
