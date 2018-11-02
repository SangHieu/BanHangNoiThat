using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangNoiThat.Forms.UsersControl
{
    public partial class AddCart : UserControl
    {
        public AddCart()
        {
            InitializeComponent();
        }

        private void Motasp_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listviewsp.LargeImageList = imageList1;
            ListViewItem iteam = new ListViewItem("Tên sản phẩm",0);
            ListViewItem.ListViewSubItem subiteam = new ListViewItem.ListViewSubItem(iteam, "Cái lìn gì thế");
            iteam.SubItems.Add(subiteam);
            listviewsp.Items.Add(iteam);
        }
    }
}
