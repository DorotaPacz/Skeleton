using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
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
        public void CustomerNamePropertyOK()
        {
            //To create an instance of the class 
            clsCustomer Customer = new clsCustomer();
            string TestData = "John Blogger";
            Customer.CustomerName = TestData;
            Assert.AreEqual(Customer.CustomerName, TestData);

        }
        public void StudnetDisscountPercentageOK()
        {
            //To create an instance of the class 
            clsCustomer Customer = new clsCustomer();
            double TestData = 1.5;
            Customer.StudnetDisscountPercentage = TestData;
            Assert.AreEqual(Customer.StudnetDisscountPercentage, TestData);

        }
        public void CustomerDOBOK()
        {
            //To create an instance of the class 
            clsCustomer Customer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            Customer.CustomerDOB = TestData;
            Assert.AreEqual(Customer.CustomerDOB, TestData);

        }
        public void CustomerIDOK()
        {
            //To create an instance of the class 
            clsCustomer Customer = new clsCustomer();
            Int32 TestData = 1;

            Customer.CustomerID = TestData;
            Assert.AreEqual(Customer.CustomerID, TestData);

        }



    }
}
