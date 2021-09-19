using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAONhanVien
    {
        QLTXDataContext db;
        public DAONhanVien()
        {
            db = new QLTXDataContext();
        }

        public List<NhanVien> LayDSNV()
        {
            List<NhanVien> dsNV = db.NhanViens.Select(p => p).ToList();
            return dsNV;
        }
        public bool ThemNhanVien(NhanVien nv)
        {
            bool kq = false;

            try
            {
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                kq = true;
            }
            catch (Exception)
            {
                
                kq = false;
            }
            return kq;
        }
        public bool XoaNhanVien(int id)
        {
            bool kq = false;

            try
            {
                //NhanVien xoa = db.NhanViens.Where(i => i.ID.Equals(id)).SingleOrDefault();
                //db.NhanViens.DeleteOnSubmit(xoa);
                //db.SubmitChanges();
                //kq = true;
                db.xoaNhanVien(id);
                kq = true;
            }
            catch (Exception)
            {

                kq = false;
            }
            return kq;
        }
        public bool SuaNhanVien(NhanVien nv)
        {
            bool kq = false;
            NhanVien sua = new NhanVien();

            try
            {
                sua = db.NhanViens.First(s => s.ID == nv.ID);
                kq = true;
                sua.Name = nv.Name;
                sua.DoB = nv.DoB;
                sua.Phone = nv.Phone;
                sua.Sex = nv.Sex;
                sua.Role = nv.Role;
                db.SubmitChanges();
            }
            catch (Exception)
            {
                
                kq = false;
            }
            return kq;
        }
            
    }
}
