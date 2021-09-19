using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAOHoaDon
    {
        QLTXDataContext db;

        public DAOHoaDon()
        {
            db = new QLTXDataContext();
        }
        public List<HoaDon> layDS()
        {
            return db.HoaDons.Select(s => s).ToList();
        }
    }
}
