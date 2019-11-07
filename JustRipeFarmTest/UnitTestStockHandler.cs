using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data;
using Multi_Form_and_Panel;

namespace JustRipeFarmTest
{
    [TestClass]
    public class UnitTestStockHandler
    {
        [TestMethod]
        public void TestAddNewStock()
        {
            //connect database
            DBConnector dBc = new DBConnector();
            string resp = dBc.connect();
            Assert.AreEqual("Done", resp);

            //stock attribute
            Stock astock = new Stock();
            astock.Type = 1;
            astock.Quantity = 100;
            astock.SupplierId = 3;
            astock.PurchaseDate = new DateTime(2018, 10, 25, 0, 0, 0);
            astock.ExpiryDate = new DateTime(2019, 1, 24, 0, 0, 0);

            //stock handler to run insert data
            StockHandler labrHand = new StockHandler();
            int resp2 = labrHand.addNewStock(dBc.getConn(), astock);
            Assert.IsNotNull(resp2);
        }
    }
}
