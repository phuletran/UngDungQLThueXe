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
    public partial class fNhanVien : Form
    {
        BUS.BUSNhanVien busNhanVien;
        public fNhanVien()
        {
            InitializeComponent();
            busNhanVien = new BUS.BUSNhanVien();
        }


        private void fNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.NhanVien' table. You can move, or remove it, as needed.
 
            busNhanVien.LayDSNV(gvNV);
            tb_MaNv.Enabled = false;
            this.gvNV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvNV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvNV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvNV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvNV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvNV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

           
           

        }

        private void gvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            tb_MaNv.Text = gvNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_TenNv.Text = gvNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            dt_NsNv.Text = gvNV.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_SdtNv.Text = gvNV.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbGT.Text = gvNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbRole.Text = gvNV.Rows[e.RowIndex].Cells[5].Value.ToString();

          
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();

                nv.Name = tb_TenNv.Text.ToString();
                nv.Phone = tb_SdtNv.Text.ToString();
                nv.Sex = cbGT.SelectedItem.ToString();
                nv.Role = cbRole.SelectedItem.ToString();
                nv.DoB = dt_NsNv.Value;

                busNhanVien.ThemNhanVien(nv);
                busNhanVien.LayDSNV(gvNV);

            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng điền thông tin");
            }
         
        }

        private void btXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tb_MaNv.Text);
                busNhanVien.XoaNhanVien(id);
                busNhanVien.LayDSNV(gvNV);
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng chọn nhân viên");
            }
        }

        private void btSuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();
                nv.ID = int.Parse(tb_MaNv.Text);
                nv.Name = tb_TenNv.Text.ToString();
                nv.Phone = tb_SdtNv.Text.ToString();
                nv.Sex = cbGT.SelectedItem.ToString();
                nv.Role = cbRole.SelectedItem.ToString();
                nv.DoB = dt_NsNv.Value;

                busNhanVien.SuaNhanVien(nv);
                busNhanVien.LayDSNV(gvNV);
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng chọn lại Giới tính và Chức vụ"); ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

