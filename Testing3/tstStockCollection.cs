using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();

            TestItem.Available = true;
            TestItem.StockItemDescription = "guitar";
            TestItem.StockItemNo = 1;
            TestItem.Price = 1;
            TestItem.QuantityInStock = 1;
            TestItem.DateAdded = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.StockList, TestList);      
        }

       

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();

            TestStock.Available = true;
            TestStock.StockItemDescription = "guitar";
            TestStock.StockItemNo = 1;
            TestStock.Price = 1;
            TestStock.QuantityInStock = 1;
            TestStock.DateAdded = DateTime.Now.Date;

            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();

            TestItem.Available = true;
            TestItem.StockItemDescription = "guitar";
            TestItem.StockItemNo = 1;
            TestItem.Price = 1;
            TestItem.QuantityInStock = 1;
            TestItem.DateAdded = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

       
    }
}
