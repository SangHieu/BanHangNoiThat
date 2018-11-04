using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using BanHangNoiThat.DB_main;

namespace BanHangNoiThat.BS_Main
{
    public class BS_Connect
    {
        DBmain db = null;
        public BS_Connect()
        {
            db = new DBmain();
        }
    }
}
