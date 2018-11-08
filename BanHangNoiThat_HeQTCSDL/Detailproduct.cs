using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangNoiThat_HeQTCSDL.Forms
{
    public partial class Detailproduct : Form
    {
        private string TenSP;
        public Detailproduct()
        {
            InitializeComponent();
        }
        public Detailproduct(string tensp)
        {
            this.TenSP = tensp;
            InitializeComponent();
            TXTtensp.Text = TenSP;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
