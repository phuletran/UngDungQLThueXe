using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DemoQLKS.BUS
{
    class BUSLichSuDangNhap
    {
        DAO.DAOLichSuDangNhap da;
        public BUSLichSuDangNhap()
        {
            da = new DAO.DAOLichSuDangNhap();
        }

        public void CapNhat(DataGridView dg)
        {
            dg.DataSource = da.CapNhat();
        }
    }
}
