using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string CustomerName = "Fred Blogger";
        string CustomerDOB = DateTime.Now.Date.ToString();
        string StudnetDiscountPercentage = "1.5";
        [TestMethod]
        public void InstancOK()
        {
            //To create an instance of the class 
            clsCustomer Customer = new clsCustomer();
            //Test to see that it exists
            Assert.IsNotNull(Customer);

        }
        [TestMethod]
        public void IsStudentPropertyOK()
        {
            //To create an instance of the class 
            clsCustomer Customer = new clsCustomer();

            Boolean TestData = true;

            Customer.IsStudent = TestData;
            Assert.AreEqual(Customer.IsStudent, TestData);

        }
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //To create an instance of the class 
            clsCustomer Customer = new clsCustomer();
            string TestData = "John Blogger";
            Customer.CustomerName = TestData;
            Assert.AreEqual(Customer.CustomerName, TestData);

        }
        [TestMethod]
        public void StudnetDiscountPercentageOK()
        {
            //To create an instance of the class 
            clsCustomer Customer = new clsCustomer();
            double TestData = 1.5;
            Customer.StudentDiscountPercentage = TestData;
            Assert.AreEqual(Customer.StudentDiscountPercentage, TestData);

        }
        [TestMethod]
        public void CustomerDOBOK()
        {
            //To create an instance of the class 
            clsCustomer Customer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            Customer.CustomerDOB = TestData;
            Assert.AreEqual(Customer.CustomerDOB, TestData);

        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //To create an instance of the class 
            clsCustomer Customer = new clsCustomer();
            Int32 TestData = 1;

            Customer.CustomerID = TestData;
            Assert.AreEqual(Customer.CustomerID, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;

            Int32 CustomerID = 5;

            Found = Customer.Find(CustomerID);

            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer Customer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 5;

            Found = Customer.Find(CustomerID);

            if (Customer.CustomerID != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomer Customer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 5;

            Found = Customer.Find(CustomerID);

            if (Customer.CustomerName != "Laura Shaw")
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void TestStudentDiscountPercentageFound()
        {
            clsCustomer Customer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 5;

            Found = Customer.Find(CustomerID);

            if (Customer.StudentDiscountPercentage != Convert.ToDouble("1.5"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void TestCustomerDOBFound()
        {
            clsCustomer Customer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 5;

            Found = Customer.Find(CustomerID);

            if (Customer.CustomerDOB != Convert.ToDateTime("05/03/1998"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void TestIsStudentFound()
        {
            clsCustomer Customer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 5;

            Found = Customer.Find(CustomerID);

            if (Customer.IsStudent != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error massage
            String Error = "";
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //************************************CustomerNameValidation********************************************
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //craete an insatnce of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = ""; //this should trigger an error
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustomerNameMin()
        {
            //create an iinstance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //STRING VARIABLE TO STORE ANY ERROR MESSAGE 
            String Error = "";
            //create som tet data to pass to th method
            string CustomerName = "a";
            //invoke the method 
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //test to se that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //sting variable to store any error message
            String Error = "";
            //craete some test data to pass to the method
            string CustomerName = "aa";
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaa";
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {

            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a');
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //************************************CustomerDOBValidation***********************************************
        //[TestMethod]
        //public void CustomerDOBExtremeMin()
        //{
        //    //create an instance of the class we want tpo create
        //    clsCustomer Customer = new clsCustomer();
        //    //string valiable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date to today date
        //    TestDate = DateTime.Now.Date;
        //    //change the date to whatever the date is less than 100 years
        //    TestDate = TestDate.AddYears(-100);
        //    //convert the dat evariable to a string variable
        //    string CustomerDOB = TestDate.ToString();
        //    //invoke the method
        //    Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
        //    //Test to see the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}
        //[TestMethod]
        //public void CustomerDOBMinLessOne()
        //{
        //    //create an instance of the class we want tpo create
        //    clsCustomer Customer = new clsCustomer();
        //    //string valiable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date to today date
        //    TestDate = DateTime.Now.Date;
        //    //change the date to whatever the date is less than 1 years
        //    TestDate = TestDate.AddDays(-1);
        //    //convert the dat evariable to a string variable
        //    string CustomerDOB = TestDate.ToString();
        //    //invoke the method
        //    Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
        //    //Test to see the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}
        [TestMethod]
        public void CustomerDOBMin()
        {
            //create an instance of the class we want tpo create
            clsCustomer Customer = new clsCustomer();
            //string valiable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //convert the dat evariable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //Test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        //[TestMethod]
        //public void CustomerDOBMinPlusOne()
        //{
        //    //create an instance of the class we want tpo create
        //    clsCustomer Customer = new clsCustomer();
        //    //string valiable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date to today date
        //    TestDate = DateTime.Now.Date;
        //    //Change the date to whatever the date is plus 1 day
        //    TestDate = TestDate.AddDays(1);
        //    //change the date to whatever the date is less than 100 years
        //    TestDate = TestDate.AddYears(-100);
        //    //convert the dat evariable to a string variable
        //    string CustomerDOB = TestDate.ToString();
        //    //invoke the method
        //    Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
        //    //Test to see the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}
        [TestMethod]
        public void CustomerDOBExtremeMax()
        {
            //create an instance of the class we want tpo create
            clsCustomer Customer = new clsCustomer();
            //string valiable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the dat evariable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //Test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //String var to store the error message
            String Error = "";
            //set the CustomerDOB to a non date value
            string CustomerDOB = "This is not a date!";
            //Invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //************************************StudentDiscountPercentageValidation*****************************************************************
        [TestMethod]
        public void StudnetDiscountPercentageMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //String var to store any error message
            String Error = "";
            //create some test data to pass the method
            string StudnetDiscountPercentage = "-0.01";//should tigger an error
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //Test to see that the result is right
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StudnetDiscountPercentageMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //String var to store any error message
            String Error = "";
            //create some test data to pass the method
            string StudnetDiscountPercentage = "0.00";
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //Test to see that the result is right
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StudnetDiscountPercentageExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //String var to store any error message
            String Error = "";
            //create some test data to pass the method
            string StudnetDiscountPercentage = "-10000";
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //Test to see that the result is right
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StudnetDiscountPercentagePlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //String var to store any error message
            String Error = "";
            //create some test data to pass the method
            string StudnetDiscountPercentage = "0.01";
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //Test to see that the result is right
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StudnetDiscountPercentageLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //String var to store any error message
            String Error = "";
            //create some test data to pass the method
            string StudnetDiscountPercentage = " -0.01";
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //Test to see that the result is right
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StudnetDiscountPercentageInvalidData()
        {


            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //String var to store any error message
            String Error = "";
            //create some test data to pass the method
            string StudnetDiscountPercentage = "This is not valid Studnet Discount Percentage value! ";
            //invoke the method
            Error = Customer.Valid(CustomerName, CustomerDOB, StudnetDiscountPercentage);
            //Test to see that the result is right
            Assert.AreNotEqual(Error, "");

        }

    }
}
