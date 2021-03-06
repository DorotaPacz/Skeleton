using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection aCollection = new clsOrderCollection();

            Assert.IsNotNull(aCollection);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection aCollection = new clsOrderCollection();

            List<clsOrder> testList = new List<clsOrder>();

            clsOrder anOrder = new clsOrder();
            anOrder.ID = 15;
            anOrder.Date = DateTime.Now.Date;
            anOrder.IsFulfilled = false;
            anOrder.TotalPrice = 19.99f;

            testList.Add(anOrder);
            aCollection.OrderList = testList;

            Assert.AreEqual(aCollection.OrderList, testList);
        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection aCollection = new clsOrderCollection();

            clsOrder anOrder = new clsOrder();
            anOrder.ID = 15;
            anOrder.Date = DateTime.Now.Date;
            anOrder.IsFulfilled = false;
            anOrder.TotalPrice = 19.99f;

            aCollection.ThisOrder = anOrder;
            Assert.AreEqual(aCollection.ThisOrder, anOrder);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection aCollection = new clsOrderCollection();
            List<clsOrder> testList = new List<clsOrder>();
            clsOrder anOrder = new clsOrder();
            anOrder.ID = 15;
            anOrder.Date = DateTime.Now.Date;
            anOrder.IsFulfilled = false;
            anOrder.TotalPrice = 19.99f;
            testList.Add(anOrder);
            aCollection.OrderList = testList;

            Assert.AreEqual(aCollection.Count, testList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection aCollection = new clsOrderCollection();

            //create the item of test data
            clsOrder anOrder = new clsOrder();

            //var to store the primary key
            Int32 PrimaryKey = 123;

            //set its properties
            anOrder.ID = 125;
            anOrder.Date = DateTime.Now.Date;
            anOrder.IsFulfilled = false;
            anOrder.TotalPrice = 19.99f;

            aCollection.ThisOrder = anOrder;

            //add the record
            PrimaryKey = aCollection.Add();

            //set the primary key of the test data
            anOrder.ID = PrimaryKey;

            //find the record
            aCollection.ThisOrder.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(aCollection.ThisOrder, anOrder);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection aCollection = new clsOrderCollection();

            //create the item of test data
            clsOrder anOrder = new clsOrder();

            //var to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            anOrder.Date = DateTime.Now.Date;
            anOrder.IsFulfilled = false;
            anOrder.TotalPrice = 19.99f;

            aCollection.ThisOrder = anOrder;

            //add the record
            PrimaryKey = aCollection.Add();

            //set the primary key of the test data
            anOrder.ID = PrimaryKey;

            //modify the test data
            anOrder.Date = DateTime.Now.Date;
            anOrder.IsFulfilled = true;
            anOrder.TotalPrice = 119.99f;

            aCollection.ThisOrder = anOrder;
            aCollection.Update();

            aCollection.ThisOrder.Find(PrimaryKey);

            //test
            Assert.AreEqual(aCollection.ThisOrder, anOrder);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection aCollection = new clsOrderCollection();

            //create the item of test data
            clsOrder anOrder = new clsOrder();

            //var to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties

            anOrder.Date = DateTime.Now.Date;
            anOrder.IsFulfilled = false;
            anOrder.TotalPrice = 19.99f;

            aCollection.ThisOrder = anOrder;

            //add the record
            PrimaryKey = aCollection.Add();

            //set the primary key of the test data
            anOrder.ID = PrimaryKey;

            //find the record
            aCollection.ThisOrder.Find(PrimaryKey);

            //delete the record
            aCollection.Delete();
            Boolean Found = aCollection.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByDateMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection aCollection = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredCollection = new clsOrderCollection();
            //apply a blank string (should return all records);
            FilteredCollection.ReportByDate("");
            Assert.AreEqual(aCollection.Count, FilteredCollection.Count);

        }

        [TestMethod]
        public void ReportByDateNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredCollection = new clsOrderCollection();

            FilteredCollection.ReportByDate("23/11/2030");
            Assert.AreEqual(0, FilteredCollection.Count);
        }

        [TestMethod]
        public void ReportByDateTestDataFound()
        {
            clsOrderCollection aCollection = new clsOrderCollection();
            Boolean OK = true;
            aCollection.ReportByDate("24/04/2022");

            if(aCollection.OrderList[0].ID != 13)
            {
                OK = false;
            }

            if(aCollection.OrderList[1].ID != 14)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

    }
}
