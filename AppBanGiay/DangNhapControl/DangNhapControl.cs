using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using DTO;
using BLL;

namespace DangNhapControl
{
    public partial class DangNhapControl: UserControl
    {
        public event EventHandler DangNhapThanhCong;
        NhanVien_BLL bll = new NhanVien_BLL();
        public DangNhapControl()
        {
            InitializeComponent();
            this.cb_HienMatKhau.CheckedChanged += Cb_HienMatKhau_CheckedChanged;
            this.btn_DangNhap.Click += Btn_DangNhap_Click;
            this.btn_Xoa.Click += Btn_Xoa_Click;
            this.lbl_TaoTaiKhoan.Click += Lbl_TaoTaiKhoan_Click;
        }

        private void Lbl_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text = "";
            txt_MatKhau.Text = "";
            txt_TenDangNhap.Focus();
        }

        private void Btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDN = txt_TenDangNhap.Text;
                
                string matKhau = txt_MatKhau.Text;
                NHANVIEN nv = bll.LayNhanVienByTenDangNhapVaMatKhau(tenDN, matKhau);
                if(nv != null )
                {
                    MessageBox.Show("Đăng nhập thành công");
                    DangNhapThanhCong?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                }
            }
            catch (Exception ex)
            {
                hienThiLoiEx(ex);
            }
        }

        private void Cb_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_HienMatKhau.Checked)
            {
                txt_MatKhau.PasswordChar = '\0';
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }
        }
        
        private void hienThiLoiEx(Exception ex)
        {
            MessageBox.Show("Lỗi:\n" + ex.Message);
        }
    }
}
