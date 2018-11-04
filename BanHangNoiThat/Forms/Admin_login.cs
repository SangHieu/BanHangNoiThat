using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.NetworkInformation;
using BanHangNoiThat.Properties;

using System.Data.Sql;
using System.Data.SqlClient;

using BanHangNoiThat.BS_Main;
using BanHangNoiThat.DB_main;

namespace BanHangNoiThat.Forms
{
    public partial class Admin_login : Form
    {
        public static string ServerIP = null;
        public static string DataOfServer = null;
        public static string IDname = null;
        public static string Passworld = null;
        public static string TableName = null;

        DataTable dt = null;
        DataSet ds, ds2;
        BS_Connect db = new BS_Connect();
        string err;

        public Admin_login()
        {
            InitializeComponent();

            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPInterfaceProperties ipProps = netInterface.GetIPProperties();
                foreach (UnicastIPAddressInformation addr in ipProps.UnicastAddresses)
                {
                    IPComboBox.Items.Add(addr.Address.ToString());
                }
            }
            PassCheckHint.Checked = false;
        }

        private bool checkexitform(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void activechirldform(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IPComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var server = new Microsoft.SqlServer.Management.Smo.Server(IPComboBox.ValueMember.ToString().Trim());

            foreach (Microsoft.SqlServer.Management.Smo.Database db in server.Databases)
            {
                DataComboBox.Items.Add(db.Name);
            }
        }

        private void DataComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ServerIP = IPComboBox.Text.Trim().ToString();
            DataOfServer = DataComboBox.Text.Trim().ToString();
        }

        private void PassCheckHint_CheckedChanged(object sender, EventArgs e)
        {
            if (PassCheckHint.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IDname = txtID.Text.Trim().ToString();
            Passworld = txtPass.Text.Trim().ToString();
            DBmain.Connect();
            if (DBmain.success)
            {
                string cnstr = "Server = " + Forms.Admin_login.ServerIP + "; Database = " + Forms.Admin_login.DataOfServer + "; User Id = " + Forms.Admin_login.IDname + "; Password = " + Forms.Admin_login.Passworld + ";";
                Settings.Default.ConnectionString = cnstr;
                Properties.Settings.Default.Save();

                MessageBox.Show("Succesfull!");

                if (!checkexitform("GiaodienAdmin"))
                {
                    GiaodienAdmin frm = new GiaodienAdmin();
                    frm.ShowDialog();
                }
                else
                {
                    activechirldform("GiaodienAdmin");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Connected Faile!");
            }
        }


    }
}
