using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create some test data to pass to the method
        string testDate = DateTime.Now.Date.ToString();
        string testTotalPrice = "1.99";



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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //invoke the method
            Error = anOrder.Valid(testDate, testTotalPrice);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            string TotalPrice = "-0.01"; //this should trigger an error

            //invoke the method
            Error = anOrder.Valid(testDate, TotalPrice);

            //test to see that the result is correct
            // This test should produce an error so the return of Valid
            // cannot be an empty string
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            string TotalPrice = "0.01"; //this should be OK

            //invoke the method
            Error = anOrder.Valid(testDate, TotalPrice);

            //test to see that the result is correct
            // This test should produce an error so the return of Valid
            // cannot be an empty string
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            string TotalPrice = "-100000"; //this should trigger an error

            //invoke the method
            Error = anOrder.Valid(testDate, TotalPrice);

            //test to see that the result is correct
            // This test should produce an error so the return of Valid
            // cannot be an empty string
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinBoundary()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            string TotalPrice = "0.00"; //this should be OK

            //invoke the method
            Error = anOrder.Valid(testDate, TotalPrice);

            //test to see that the result is correct
            // This test should produce an error so the return of Valid
            // cannot be an empty string
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceInvalidDataType()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass the method
            string TotalPrice = "Kappa"; //this should be an invalid dataType

            //invoke the method
            Error = anOrder.Valid(testDate, TotalPrice);

            //test to see that the result is correct
            // This test should produce an error so the return of Valid
            // cannot be an empty string
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //create variable to store the test data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable
            string Date = TestDate.ToString();

            //invoke the method
            Error = anOrder.Valid(Date, testTotalPrice);

            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //create variable to store the test data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);

            //convert the date variable to a string variable
            string Date = TestDate.ToString();

            //invoke the method
            Error = anOrder.Valid(Date, testTotalPrice);

            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //create variable to store the test data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable
            string Date = TestDate.ToString();

            //invoke the method
            Error = anOrder.Valid(Date, testTotalPrice);

            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //create variable to store the test data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(1);

            //convert the date variable to a string variable
            string Date = TestDate.ToString();

            //invoke the method
            Error = anOrder.Valid(Date, testTotalPrice);

            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void DateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            //string variable to store any error message
            String Error = "";

            //create variable to store the test data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);

            //convert the date variable to a string variable
            string Date = TestDate.ToString();

            //invoke the method
            Error = anOrder.Valid(Date, testTotalPrice);

            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        
        [TestMethod]
        public void DateInvalidData()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();

            //string variable to store error msg
            String Error = "";

            //set the Date to non date value
            string Date = "this is not a date";

            //invoke the method
            Error = anOrder.Valid(Date, testTotalPrice);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }
}
