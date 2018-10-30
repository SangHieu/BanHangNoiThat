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
        public List<BunifuImageButton> listimage = new List<BunifuImageButton>();
        public List<Label> listLable = new List<Label>();
        public UserProduct()
        {
            InitializeComponent();
            Addimage();
            Addlable();
            loadimage();

        }
        public void Addimage()
        {
            listimage.Add(imagesp1);
            listimage.Add(imagesp2);
            listimage.Add(imagesp3);
            listimage.Add(imagesp4);
            listimage.Add(imagesp5);
            listimage.Add(imagesp6);
            listimage.Add(imagesp7);
            listimage.Add(imagesp8);
        }
        public void Addlable()
        {
            listLable.Add(tensp1);
            listLable.Add(tensp2);
            listLable.Add(tensp3);
            listLable.Add(tensp4);
            listLable.Add(tensp5);
            listLable.Add(tensp6);
            listLable.Add(tensp7);
            listLable.Add(tensp8);
        }
        void loadimage()
        {
            for (int index = 0; index < 8; index++)
            {
                //listimage[index].Image = Image.FromFile("C:\\Users\\BUI\\Pictures\\Saved Pictures\\SP01.jpg");
            }

        }
        private void UserProduct_Load(object sender, EventArgs e)
        {
            
        }
    }
}
