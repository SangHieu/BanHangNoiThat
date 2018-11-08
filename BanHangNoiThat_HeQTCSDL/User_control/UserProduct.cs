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

namespace BanHangNoiThat_HeQTCSDL.Forms.UsersControl
{
    public partial class UserProduct : UserControl
    {
        List<string> MaSP = new List<string>();
        public UserProduct()
        {
            InitializeComponent();

        }
       
        private void UserProduct_Load(object sender, EventArgs e)
        {
            string ten = "SP";
           
            listViewSanpham.LargeImageList = imageSanPham;
            for (int index = 0; index < 10; index++)
            {
                ListViewItem sp = new ListViewItem("San pham "+index, 0);
                MaSP.Add(ten+index.ToString());
                listViewSanpham.Items.Add(sp);
            }
            Detailproduct frm = new Detailproduct();
            int i = listViewSanpham.Items.Count;
           
        }
        private void listViewSanpham_ItemActivate(object sender, EventArgs e)
        {

            ListView senders = (ListView)sender;
            string ma = MaSP[senders.SelectedIndices[0]];
            Detailproduct frm = new Detailproduct(ma);
            frm.ShowDialog();

         }
    }
}
