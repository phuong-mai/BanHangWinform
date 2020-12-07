using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG
{
    class ConnectDB
    {
        public static SqlConnection db;
        public static void DbConnection()
        {
            db = new SqlConnection(@"server=.; database=BanHang; integrated security = true;");
            db.Open();
        }
    }
}
