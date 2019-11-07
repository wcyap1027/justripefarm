using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Multi_Form_and_Panel
{
    public class LabourerHandler
    {
        private DataTable dt = new DataTable();
        public int addNewLabourer(MySqlConnection conn, Labourer labourer)
        {
            string sql = "INSERT INTO labourer (name, age,gender,startWork,endWork)" + "VALUES('" + labourer.Name + "', '" + labourer.Age + "','" + labourer.Gender + "','"+labourer.StartDate+"','"+labourer.EndDate+"')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public DataTable BindSource()
        {
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            MySqlDataAdapter sqlData = new MySqlDataAdapter("SELECT * FROM labourer", dBConn.getConn());
            dt.Clear();
            sqlData.Fill(dt);
            dBConn.getConn().Close();

            return dt;
        }

        public List<Labourer> getAllLabourer(MySqlConnection conn)
        {
            List<Labourer> listLabr = new List<Labourer>();
            string sql = "SELECT * FROM labourer WHERE 1 ";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while (myReader.Read())
                {
                    Labourer sLabr = new Labourer();
                    sLabr.Id = (int)myReader.GetValue(0);
                    sLabr.Name = (string)myReader.GetValue(1);
                    sLabr.Age = (int)myReader.GetValue(2);
                    sLabr.Gender = (string)myReader.GetValue(3);
                    sLabr.StartDate = (string)myReader.GetValue(4);
                    sLabr.EndDate = (string)myReader.GetValue(5);
                    listLabr.Add(sLabr);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return listLabr;
        }
    }
}
