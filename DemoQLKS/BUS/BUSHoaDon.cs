using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS.BUS
{
    class BUSHoaDon
    {
        DAO.DAOHoaDon da;
        public BUSHoaDon() {
            da = new DAO.DAOHoaDon();
        }
        public void layDS(DataGridView dg)
        {
            dg.DataSource = da.layDS();
        }
    }
}
