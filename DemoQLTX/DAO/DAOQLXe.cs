using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAOQLXe
    {
        QLTXDataContext db;

        public DAOQLXe()
        {
            db = new QLTXDataContext();
        }

        public dynamic LayDSDT()
        {
            dynamic ds = db.TTXeDangThues.Select(s => new { 
                        s.idXe,
                        s.CMND,
                        s.TênKH,
                        s.TimeStart,
                        s.SoNguoi,
                        s.ThoiGianThue,
                        s.PhuThuCheckIn,
                        s.GiaXe,
            });

            return ds;
        }

        public List<Xe> LayDSConTrong()
        {
            List<Xe> ds = db.Xes.Where(s => s.Status.Equals("Còn trống")).ToList();
            return ds;
        }
        public bool CheckXDTById(int id)
        {
            List<TTXeDangThue> ds = db.TTXeDangThues.Where(s => s.idXe.Equals(id)).ToList();
            if (ds.Any())
                return true;
            else return false;
        }

        public List<HoaDon> LaydsHoaDon()
        {
            return db.HoaDons.Select(s => s).ToList();

        }
        
    }
}
