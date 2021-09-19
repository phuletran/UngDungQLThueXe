using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.BUS
{
    class BUSBienLai
    {
        DAO.DAOBienLai da;
        public BUSBienLai()
        {
            da = new DAO.DAOBienLai();
        }
        public TTXeDangThue LayTT(int id)
        {
            return da.LayTT(id);
        }

        public void tinhGiaCheckout(TTXeDangThue tt)
        {
            da.tinhCheckOut(tt);
        }
        public void themPhuThu(int gia, int id)
        {
            da.themPhuThu(gia, id);
        }

        public void tinhGia(TTXeDangThue tt)
        {
            da.tinhGia(tt);
        }
        public void capNhatStatus(int id)
        {
            da.capNhatStatus(id);
        }
        public void xoa(TTXeDangThue tt)
        {
            da.xoa(tt);
        }
        public void themHoaDon(HoaDon hd)
        {
            da.ThemHD(hd);
        }
    }
}
