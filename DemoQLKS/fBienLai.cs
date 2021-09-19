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
    public partial class fBienLai : Form
    {
        BUS.BUSBienLai BusBL;
        int idxe;
        public fBienLai()
        {
            InitializeComponent();
            BusBL = new BUS.BUSBienLai();
        }

        public fBienLai(int id)
            : this()
        {
            idxe = id;
        }

        private void fBienLai_Load(object sender, EventArgs e)
        {
            
           TTXeDangThue tt = BusBL.LayTT(idxe);
           BusBL.tinhGiaCheckout(tt);
           lb_idPhong.Text = idxe.ToString();
           lb_tenKH.Text = tt.TênKH.ToString();
           lb_cmnd.Text = tt.CMND.ToString();
           lb_soNguoi.Text = tt.SoNguoi.ToString();
           lb_tgVao.Text = tt.TimeStart.ToString();
           lbGiaNY.Text = tt.GiaXe.ToString();
           lb_tgThue.Text = tt.ThoiGianThue.ToString();
           lbCheckIn.Text = tt.PhuThuCheckIn.ToString();
           lbTienCI.Text = ((tt.PhuThuCheckIn * tt.GiaXe) / 100).ToString();
           lbCheckOut.Text = tt.PhuThuCheckOut.ToString();
           lbTienCO.Text = ((tt.PhuThuCheckOut * tt.GiaXe) / 100).ToString();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            BusBL.themPhuThu(int.Parse(tb_phuthu.Text.ToString()), idxe);
            TTXeDangThue tt = BusBL.LayTT(idxe);
            BusBL.tinhGia(tt);
            lb_total.Text = tt.Total.ToString();
        }

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                BusBL.themPhuThu(int.Parse(tb_phuthu.Text.ToString()), idxe);

                TTXeDangThue tt = BusBL.LayTT(idxe);
                BusBL.tinhGia(tt);
                lb_total.Text = tt.Total.ToString();
                HoaDon hd = new HoaDon();
                hd.idXe = idxe;
                hd.TenKH = tt.TênKH;
                hd.CMND = tt.CMND;
                hd.NgayLapHD = DateTime.Now;
                hd.PhuThuCI = tt.PhuThuCheckIn;
                hd.PhuThuCO = tt.PhuThuCheckOut;
                hd.GiaPhongNiemYet = tt.GiaXe;
                hd.SoNgayThue = tt.ThoiGianThue;
                hd.PhuThu = tt.PhuThuThem;
                hd.TongCong = tt.Total;

                BusBL.themHoaDon(hd);
                BusBL.xoa(tt);
                BusBL.capNhatStatus(idxe);
                this.Close();
                MessageBox.Show("Trả xe thành công");
            }
            catch (Exception)
            {
                
                MessageBox.Show("Trả xe không thành công");
            }

        }
    }
}
