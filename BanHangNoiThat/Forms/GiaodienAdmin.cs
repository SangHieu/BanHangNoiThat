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
    public partial class GiaodienAdmin : Form
    {
        public GiaodienAdmin()
        {
            InitializeComponent();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            aminQLKH1.BringToFront();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            aminQLSP1.BringToFront();
        }
    }
}
