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
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void txtEmailForgot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 64 && e.KeyChar < 122) || (e.KeyChar == 46) || (e.KeyChar >= 48 && e.KeyChar < 58) || (e.KeyChar == 8))
            {
            }
            else
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng không nhập các kí tự đặc biệt, khoảng trăng");
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

        private void txtIDforgot_KeyPress(object sender, KeyPressEventArgs e)
        {
            kiemTraKTSo(sender, e);
        }

        private void txtNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            kiemTraKTSo(sender, e);
        }

        private void txtConfimPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            kiemTraKTSo(sender, e);
        }
    }
}
