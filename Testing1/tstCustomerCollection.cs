using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        //Priavte data member for the lsit
        List<clsCustomer> CustomerList = new List<clsCustomer>();
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
            TestItem.CustomerName = "Jake John";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.StudnetDiscountPercentage = 1.5000;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
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
            TestCustomer.CustomerName = "Jake John";
            TestCustomer.CustomerDOB = DateTime.Now.Date;
            TestCustomer.StudnetDiscountPercentage = 1.5000;
            //Assign theh data to the property 
            AllCustomers.ThisCustomer = TestCustomer;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of te calss we want to craete 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create soem test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //Create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //Set its properties
            TestItem.IsStudent = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jake John";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.StudnetDiscountPercentage = 1.5000;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primarty key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsStudent = true;
            TestItem.CustomerID = 6;
            TestItem.CustomerName = " Some Name";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.StudnetDiscountPercentage = 1.5000;
            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the recored
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the recored
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //craete an instance of the class we wan to use
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsStudent = true;
            TestItem.CustomerName = "A Name";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.StudnetDiscountPercentage = 1.5000;
            //set this Customer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the recored
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data 
            TestItem.IsStudent = false;
            TestItem.CustomerName = "B Name";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.StudnetDiscountPercentage = 0.000;
            //seth teh recored based on the new test data 
            AllCustomers.ThisCustomer = TestItem;
            //update the recored
            AllCustomers.Update();
            //find the recored
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see thisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);


        }


    }
}
