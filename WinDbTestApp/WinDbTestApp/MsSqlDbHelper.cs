using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinDbTestApp
{
    public class MsSqlDbHelper
    {
        public static string DoDbTest()
        {
            string s = " ";
            string strCnn = "Server=(localdb)\\MSSQLLocalDB;Integrated Security=true";
            using (var cnn = new SqlConnection(strCnn))
            {
                var cmd = cnn.CreateCommand();
                cmd.CommandText = "SELECT 1";
                cnn.Open();
                var rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    s += (string)rdr[0].ToString() + " ";
                }
            } 
            return s;
        }
    }
}
