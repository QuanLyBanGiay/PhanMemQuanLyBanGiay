using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class HangHoa_BLL
    {
        HangHoa_DAL hh = new HangHoa_DAL();
        public HangHoa_BLL() { }
        public List<HANGHOA> layDanhSachHangHoa()
        {
            return hh.layDanhSachHangHoa();
        }
        public int tinhTongSoLuong()
        {
            try
            {
                List<HANGHOA> ds = layDanhSachHangHoa();
                int tong = 0;
                foreach (HANGHOA h in ds)
                {
                    tong = tong + (h.SoLuongTon ?? 0);
                }
                return tong;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
