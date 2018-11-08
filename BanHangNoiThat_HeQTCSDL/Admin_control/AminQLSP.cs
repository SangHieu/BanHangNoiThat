using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangNoiThat_HeQTCSDL.Forms.Amincontrol
{
    public partial class AminQLSP : UserControl
    {
        public AminQLSP()
        {
            InitializeComponent();
        }

        void kiemTraKTSo(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 65 && e.KeyChar < 122) || (e.KeyChar >= 48 && e.KeyChar < 58) || (e.KeyChar == 8)) ||
        char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
        char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
        char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng không nhập các kí tự đặc biệt, khoảng trăng");
            }
        }


    }
}
