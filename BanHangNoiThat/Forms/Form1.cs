using BanHangNoiThat.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangNoiThat
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool checkexitform(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void activechirldform(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //username.ResetText();
            //password.ResetText();
        }

        private void username_Click(object sender, EventArgs e)
        {
            if (username.Text != null)
                username.ResetText();
             
        }


        private void password_Click(object sender, EventArgs e)
        {
            if (password.Text != null)
                password.ResetText();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!checkexitform("GiaodienUser"))
            {
                GiaodienUser frm = new GiaodienUser();
                frm.ShowDialog();
            }
            else
            {
                activechirldform("GiaodienUser");
            }
            this.Close();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (!checkexitform("FormSignIn"))
            {
                FormSignIn frm = new FormSignIn();
                frm.ShowDialog();
            }
            else
            {
                activechirldform("FormSignIn");
            }
        }

        private void Login_admin_Click(object sender, EventArgs e)
        {
            if (!checkexitform("Admin_login"))
            {
                Admin_login frm = new Admin_login();
                frm.ShowDialog();
            }
            else
            {
                activechirldform("Admin_login");
            }
            this.Close();
        }
    }
}
