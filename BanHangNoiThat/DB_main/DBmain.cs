using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BanHangNoiThat.Properties;

using System.Data;
using System.Data.SqlClient;

namespace BanHangNoiThat.DB_main
{
    public class DBmain
    {
        public static bool success = false;

        public static SqlConnection conn = null;
        public static SqlCommand comm = null;
        SqlDataAdapter da = null;
        public static bool err;


        string ConnStr = Properties.Settings.Default.ConnectionString;

        public DBmain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public bool KiemTraTonTai(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                int k = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (k > 0)
                {
                    f = true;
                }
                else
                {
                    f = false;
                }
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public static void Connect()
        {
            if (Forms.Admin_login.IDname != null || Forms.Admin_login.Passworld != null)
            {
                try
                {
                    conn = new SqlConnection("Server=" + Forms.Admin_login.ServerIP + ";Database=" + Forms.Admin_login.DataOfServer + ";User Id=" + Forms.Admin_login.IDname + ";Password=" + Forms.Admin_login.Passworld + ";");
                    comm = conn.CreateCommand();

                    if (conn.Database != null)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                }
                catch (SqlException)
                {
                    success = false;
                }
            }
            else
            {
                success = false;
            }
        }
    }
}
