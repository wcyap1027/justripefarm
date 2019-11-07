using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Multi_Form_and_Panel
{
    public class NewJobHandler
    {
        public int addNewJob(MySqlConnection conn, NewJob newJob)
        {
            string sql = "INSERT INTO newjob(type, labourer_id, startWorkDate, endWorkDate)"
                + "VALUES('" + newJob.Type + "', '" + newJob.LabourerId + "', '" + newJob.StartWorkDate.ToString("yyyy-MM-dd HH:mm:ss") + "' , '" + newJob.EndWorkDate.ToString("yyyy-MM-dd HH:mm:ss") + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }
}
