using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS.BUS
{
    class BUSLogin
    {
        DAO.DAOLogin da;
        public BUSLogin()
        {
            da = new DAO.DAOLogin();
        }

        public bool checkLogin(int ID, string pass)
        {
            if (da.checkID(ID) && pass == "admin")
                return true;
            return false;
        }
        }
    }

