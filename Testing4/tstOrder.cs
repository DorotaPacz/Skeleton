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

        [TestMethod]
        public void TestIDFound()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 ID = 1;

            //invoke the method
            Found = anOrder.Find(ID);
            
            //check the ID
            if (anOrder.ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK
            Boolean OK = true;

            //create some test data
            Int32 ID = 1;

            //invoke test method
            Found = anOrder.Find(ID);

            //check the property
            if(anOrder.Date != Convert.ToDateTime("16/03/2022"))
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsFulfilledFound()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK
            Boolean OK = true;

            //create some test data
            Int32 ID = 1;

            //invoke test method
            Found = anOrder.Find(ID);

            //check the property
            //I hardcoded isfulfilled to false so if it is false it should pass
            if (anOrder.IsFulfilled != false)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK
            Boolean OK = true;

            //create some test data
            Int32 ID = 1;

            //invoke test method
            Found = anOrder.Find(ID);

            //check the property
            if (anOrder.TotalPrice != 1.99)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
