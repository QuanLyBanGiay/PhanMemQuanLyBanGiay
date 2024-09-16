using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlHelperLibrary;

namespace LoginControlLibrary
{
    public partial class RegisterControl : UserControl
    {
        string conn;
        public string Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        SQLClass sql = new SQLClass();
        public EventHandler RegisterSuccessful;
        public EventHandler Close;
        public RegisterControl()
        {
            InitializeComponent();
            cbChucVu.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;
            btnDangKy.Click += BtnDangKy_Click;
            btnThoat.Click += BtnThoat_Click;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Close(sender, EventArgs.Empty);
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            //B1: đăng ký vào bảng nhân viên
            string chucVu = cbChucVu.SelectedItem.ToString();
            string hoTen = txtHoTen.Text;
            string gioiTinh = cbGioiTinh.SelectedItem.ToString();
            string diaChi = txtDiaChi.Text;
            string dienThoai = txtDienThoai.Text;
            string email = txtEmail.Text;
            float luong = Convert.ToInt32(txtLuong.Text);

            string tenDN = txtTenDN.Text;
            string matKhau = txtMatKhau.Text;
            string nhapLaiMK = txtNhapLaiMK.Text;

            int maNhanVien = -1;

            if (chucVu == "" || hoTen == "" || gioiTinh == "" || diaChi == "" || dienThoai == "" || email == "" || tenDN == "" || matKhau == "" || nhapLaiMK == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if (!matKhau.Equals(nhapLaiMK))
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp");
                return;
            }
            sql.CreateConnection(conn);
            string query = "select count(*) from TAIKHOANNV where TenDN = '" + tenDN + "'";

            int result = (int)sql.ExecuteScalar(query);
            if (result != 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
                return;
            }

            query = "select * from NHANVIEN";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = (SqlDataAdapter)sql.ExcuteQuery(query, out dt);
            if (dt != null)
            {
                DataRow dr = dt.NewRow();
                dr["ChucVu"] = chucVu;
                dr["HoTen"] = hoTen;
                dr["GioiTinh"] = gioiTinh;
                dr["DiaChi"] = diaChi;
                dr["DienThoai"] = dienThoai;
                dr["Email"] = email;
                dr["Luong"] = luong;

                dt.Rows.Add(dr);
                bool insert = sql.Update(adapter, dt);//Cập nhật vào bảng nhân viên
                if (insert)
                {//lấy mã nhân viên để tạo tài khoản nhân viên
                    dt.Clear();
                    sql.ExcuteQuery(query, out dt);
                    //Lấy nhân viên cuối cùng trong dt
                    if (dt.Rows.Count > 0)
                    {
                        DataRow nhanVienCuoi = dt.Rows[dt.Rows.Count - 1];
                        maNhanVien = Convert.ToInt32(nhanVienCuoi["MaNV"]);
                    }
                }
            }

            //B2: đăng ký vào bảng tài khoản nhân viên
            dt.Clear();
            result = 0;
            query = "select * from TAIKHOANNV";
            adapter = (SqlDataAdapter)sql.ExcuteQuery(query, out dt);
            if (dt != null)
            {
                DataRow dr = dt.NewRow();

                dr["MaNV"] = maNhanVien;
                dr["TenDN"] = tenDN;
                dr["MatKhau"] = matKhau;
                dr["DaKhoa"] = 0;

                dt.Rows.Add(dr);

                bool insert = sql.Update(adapter, dt);//Cập nhật dữ liệu vào bảng tài khoản nhân viên
                if (insert)
                {
                    MessageBox.Show("Đăng ký thành công");
                    RegisterSuccessful(sender, EventArgs.Empty);
                }
            }
        }
    }
}
