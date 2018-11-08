using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangNoiThat_HeQTCSDL
{
    public partial class User_Login : Form
    {
        public User_Login()
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
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //username.ResetText();
            //password.ResetText();
        }

        private void username_Click(object sender, EventArgs e)
        {
            if (username.Text != "")
                username.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //check id, pass
            if (!checkexitform("GiaoDienUser"))
            {
                GiaoDienUser frm = new GiaoDienUser();
                frm.ShowDialog();
            }
            else
            {
                activechirldform("GiaoDienUser");
            }
            this.Close();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (!checkexitform("SignIn"))
            {
                SignIn frm = new SignIn();
                frm.ShowDialog();
            }
            else
            {
                activechirldform("SignIn");
            }
        }

        private void Login_admin_Click(object sender, EventArgs e)
        {
            if (!checkexitform("Admin_Login"))
            {
                Admin_Login frm = new Admin_Login();
                frm.ShowDialog();
            }
            else
            {
                activechirldform("Admin_Login");
            }
        }

        private void password_Click(object sender, EventArgs e)
        {
            if (password.Text != "")
                password.Text = "";
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(sender, e);
            }
            else
            {
                kiemTraKTSo(sender, e);
            }
        }


        void kiemTraKTSo(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 64 && e.KeyChar < 122) || (e.KeyChar >= 48 && e.KeyChar < 58) || (e.KeyChar == 8)) ||
                char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
                char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
                char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng không nhập các kí tự đặc biệt, khoảng trăng");
            }
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            kiemTraKTSo(sender, e);
        }


        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Tài khoản !");
                username.Focus();
            }
        }

        private void showpassword_Click(object sender, EventArgs e)
        {
            password.isPassword = true;
            showpassword.Visible = false;
            unshowpassword.Visible = true;
        }

        private void unshowpassword_Click(object sender, EventArgs e)
        {

            password.isPassword = false;
            unshowpassword.Visible = false;
            showpassword.Visible = true;
        }

        private void btnForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!checkexitform("ForgotPass"))
            {
                ForgotPass frm = new ForgotPass();
                frm.ShowDialog();
            }
            else
            {
                activechirldform("ForgotPass");
            }
        }
    }
}
