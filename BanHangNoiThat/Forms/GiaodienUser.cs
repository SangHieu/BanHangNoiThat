﻿using BanHangNoiThat.Forms.UsersControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHangNoiThat.Forms.UsersControl;

namespace BanHangNoiThat.Forms
{
    public partial class GiaodienUser : Form
    {
        public GiaodienUser()
        {
            InitializeComponent();
        }
        public bool slidemenu;
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
                slidemenu = false;
               SideMenu.Visible = false;
               SideMenu.Width = 242;
               bunifuPanel.ShowSync(SideMenu);
               // bunifuLogo.ShowSync(logo);
               
              
                
            }
            else
            {
                slidemenu = true;
                //bunifuLogo.Hide(logo);
                SideMenu.Visible = false;
               SideMenu.Width = 50;
               bunifuPanel.ShowSync(SideMenu);
             // userProduct1.addPanel();

            }
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
            //userSale1.BringToFront();
        }

        private void bunifuContact_Click(object sender, EventArgs e)
        {
            userContact1.BringToFront();
        }

        private void userSale1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {

            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            addCart1.BringToFront();
        }

        private void pnContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addCart1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            useInformation1.BringToFront();
        }

        private void useInformation1_Load(object sender, EventArgs e)
        {

        }
        public static void addUserControl(UserControl frm)
        {
            
            frm.BringToFront();
        }
    }
}
