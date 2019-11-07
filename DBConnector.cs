using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Multi_Form_and_Panel
{
    public class DBConnector
    {
        MySqlConnection conn;

        public string connect()
        {
            string connstr = "server=localhost;user=dbcli;database=demojustripedb;port=3306;password=dbcli123";
            conn = new MySqlConnection(connstr);
            try
            {
                conn.Open();
                //Perform Database Operation
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }

            return "Done";
        }

        public MySqlConnection getConn()
        {
            return conn;
        }
    }
}
