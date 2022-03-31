﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace StaffCollection
{

    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        
        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data (list of objects) to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //properties set with good data

            TestItem.IsAdmin = true;
            TestItem.IdNoOK = 1;
            TestItem.StaffName = "Dorota Paczkowska";
            TestItem.DateBegin = DateTime.Now.Date;
            TestItem.Salary = 12345.67;

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }


        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the text object
            TestStaff.IsAdmin = false;
            TestStaff.IdNoOK = 12;
            TestStaff.StaffName = "Sabrina Fox";
            TestStaff.DateBegin = DateTime.Now.Date;
            TestStaff.Salary = 12345.67;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data (list of objects) to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create an item of test data
            clsStaff TestItem = new clsStaff();
            //set the properties of the text object
            TestItem.IsAdmin = false;
            TestItem.IdNoOK = 1;
            TestItem.StaffName = "Sabrina Fox";
            TestItem.DateBegin = DateTime.Now.Date;
            TestItem.Salary = 12345.67;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsAdmin = true;
            TestItem.IdNoOK = 1;
            TestItem.StaffName = "Dorota Paczkowska";
            TestItem.DateBegin = DateTime.Now.Date;
            TestItem.Salary = 12345.67;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key to test data
            TestItem.IdNoOK = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsAdmin = true;
            TestItem.IdNoOK = 1;
            TestItem.StaffName = "Dorota Paczkowska";
            TestItem.DateBegin = DateTime.Now.Date;
            TestItem.Salary = 12345.67;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key to test data
            TestItem.IdNoOK = PrimaryKey;
            //modify the test data
            TestItem.IsAdmin = false;
            TestItem.IdNoOK = 5;
            TestItem.StaffName = "Amy Winter";
            TestItem.DateBegin = DateTime.Now.Date;
            TestItem.Salary = 21345.67;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
    }
}
