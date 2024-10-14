using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class NhaCungCap_BLL
    {
        NhaCungCap_DAL dal = new NhaCungCap_DAL();
        public NhaCungCap_BLL() { }
        public List<NHACUNGCAP> LayDanhSachNhaCungCap()
        {
            return dal.LayDanhSachNhaCungCap();
        }
        public bool ThemNhaCungCap(NHACUNGCAP ncc)
        {
            return dal.ThemNhaCungCap(ncc);
        }
        public bool CapNhatNhaCungCapByMa(int maNCC, NHACUNGCAP nccUpdate)
        {
            return dal.CapNhatNhaCungCapByMa(maNCC, nccUpdate);
        }
    }
}
