using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS.BUS
{
    class BUSDsKH
    {
        DAO.DAODsKH da;
        public BUSDsKH()
        {
            da = new DAO.DAODsKH();
        }

        public void LayDSKH(DataGridView dg)
        {
            dg.DataSource = da.LayDSKH();
        }
    }
}
