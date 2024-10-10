using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVien_BLL
    {
        NhanVien_DAL dal = new NhanVien_DAL();
        public NhanVien_BLL()
        {
        }
        public List<NHANVIEN> LayDanhSachNhanVien()
        {
            return dal.LayDanhSachNhanVien();
        }
        public NHANVIEN LayNhanVienByMaVaMatKhau(int manv, string matKhau)
        {
            return dal.LayNhanVienByMaVaMatKhau(manv, matKhau);
        }
    }
}
