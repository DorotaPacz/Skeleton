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
    }
}
