using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data;
using Multi_Form_and_Panel;

namespace JustRipeFarmTest
{
    [TestClass]
    public class UnitTestNewJobHandler
    {
        [TestMethod]
        public void TestAddNewJob()
        {
            //connect database
            DBConnector dbC = new DBConnector();
            string resp = dbC.connect();
            Assert.AreNotEqual("Done0", resp);
            //newJob attribute
            NewJob newJob = new NewJob();
            Assert.IsInstanceOfType(newJob, typeof(object));
            newJob.Type = 1;
            newJob.LabourerId = 2;
            newJob.StartWorkDate = new DateTime(2018, 10, 25, 0, 0, 0);
            newJob.EndWorkDate = new DateTime(2019, 1, 24, 0, 0, 0);

            NewJobHandler newJobHand = new NewJobHandler();
            int resp2 = newJobHand.addNewJob(dbC.getConn(), newJob);
            Assert.IsNotNull(resp2);
            
        }
    }
}
