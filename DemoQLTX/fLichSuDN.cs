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
    public partial class fLichSuDN : Form
    {
        BUS.BUSLichSuDangNhap busLS;
        public fLichSuDN()
        {
            InitializeComponent();
            busLS = new BUS.BUSLichSuDangNhap();
        }

        private void fLichSuDN_Load(object sender, EventArgs e)
        {
            busLS.CapNhat(gvLSDN);
        }
    }
}
