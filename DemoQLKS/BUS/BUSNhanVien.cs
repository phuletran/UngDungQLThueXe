using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS.BUS
{
    class BUSNhanVien
    {
        DAO.DAONhanVien da;
        public BUSNhanVien()
        {
            da = new DAO.DAONhanVien();
        }

        public void LayDSNV(DataGridView dg)
        {
            dg.DataSource = da.LayDSNV();
        }

        public void ThemNhanVien(NhanVien nv)
        {

            if (da.ThemNhanVien(nv))
                MessageBox.Show("Thêm thành công!");
            else
                MessageBox.Show("Thêm thất bại!");
        }

        public void XoaNhanVien(int id)
        {
            if (da.XoaNhanVien(id))
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa thất bại!");
        }
        public void SuaNhanVien(NhanVien nv)
        {
            if (da.SuaNhanVien(nv))
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Sửa thất bại!");

        }
    }
}
