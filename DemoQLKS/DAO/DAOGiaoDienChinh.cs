using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    
    class DAOGiaoDienChinh
    {
        QLTXDataContext db;
        public DAOGiaoDienChinh()
        {
            db = new QLTXDataContext();
        }

        public bool checkRole(int id)
        {
            IEnumerable<NhanVien> ds = from NhanVien in db.NhanViens 
                                where NhanVien.ID == id && NhanVien.Role == "Quản lý"
                                select NhanVien;    
            if(ds.Any())
                return true;
            return false;
        }

        public bool LichSu(LichSuDangNhap ls)
        {
            try
            {
                db.LichSuDangNhaps.InsertOnSubmit(ls);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
