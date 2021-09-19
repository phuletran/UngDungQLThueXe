using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace DemoQLKS
{
    public partial class fLogin : Form
    {
        
        public fLogin()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BUS.BUSLogin busLogin = new BUS.BUSLogin();

                int idINT = int.Parse(tbx_id.Text);
                string pass = tbx_pass.Text;

                if (busLogin.checkLogin(idINT, pass) == false)
                    MessageBox.Show("Sai ID hoặc mật khẩu! Vui lòng xem lại!");
                else
                {
                    fGiaodienChinh gd = new fGiaodienChinh(tbx_id.Text);
                    gd.ShowDialog();
                    tbx_id.Clear();
                    tbx_pass.Clear();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng nhập thông tin"); ;
            }
         }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbx_id_Enter(object sender, EventArgs e)
        {
            tbx_id.Clear();
        }

        private void tbx_pass_Enter(object sender, EventArgs e)
        {
            tbx_pass.Clear();
            tbx_pass.PasswordChar = '*';
        }

      
     } 
    }
