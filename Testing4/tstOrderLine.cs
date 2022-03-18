using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsOrderLine anOrderLine = new clsOrderLine();
            // test to see that it exists
            Assert.IsNotNull(anOrderLine);
        }

        [TestMethod]
        public void StockItemNoOK()
        {
            //create an instance of the class we want to create
            clsOrderLine anOrderLine = new clsOrderLine();

            //create some test data
            int TestData = 1;

            //assign data to the property
            anOrderLine.StockItemNo = TestData;

            // test to see that the two values are the same
            Assert.AreEqual(anOrderLine.StockItemNo, TestData);
        }

        [TestMethod]
        public void OrderIDOK()
        {
            //create an instance of the class we want to create
            clsOrderLine anOrderLine = new clsOrderLine();

            //create some test data
            int TestData = 1;

            //assign data to the property
            anOrderLine.OrderID = TestData;

            // test to see that the two values are the same
            Assert.AreEqual(anOrderLine.OrderID, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            //create an instance of the class we want to create
            clsOrderLine anOrderLine = new clsOrderLine();

            //create some test data
            int TestData = 1;

            //assign data to the property
            anOrderLine.Quantity = TestData;

            // test to see that the two values are the same
            Assert.AreEqual(anOrderLine.Quantity, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLine anOrderLine = new clsOrderLine();

            //Boolean variable to store the results of the find
            Boolean Found = false;

            //create some test data to use with the method
            Int32 StockItemNo = 1;

            //invoke the method
            Found = anOrderLine.Find(StockItemNo);

            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockItemNoFound()
        {
            //create an instance of the class
            clsOrderLine anOrderLine = new clsOrderLine();

            //boolean variable to store the reuslt of the search
            Boolean Found = false;

            //boolean variable to record if data is OK
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StockItemNo = 1;

            //invoke the method
            Found = anOrderLine.Find(StockItemNo);

            //check the address no
            if (anOrderLine.StockItemNo != 1)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class
            clsOrderLine anOrderLine = new clsOrderLine();

            //boolean variable to store the reuslt of the search
            Boolean Found = false;

            //boolean variable to record if data is OK
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StockItemNo = 1;

            //invoke the method
            Found = anOrderLine.Find(StockItemNo);

            //check the address no
            if (anOrderLine.OrderID != 1)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class
            clsOrderLine anOrderLine = new clsOrderLine();

            //boolean variable to store the reuslt of the search
            Boolean Found = false;

            //boolean variable to record if data is OK
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StockItemNo = 1;

            //invoke the method
            Found = anOrderLine.Find(StockItemNo);

            //check the address no
            if (anOrderLine.Quantity != 1)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
