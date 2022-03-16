using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            // test to see that it exists
            Assert.IsNotNull(anOrder);
        }

        [TestMethod]
        public void IsFulfilledPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //create some test data
            Boolean TestData = true;

            //assign data to the property
            anOrder.IsFulfilled = TestData;

            // test to see that the two values are the same
            Assert.AreEqual(anOrder.IsFulfilled, TestData);
        }

        [TestMethod]
        public void DateOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //create some test data
            DateTime TestData = DateTime.Now.Date;

            //assign data to the property
            anOrder.Date = TestData;

            // test to see that the two values are the same
            Assert.AreEqual(anOrder.Date, TestData);
        }

        [TestMethod]
        public void TotalPriceOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //create some test data
            Double TestData = 1.99D;

            //assign data to the property
            anOrder.TotalPrice = TestData;

            // test to see that the two values are the same
            Assert.AreEqual(anOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void IDOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //create some test data
            int TestData = 1;

            //assign data to the property
            anOrder.ID = TestData;

            // test to see that the two values are the same
            Assert.AreEqual(anOrder.ID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //Boolean variable to store the results of the validation
            Boolean Found = false;

            //create some test data to use with the method
            Int32 ID = 1;

            //invoke the method
            Found = anOrder.Find(ID);

            //test to see if the result is true
            Assert.IsTrue(Found);
        }
    }
}
