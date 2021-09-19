//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace DemoQLKS.DAO
//{
//    class DAOLichSuHoaDon
//    {
//        QLTXDataContext db;

//        public DAOLichSuHoaDon()
//        {
//            db = new QLTXDataContext();
//        }

//        public List<HoaDon> LayDS()
//        {
//            List<HoaDon> ds = db.HoaDons.Select(p => p).ToList();
//            return ds;
//        }

//    }
//}
