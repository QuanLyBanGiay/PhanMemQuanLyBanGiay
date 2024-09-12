using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlHelperLibrary;

namespace LoginControlLibrary
{
    public partial class LoginContol: UserControl
    {
        string conn;
        SQLClass sql = new SQLClass();
        public EventHandler LoginSuccessful;
        public EventHandler Register;
        public string Conn { get => conn; set => conn = value; }

        public LoginContol()
        {
            InitializeComponent();
            btnDangNhap.Click += BtnDangNhap_Click;
            btnDangKy.Click += BtnDangKy_Click;

        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            Register(sender, EventArgs.Empty);
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text;
            string matKhau = txtMatKhau.Text;
            if(tenDN == "")
            {
                MessageBox.Show("Không được để trống trường này");
                txtTenDN.Focus();
                return;
            }
            if (matKhau == "")
            {
                MessageBox.Show("Không được để trống trường này");
                txtMatKhau.Focus();
                return;
            }

            try
            {
                sql.CreateConnection(conn);
                string query = "select count(*) from TAIKHOANNV where TenDN = '" + tenDN + "' and MatKhau = '" + matKhau + "'";
                int result = (int)sql.ExecuteScalar(query);
                if (result == 1)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    LoginSuccessful(sender, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
    }
}
