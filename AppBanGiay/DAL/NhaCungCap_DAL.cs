using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCap_DAL
    {
        ql_giayDataContext db = new ql_giayDataContext();
        public NhaCungCap_DAL() { }
        public List<NHACUNGCAP> LayDanhSachNhaCungCap()
        {
            return db.NHACUNGCAPs.Select(ncc => ncc).ToList();
        }
        public bool ThemNhaCungCap(NHACUNGCAP ncc)
        {
            try
            {
                db.NHACUNGCAPs.InsertOnSubmit(ncc);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CapNhatNhaCungCapByMa(int maNCC, NHACUNGCAP nccUpdate)
        {
            try
            {
                NHACUNGCAP ncc = db.NHACUNGCAPs.FirstOrDefault(x => x.MaNCC == maNCC);
                if (ncc != null)
                {
                    ncc.TenNCC = nccUpdate.TenNCC;
                    ncc.DiaChi = nccUpdate.DiaChi;
                    ncc.DiaChiEmail = nccUpdate.DiaChiEmail;
                    ncc.SoDienThoai = nccUpdate.SoDienThoai;
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
