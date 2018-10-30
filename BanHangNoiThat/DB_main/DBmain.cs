using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DBmain()
        {

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
        public static void Connect()
        {
            /*if (Form1.IDname != null || Form1.Passworld != null)
            {
                try
                {
                    conn = new SqlConnection("Server=" + Form1.ServerIP + ";Database=" + Form1.DataOfServer + ";User Id=" + Form1.IDname + ";Password=" + Form1.Passworld + ";");
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
            }*/
        }
    }
}
