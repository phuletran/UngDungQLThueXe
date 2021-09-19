using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAODsKH
    {
        QLTXDataContext db;

        public DAODsKH()
        {
            db = new QLTXDataContext();
        }

        public List<KhachHang> LayDSKH()
        {
            return db.KhachHangs.Select(s => s).ToList();

        }
    }
}
