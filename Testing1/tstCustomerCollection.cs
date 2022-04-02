using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of teh class we want to craete
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //Create an instance of the class we wnat to craete 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create some test data to assign to the property
            //in this case the data should be a lsit of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list 
            //Create the item of the data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.IsStudent = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Human Name";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.StudnetDiscountPercentage = 0.5;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Craete some test data to assign to the property
            Int32 SomeCount = 0;
            //Assign the data to the property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //Craete an instanceof a class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create some test data to assign to teh property 
            clsCustomer TestCustomer = new clsCustomer();
            //Set the properties of the test object
            TestCustomer.IsStudent = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerName = "Human Name";
            TestCustomer.CustomerDOB = DateTime.Now.Date;
            TestCustomer.StudnetDiscountPercentage = 0.5;
            //Assign theh data to the property 
            AllCustomers.ThisCustomer = TestCustomer;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
    }
}
