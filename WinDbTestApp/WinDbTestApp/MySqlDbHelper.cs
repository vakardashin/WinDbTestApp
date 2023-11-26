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
            // строка подключения к БД
            string strCnn = "Server=localhost;User ID = root;Password=root;Database=arnion";
            // создаём объект для подключения к БД
            using (var cnn = new MySqlConnection(strCnn))
            {
                var cmd = cnn.CreateCommand();
                // запрос
                cmd.CommandText = "SELECT id_categories, categories_name FROM goods_categories WHERE id_categories >= 11";
                // устанавливаем соединение с БД
                cnn.Open();
                var rdr = cmd.ExecuteReader();
                // читаем результат
                while (rdr.Read())
                {
                    s += (string)rdr[0].ToString() + " " + rdr[1].ToString();
                }
            }
            return s;
        }
    }
}
