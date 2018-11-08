using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHangNoiThat.Forms;

namespace BanHangNoiThat.Forms.UsersControl
{
    public partial class UseInformation : UserControl
    {
        public UseInformation()
        {
            InitializeComponent();
        }

        private void UseInformation_Load(object sender, EventArgs e)
        {
            readInf();
        }
        void readInf()
        {
            Txtname.Enabled = false;
            txtDiachi.Enabled = false;
            txtemal.Enabled = false;
            txtSdt.Enabled = false;
           // BtnLuuInf.Enabled = false;
            radioNam.Enabled = false;
            radioNu.Enabled = false;
            updateImage.Visible = false;
        }

        private void BtnLuuInf_Click(object sender, EventArgs e)
        {
            readInf();
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc lưu thay đổi không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK)
            {
                MessageBox.Show("Lưu thành công!");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Txtname.Enabled = true;
            txtDiachi.Enabled = true;
            txtemal.Enabled = true;
            txtSdt.Enabled = true;
            BtnLuuInf.Enabled = true;
            radioNam.Enabled = true;
            radioNu.Enabled = true;
            updateImage.Visible = true;
            Txtname.Focus();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            UserHome us = new UserHome();
            GiaodienUser.addUserControl(us);
        }
    }
}
