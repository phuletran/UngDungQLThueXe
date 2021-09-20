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
    public partial class fTTDatXe : Form
    {
        int idxe,giaxe;
        BUS.BUSTTThue busTT;
        public fTTDatXe()
        {
            InitializeComponent();
            busTT = new BUS.BUSTTThue();
        }

        public fTTDatXe(int idxe1, int giaxe1):this()
        {
            idxe = idxe1;
            giaxe = giaxe1;
        }

        private void bt_dat_Click(object sender, EventArgs e)
        {
            
            TTXeDangThue tt = new TTXeDangThue();
            KhachHang kh = new KhachHang();
            DateTime d = DateTime.Now;
            try
            {
                tt.idXe = int.Parse(idXe.Text);
                tt.CMND = tbCMND.Text.ToString();
                tt.TênKH = tb_TenKH.Text.ToString();
                tt.TimeStart = d;
                tt.ThoiGianThue = int.Parse(cbSNT.SelectedItem.ToString());
                tt.SoNguoi = int.Parse(cbSN.SelectedItem.ToString());

                kh.CMND = tbCMND.Text.ToString();
                kh.Name = tb_TenKH.Text.ToString();
                kh.Phone = tb_sdt.Text.ToString();
                kh.Address = tb_dc.Text.ToString();
                if (d.Hour > 5 && d.Hour <= 9)
                    tt.PhuThuCheckIn = 50;
                else if (d.Hour > 9 && d.Hour < 12)
                    tt.PhuThuCheckIn = 30;
                else
                    tt.PhuThuCheckIn = 0;
                tt.GiaXe = giaxe;
                busTT.themTT(tt);
                busTT.capNhatXe(idxe);
                busTT.themKH(kh);
                this.Close();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
        }

        private void TTDatXe_Load(object sender, EventArgs e)
        {
            idXe.Text = idxe.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
