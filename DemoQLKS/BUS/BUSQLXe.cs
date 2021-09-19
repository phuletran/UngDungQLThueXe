using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS.BUS
{
    class BUSQLXe
    {
        DAO.DAOQLXe da;

        public BUSQLXe()
        {
            da = new DAO.DAOQLXe();
        }

        //public void layDS(DataGridView dg)
        //{
        //    dg.DataSource = da.LayDS();
        //}
        public void layDSDT(DataGridView dg)
        {
            dg.DataSource = da.LayDSDT();
        }
        public void layDSCT(DataGridView dg)
        {
            dg.DataSource = da.LayDSConTrong();
        }
        public bool LayDSDTByID(int id)
        {
            return da.CheckXDTById(id);
        }
        public List<HoaDon> layDSHoaDon()
        {
           return  da.LaydsHoaDon();
        }
        
        
    }
}
