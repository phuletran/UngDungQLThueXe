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
    public partial class fQLXe : Form
    {
        BUS.BUSQLXe busQLXe;
        public static fHoaDon fhd;
        public static fDSKH fkh;
        public static fTTDatXe ftt;
        public static fBienLai fbl;
        public fQLXe()
        {
            InitializeComponent();
            busQLXe = new BUS.BUSQLXe();
        }

        private void QLXe_Load(object sender, EventArgs e)
        {
                busQLXe.layDSCT(gvDSXe);
                this.gvDSXe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.gvDSXe.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.gvDSXe.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.gvDSXe.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.gvDSXe.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                busQLXe.layDSDT(gvDSXDT);
                this.gvDSXDT.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.gvDSXDT.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.gvDSXDT.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.gvDSXDT.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.gvDSXDT.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.gvDSXDT.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.gvDSXDT.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.gvDSXDT.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (!busQLXe.LayDSDTByID(int.Parse(tb_ID.Text)))
                {
                    //fTTDatXe f = new fTTDatXe(int.Parse(tb_ID.Text),
                    //    int.Parse(tb_Price.Text));
                    //f.MdiParent = this;
                    //f.Show();


                    if (ftt == null || ftt.IsDisposed)
                    {
                        ftt = new fTTDatXe(int.Parse(tb_ID.Text), int.Parse(tb_Price.Text));
                        ftt.MdiParent = this;
                        ftt.Show();
                        capNhat();
                    }
                }
                else
                    MessageBox.Show("Xe đã đặt");
            }
            catch (Exception)
            {
                
                MessageBox.Show("Vui lòng chọn xe");
            }
        }

        private void capNhat()
        {
            busQLXe.layDSCT(gvDSXe);
            this.gvDSXe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDSXe.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDSXe.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDSXe.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDSXe.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            busQLXe.layDSDT(gvDSXDT);
            this.gvDSXDT.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDSXDT.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDSXDT.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDSXDT.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDSXDT.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDSXDT.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDSXDT.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDSXDT.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           
        }

        private void gvDSXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gvDSXe.Rows.Count)
            {
                tb_ID.Text = gvDSXe.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                tb_Sc.Text = gvDSXe.Rows[e.RowIndex].Cells["Capacity"].Value.ToString();
                tb_stt.Text = gvDSXe.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                tb_Price.Text = gvDSXe.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                tb_Model.Text = gvDSXe.Rows[e.RowIndex].Cells["Model"].Value.ToString();
            }    
        }

        private void gvDSXDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gvDSXDT.Rows.Count)
            {
                tb_ID.Text = gvDSXDT.Rows[e.RowIndex].Cells["IDXe"].Value.ToString();
               
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (busQLXe.LayDSDTByID(int.Parse(tb_ID.Text)))
                {
                    //fBienLai f = new fBienLai(int.Parse(tb_ID.Text));
                    //f.MdiParent = this;
                    //f.Show();
                 

                    if (fbl == null || fbl.IsDisposed)
                    {
                        fbl = new fBienLai(int.Parse(tb_ID.Text));
                        fbl.MdiParent = this;
                        fbl.Show();
                        capNhat();
                    }
                }
                else
                    MessageBox.Show("Xe chưa được thuê");
            }
            catch (Exception)
            {
                
                MessageBox.Show("Vui lòng chọn xe");
            }
           
        }

    

        private void bt_cn_Click(object sender, EventArgs e)
        {
            capNhat();
        }

        private void xemHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fHoaDon f = new fHoaDon();
            //f.Show();
            if (fhd == null || fhd.IsDisposed)
            {
                fhd = new fHoaDon();
                fhd.MdiParent = this;
                fhd.Show();
            }
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fDSKH f = new fDSKH();
            //f.MdiParent = this;
            //f.Show();
            if (fkh == null || fkh.IsDisposed)
            {
                fkh = new fDSKH();
                fkh.MdiParent = this;
                fkh.Show();
            }


        }
    }
}
