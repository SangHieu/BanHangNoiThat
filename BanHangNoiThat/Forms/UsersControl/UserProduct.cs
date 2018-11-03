using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace BanHangNoiThat.Forms.UsersControl
{
    public partial class UserProduct : UserControl
    {
        public UserProduct()
        {
            InitializeComponent();

        }
       
        private void UserProduct_Load(object sender, EventArgs e)
        {
           
            listViewSanpham.LargeImageList = imageSanPham;
            for (int index = 0; index < 10; index++)
            {
                ListViewItem sp = new ListViewItem("San pham "+index, 0);
                listViewSanpham.Items.Add(sp);
            }
            
        }
    }
}
