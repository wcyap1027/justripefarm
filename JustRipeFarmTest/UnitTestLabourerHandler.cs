using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using Multi_Form_and_Panel;

namespace JustRipeFarmTest
{
    [TestClass]
    public class UnitTestLabourerHandler
    {
        [TestMethod]
        public void TestAddNewLabourer()
        {
            DBConnector dBc = new DBConnector();
            string resp = dBc.connect();
            Assert.AreEqual("Done", resp);

            Labourer labrA = new Labourer();
            labrA.Name = "Bob";
            labrA.Age = 39;
            labrA.Gender = "male";

            LabourerHandler labrHand = new LabourerHandler();
            int resp2 = labrHand.addNewLabourer(dBc.getConn(), labrA);
            Assert.IsNotNull(resp2);
        }
    }
}
