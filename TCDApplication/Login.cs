using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCDApplication.Entity;
using TCDApplication.BL;

namespace TCDApplication
{
    public partial class Login : Form
    {
        TCDEntities1 entity;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_pswd_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text != string.Empty && txt_password.Text != string.Empty)
            {
                entity = new TCDEntities1();
                //Check if user is exist or not !
                var userExit = entity.tbl_Login.FirstOrDefault(a=>a.Username.Equals(txt_username.Text));
                if(userExit != null)
                {
                    if(userExit.Password.Equals(txt_password.Text))
                    {
                        MessageBox.Show("Login Success");
                        MainForm mf = new MainForm();
                        mf.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }
    }
}
