using BanHangNoiThat.Forms.UsersControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangNoiThat.Forms
{
    public partial class GiaodienUser : Form
    {
        public GiaodienUser()
        {
            InitializeComponent();
        }

        private void GiaodienUser_Load(object sender, EventArgs e)
        {
            userHome1.BringToFront();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(SideMenu.Width==50)
            {
                SideMenu.Visible = false;
               SideMenu.Width = 214;
                bunifuPanel.ShowSync(SideMenu);
               // bunifuLogo.ShowSync(logo);
                
            }
            else
            {
                //bunifuLogo.Hide(logo);
                SideMenu.Visible = false;
               SideMenu.Width = 50;
              bunifuPanel.ShowSync(SideMenu);
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuHome_Click(object sender, EventArgs e)
        {
            userHome1.BringToFront();
        }

     

        private void bunifuProduct_Click(object sender, EventArgs e)
        {
            userProduct1.BringToFront();
        }

      

        private void bunifuSale_Click(object sender, EventArgs e)
        {
            userSale1.BringToFront();
        }

        private void bunifuContact_Click(object sender, EventArgs e)
        {
            userContact1.BringToFront();
        }

        private void userSale1_Load(object sender, EventArgs e)
        {

        }
    }
}
