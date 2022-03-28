using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
	[TestClass]
	public class tstStock
	{
		[TestMethod]
		public void InstanceOK()
		{
			//create and instance of the class we want to create
			clsStock AStock = new clsStock();
			//test to see that it exists
			Assert.IsNotNull(AStock);
		}

		[TestMethod]
		public void StockAvailableOK()
        {
			//create an instance of the class
			clsStock AStock = new clsStock();
			//create test data
			Boolean TestData = true;
			//assign the data
			AStock.Available = TestData;
			//test to see if the two values are the same
            Assert.AreEqual(AStock.Available, TestData);
		}

		[TestMethod]
        public void StockDateAddedOK()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//create test data 
			DateTime TestData = DateTime.Now.Date;
			//assign the data
			AStock.DateAdded = TestData;
			//test to see that the two values are the same
			Assert.AreEqual(AStock.DateAdded, TestData);
		}

		[TestMethod]
		public void StockItemNumberOK()
        {
			//create an instance of the class
			clsStock AStock = new clsStock();
			//create test data
			Int32 TestData = 1;
			//assign the data
			AStock.StockItemNo = TestData;
			//test to see that two values are the same
			Assert.AreEqual(AStock.StockItemNo, TestData);
        }

		[TestMethod]
		public void StockItemDescriptionOK()
		{
			//create an instance of the class
			clsStock AStock = new clsStock();
			//create test data
			string TestData = "21b";
			//assign the data
			AStock.StockItemDescription = TestData;
			//test to see that two values are the same
			Assert.AreEqual(AStock.StockItemDescription, TestData);
		}

		[TestMethod]
		public void StockPriceOK() 
		{
			//create an instance of the class
			clsStock AStock = new clsStock();
			//create test data
			double TestData = 299.99;
			//assign the data
			AStock.Price = TestData;
			//test to see that two values are the same
			Assert.AreEqual(AStock.Price, TestData);
		}

		[TestMethod]
		public void StockQuantityOK()
		{
			//create an instance of the class
			clsStock AStock = new clsStock();
			//create test data
			Int32 TestData = 2;
			//assign the data
			AStock.QuantityInStock = TestData;
			//Test to see that two values are the same
			Assert.AreEqual(AStock.QuantityInStock, TestData);
		}
		
		[TestMethod]
		public void FindMethodOK() 
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//Boolean variable to store the result of the validation
			Boolean Found = false;
			//create some test data to use with the method
			Int32 StockItemNo = 1;
			//invoke the method
			Found = AStock.Find(StockItemNo);
			//test to see if the result is true
			Assert.IsTrue(Found);
		}

		[TestMethod]
		public void TestStockItemNoFound()
        {
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//boolean variable to store the result of the search
			Boolean Found = false;
			//boolean value to record if data is OK
			Boolean OK = true;
			//create some test data to use with the method
			Int32 StockItemNo = 1;
			//invoke the method
			Found = AStock.Find(StockItemNo);
			//check the stock item no
			if(AStock.StockItemNo != 1)
            {
				OK = false;
            }
			//test to see that the result is correct
			Assert.IsTrue(OK);
        }

		[TestMethod]
		public void TestDateAddedFound() 
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//boolean variable to store the result of the search
			Boolean Found = false;
			//boolean variable to record if data is OK
			Boolean OK = true;
			//create some test data to use with the method
			Int32 StockItemNo = 1;
			//invoke the method
			Found = AStock.Find(StockItemNo);
			//check the property
			if (AStock.DateAdded != Convert.ToDateTime("06/03/2022")) 
			{
				OK = false;
			}
			//test to see that the result is correct
			Assert.IsTrue(OK);
		}

		[TestMethod]
		public void TestAvailableFound()
		{
			//create ne instance of the class
			clsStock AStock = new clsStock();
			//boolean variable to store the result of the search
			Boolean Found = false;
			//boolean variable to record if data is OK
			Boolean OK = true;
			//create some test data to use with the method
			Int32 StockItemNo = 1;
			//invoke the method
			Found = AStock.Find(StockItemNo);
			//check the property
			if (AStock.Available != true) 
			{
				OK = false;
			}
			//test to see that the result is correct
			Assert.IsTrue(OK);
		}

		[TestMethod]
		public void TestStockItemDescriptionFound()
        {
			//create an instance of the class
			clsStock AStock = new clsStock();
			//boolean variable to store the result of the search
			Boolean Found = false;
			//boolean variable to record if data is OK
			Boolean OK = true;
			//create some test data to use with the method
			Int32 StockItemNo = 1;
			//invoke the method
			Found = AStock.Find(StockItemNo);
			//check the property
			if(AStock.StockItemDescription != "Electric Guitar") 
			{
				OK = false;
			}
			//test to see that the result is correct
			Assert.IsTrue(OK);
        }

		[TestMethod]
		public void TestPrice()
        {
			//create an instance of the class
			clsStock AStock = new clsStock();
			//boolean variable to store the result of the search
			Boolean Found = false;
			//boolean variable to record if data is OK
			Boolean OK = true;
			//create some test data to use with the method
			Int32 StockItemNo = 1;
			//invoke the method
			Found = AStock.Find(StockItemNo);
			//check the property
			if(AStock.Price != 500)
            {
				OK = false;
            }
			//test to see that the result is correct
			Assert.IsTrue(OK);
        }

		[TestMethod]
		public void TestQuantityInStock()
        {
			//create instance of the class
			clsStock AStock = new clsStock();
			//boolean variable to store the result of the search
			Boolean Found = false;
			//boolean variable to record if data is OK
			Boolean OK = true;
			//create some test data to use with the method
			Int32 StockItemNo = 1;
			//invoke the method
			Found = AStock.Find(StockItemNo);
			//check the property
			if(AStock.QuantityInStock != 10)
            {
				OK = false;
            }
			//test to see that the result is correct
			Assert.IsTrue(OK);
        }


	}
}
