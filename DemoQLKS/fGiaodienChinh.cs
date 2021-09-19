using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS
{
    public partial class fGiaodienChinh : Form
    {
        public static fNhanVien fNV;
        public static fLichSuDN flsdn;
        public static fQLXe fqlx;
        private string idNV;
        BUS.BUSGiaoDienChinh busGDC = new BUS.BUSGiaoDienChinh();
        public fGiaodienChinh()
        {
            InitializeComponent();
        }

        public fGiaodienChinh(string id):this()
        {
            // TODO: Complete member initialization
            idNV = id;
        }

       

        private void GiaodienChinh_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            LichSuDangNhap lsdn = new LichSuDangNhap ();
       
            lsdn.idNhanVien = int.Parse(idNV);
            lsdn.TimeLogin = dt;

            busGDC.LichSu(lsdn);
            lbID.Text = idNV;
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (busGDC.checkRole(int.Parse(idNV)))
            {
                MessageBox.Show("Giao diện QUẢN LÝ NHÂN VIÊN sẽ hiện ra trong giây lát! Vui lòng đợi!");
                //fNhanVien fNV = new fNhanVien();
                //fNV.MdiParent = this;
                //fNV.Show();
                if (fNV == null || fNV.IsDisposed)
                {
                    fNV = new fNhanVien();
                    fNV.MdiParent = this;
                    fNV.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập vào mục này!");
        }

      

        private void lịchSửĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fLichSuDN f = new fLichSuDN();
            //f.Show();
            if (flsdn == null || flsdn.IsDisposed)
            {
                flsdn = new fLichSuDN();
                flsdn.MdiParent = this;
                flsdn.Show();
            }
        }

        private void quảnLýThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fQLXe f = new fQLXe(); 
            //f.Show();
            if (fqlx == null || fqlx.IsDisposed)
            {
                fqlx = new fQLXe();
                fqlx.Show();
            }
        }


     
    }
}
