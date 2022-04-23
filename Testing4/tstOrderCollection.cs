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
        public void CountPropertyOK()
        {
            clsOrderCollection aCollection = new clsOrderCollection();
            Int32 SomeCount = 0;
            aCollection.Count = SomeCount;
            Assert.AreEqual(aCollection.Count, SomeCount);
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

    }
}
