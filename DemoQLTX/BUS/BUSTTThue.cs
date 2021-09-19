using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS.BUS
{
    class BUSTTThue
    {
        DAO.DAOTThue da;
        public BUSTTThue()
        {
            da = new DAO.DAOTThue();
        }
        public void themTT(TTXeDangThue tt)
        {
            if (da.themTT(tt))
                MessageBox.Show("Thuê thành công");
            else
                MessageBox.Show("Thuê thất bại");
        }

        public void capNhatXe(int id)
        {
            da.capNhatXe(id);
        }
        public void themKH(KhachHang kh)
        {
            da.themKH(kh);
        }
        
    }
}
