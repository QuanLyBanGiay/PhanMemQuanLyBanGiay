using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HangHoa_DAL
    {
        ql_giayDataContext db = new ql_giayDataContext();
        public HangHoa_DAL() { }
        public List<HANGHOA> layDanhSachHangHoa()
        {
            return db.HANGHOAs.ToList();
        }
        public HANGHOA layHangHoaTheoMa(int ma)
        {
            return db.HANGHOAs.Where(hh => hh.MaHangHoa == ma).FirstOrDefault();
        }
    }
}
