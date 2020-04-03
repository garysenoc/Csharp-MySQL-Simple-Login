using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Simple_Login_MySQL
{
    class clsMySQL
    {
        public static string server = "127.0.0.1";
        public static string database = "logindb";
        public static string user = "root";
        public static string pass = "";
        public static string constring = "server = " + server + ";" + "database = " + database + ";" + "uid = " + user + ";" + "password = " + pass + ";";
        public static MySqlConnection sql_con = new MySqlConnection(constring);
    }
}
