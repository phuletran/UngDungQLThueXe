using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAOLichSuDangNhap
    {
        QLTXDataContext db;
        public DAOLichSuDangNhap()
        {
            db = new QLTXDataContext();
        }

        public List<LichSuDangNhap> CapNhat()
        {
             
            List<LichSuDangNhap> lsdn = db.LichSuDangNhaps.Select(p => p).ToList();
            return lsdn;
        }
        
    }
}
