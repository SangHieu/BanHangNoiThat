using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BanHangNoiThat_HeQTCSDL.Forms.UsersControl
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


        private void AddCart_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            Txtname.Enabled = false;
            txtDiachi.Enabled = false;
            txtSdt.Enabled = false;
            txtemal.Enabled = false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Txtname.Enabled = true;
            txtDiachi.Enabled = true;
            txtSdt.Enabled = true;
            txtemal.Enabled = true;
        }
        private void dathang_Click(object sender, EventArgs e)
        {
            UserControl us = new UserHome();
            GiaoDienUser.addUserControl(us);
        }

        private void listViewsp_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
