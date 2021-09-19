using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS.BUS
{
    class BUSGiaoDienChinh
    {
        DAO.DAOGiaoDienChinh da;

        public BUSGiaoDienChinh()
        {
            da = new DAO.DAOGiaoDienChinh();
        }

        public bool checkRole(int id)
        {
            bool kq = da.checkRole(id);
            return kq;
        }

        public void LichSu(LichSuDangNhap ls)
        {
            if (!da.LichSu(ls))
                MessageBox.Show("Xãy ra lỗi khi sao lưu thông tin đăng nhập!");

        }
    }
}
