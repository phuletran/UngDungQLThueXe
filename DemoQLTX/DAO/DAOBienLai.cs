using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAOBienLai
    {
        QLTXDataContext db;
        public DAOBienLai()
        {
            db = new QLTXDataContext();
        }

        public TTXeDangThue LayTT(int id)
        {
            TTXeDangThue thongtin = db.TTXeDangThues.Where(s => s.idXe.Equals(id)).SingleOrDefault();
            return thongtin;
        }

        public void tinhCheckOut(TTXeDangThue tt)
        {
            TTXeDangThue tg = db.TTXeDangThues.Where(i => i.idXe.Equals(tt.idXe)).SingleOrDefault();
            DateTime d = DateTime.Now;
            if (14 <= d.Hour && d.Hour <= 18)
                tt.PhuThuCheckOut = 50;
            else if (d.Hour > 18)
                tt.PhuThuCheckOut = 100;
            else
                tt.PhuThuCheckOut = 0;
            db.SubmitChanges();

        }
        public void themPhuThu(int gia, int id)
        {
            TTXeDangThue tt = db.TTXeDangThues.Where(i => i.idXe.Equals(id)).SingleOrDefault();
            tt.PhuThuThem = gia;
            db.SubmitChanges();
        }

        public void tinhGia(TTXeDangThue tt)
        {
            TTXeDangThue thongtin = db.TTXeDangThues.Where(s => s.idXe.Equals(tt.idXe)).SingleOrDefault();
            int tienCI = ((thongtin.PhuThuCheckIn * tt.GiaXe) / 100).Value;
            int tienCO = ((thongtin.PhuThuCheckOut * tt.GiaXe) / 100).Value;
            int tienPhuThu = thongtin.PhuThuThem.Value;
            int giaThueTheoNgay = (tt.GiaXe * thongtin.ThoiGianThue).Value;
            thongtin.Total = tienCI + tienCO + tienPhuThu + giaThueTheoNgay;
            db.SubmitChanges();

        }
        public void capNhatStatus(int id)
        {
            Xe x = db.Xes.Where(s => s.ID.Equals(id)).SingleOrDefault();
            x.Status = "Còn trống";
            db.SubmitChanges();
        }
        public void xoa(TTXeDangThue tt)
        {
            db.TTXeDangThues.DeleteOnSubmit(tt);
            db.SubmitChanges();
        }
        public void ThemHD(HoaDon hd)
        {
            db.HoaDons.InsertOnSubmit(hd);
            db.SubmitChanges();
        }
    }
}
