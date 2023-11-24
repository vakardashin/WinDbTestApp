using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDbTestApp
{
    public class MySqlDbHelper
    {
      public static string DoDbTest()
        {
            string s = " ";
            string strCnn = "Server=localhost;User ID = root;Password=root;Database=arnion";
            using(var cnn = new MySqlConnection(strCnn))
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
