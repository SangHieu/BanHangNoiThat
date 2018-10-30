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
            GiaodienUser Frgd = new GiaodienUser();
            Frgd.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FormSignIn fr = new FormSignIn();
            fr.Show();
            this.Hide();
        }
    }
}
