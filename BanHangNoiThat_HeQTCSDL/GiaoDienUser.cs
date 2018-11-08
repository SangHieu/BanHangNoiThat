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

    public partial class GiaoDienUser : Form
    {
        public static string User_Login_ID = null;
        public static bool IsLogin = false;

        public GiaoDienUser()
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

        private void bunifuMenu_Click(object sender, EventArgs e)
        {
            if (SideMenu.Width == 50)
            {
                slidemenu = false;
                SideMenu.Visible = false;
                SideMenu.Width = 242;
                bunifuPanel.ShowSync(SideMenu);

            }
            else
            {
                slidemenu = true;
                SideMenu.Visible = false;
                SideMenu.Width = 50;
                bunifuPanel.ShowSync(SideMenu);
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

        private void bunifuContact_Click(object sender, EventArgs e)
        {
            userContact1.BringToFront();
        }

        private void bunifuAddCart_Click(object sender, EventArgs e)
        {
            addCart1.BringToFront();
        }

        private void bunifuUserInf_Click(object sender, EventArgs e)
        {
            useInformation1.BringToFront();
        }

        public static void addUserControl(UserControl frm)
        {
            frm.BringToFront();
        }

        private void bntDangXuat_Click(object sender, EventArgs e)
        {
            if(IsLogin == false)
            {
                if (!checkexitform("User_Login"))
                {
                    User_Login frm = new User_Login();
                    frm.ShowDialog();
                }
                else
                {
                    activechirldform("User_Login");
                }
                btnDangXuat.Text = "Đăng xuất";
                this.Visible=true;
            }
            else
            {
                User_Login_ID = null;
                IsLogin = false;
                btnDangXuat.Text = "Đăng nhập";
            }
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
    }
}
