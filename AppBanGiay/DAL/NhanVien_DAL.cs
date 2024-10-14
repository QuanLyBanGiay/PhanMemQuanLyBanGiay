using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVien_DAL
    {
        ql_giayDataContext db = new ql_giayDataContext();
        public NhanVien_DAL() { }
        public List<NHANVIEN> LayDanhSachNhanVien()
        {
            return db.NHANVIENs.Select(nv => nv).ToList();
        }
        public NHANVIEN LayNhanVienByMaVaMatKhau(int manv, string matKhau)
        {
            return db.NHANVIENs.Where(nv => nv.MaNhanVien == manv && nv.MatKhau == matKhau).FirstOrDefault();
        }
        public NHANVIEN LayNhanVienByTenDangNhapVaMatKhau(string TenDangNhap, string matKhau)
        {
            return db.NHANVIENs.Where(nv => nv.TenDangNhap == TenDangNhap && nv.MatKhau == matKhau).FirstOrDefault();
        }
    }
}
