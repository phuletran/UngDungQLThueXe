using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAOTThue
    {
        QLTXDataContext db;

        public DAOTThue()
        {
            db = new QLTXDataContext();
        }

        public bool themTT(TTXeDangThue tt)
        {
            try
            {
                db.TTXeDangThues.InsertOnSubmit(tt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        public void capNhatXe(int id)
        {
            Xe x = db.Xes.Where(i => i.ID.Equals(id)).SingleOrDefault();
            x.Status = "Đã thuê";
            db.SubmitChanges();
        }
        public void themKH(KhachHang kh)
        {
            bool kq = db.KhachHangs.Where(s => s.CMND.Equals(kh.CMND)).Any();
            if (!kq)
            {
                db.KhachHangs.InsertOnSubmit(kh);
                db.SubmitChanges();
            }          
        }
       
    }
}
