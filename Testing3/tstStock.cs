using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
	[TestClass]
	public class tstStock
	{
		//good test data
		string StockItemDescription = "Electric Guitar";
		string DateAdded = DateTime.Now.Date.ToString();
		string Price = "300";
		string QuantityInStock = "3";

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
			if (AStock.StockItemNo != 1)
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
			if (AStock.StockItemDescription != "Electric Guitar")
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
			if (AStock.Price != 500)
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
			if (AStock.QuantityInStock != 10)
			{
				OK = false;
			}
			//test to see that the result is correct
			Assert.IsTrue(OK);
		}

		[TestMethod]
		public void ValidMethodOK()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void StockItemDescriptionMinLessOne()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//create some test data to pass to the method
			string StockItemDescription = ""; //this triggers error
											  //invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void StockItemDescriptionMin()
		{
			clsStock AStock = new clsStock();
			String Error = "";
			string StockItemDescription = "E";
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void StockItemDescriptionPlusOne()
		{
			clsStock AStock = new clsStock();
			String Error = "";
			string StockItemDescription = "Ee";
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void StockItemDescriptionMaxLessOne()
		{
			clsStock AStock = new clsStock();
			String Error = "";
			string StockItemDescription = "Eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void StockItemDescriptionMax()
		{
			clsStock AStock = new clsStock();
			String Error = "";
			string StockItemDescription = "Eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void StockItemDescriptionMid()
		{
			clsStock AStock = new clsStock();
			String Error = "";
			string StockItemDescription = "Eeeeeeeeeeeeeeeeeeeeeeeee";
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void StockItemDescriptionMaxPlusOne()
		{
			clsStock AStock = new clsStock();
			String Error = "";
			string StockItemDescription = "Eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void StockItemDescriptionExtremeMax()
		{
			clsStock AStock = new clsStock();
			String Error = "";
			string StockItemDescription = "";
			StockItemDescription = StockItemDescription.PadRight(500, 'a');
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void DateAddedExtremeMin()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//create a variable to store the test date data
			DateTime TestDate;
			//set the date to today's date
			TestDate = DateTime.Now.Date;
			//change the data to whatever the date is less 100 years
			TestDate = TestDate.AddYears(-100);
			//convert the date variable to a string variable
			string DateAdded = TestDate.ToString();
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void DateAddedMinLessOne()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//create a variable to store the test date data
			DateTime TestDate;
			//set the date to today's date
			TestDate = DateTime.Now.Date;
			//change the data to whatever the date is less 1 day
			TestDate = TestDate.AddDays(-1);
			//convert the date variable to a string variable
			string DateAdded = TestDate.ToString();
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void DateAddedMin()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//create a variable to store the test date data
			DateTime TestDate;
			//set the date to today's date
			TestDate = DateTime.Now.Date;
			//convert the date variable to a string variable
			string DateAdded = TestDate.ToString();
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void DateAddedMinPlusOne()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//create a variable to store the test date data
			DateTime TestDate;
			//set the date to today's date
			TestDate = DateTime.Now.Date;
			//change the data to whatever the date is plus 1 day
			TestDate = TestDate.AddDays(1);
			//convert the date variable to a string variable
			string DateAdded = TestDate.ToString();
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void DateAddedExtremeMax()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//create a variable to store the test date data
			DateTime TestDate;
			//set the date to today's date
			TestDate = DateTime.Now.Date;
			//change the data to whatever the date is plus 100 years
			TestDate = TestDate.AddYears(100);
			//convert the date variable to a string variable
			string DateAdded = TestDate.ToString();
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void DateAddedInvalidData()
        {
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the DateAdded to a non date value
			string DateAdded = "This is not a date!";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
        }

		[TestMethod]
		public void PriceExtremeMin()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the price at extremely low number.
			string Price = "-999999";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void PriceExtremeMax()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the price
			string Price = "10000000000000";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void PriceMin()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the price
			string Price = "0";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void PriceMinPlusOne()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the price
			string Price = "1";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void PriceMinLessOne()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the price
			string Price = "-1";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void PriceExtremeMaxPlusOne()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the price
			string Price = "10000000000001";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void PriceMaxPlusOne()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the price
			string Price = "10000001";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void PriceMid()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the price.
			string Price = "5000000";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void PriceInvalidData()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the price
			string Price = "aa";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void PriceDecimal()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the price
			string Price = "100.99";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void QuantityeInStockMin()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the quantity
			string QuantityInStock = "0";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void QuantityeInStockMinLessOne()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the quantity
			string QuantityInStock = "-1";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void QuantityeInStockMinPlusOne()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the quantity
			string QuantityInStock = "1";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void QuantityeInStockMax()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the quantity
			string QuantityInStock = "10000";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void QuantityeInStockMaxPlusOne()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the quantity
			string QuantityInStock = "10001";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void QuantityeInStockMaxLessOne()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the quantity
			string QuantityInStock = "9999";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void QuantityeInStockMid()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the quantity
			string QuantityInStock = "5000";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void QuantityeInStockInvalidData()
		{
			//create an instance of the class we want to create
			clsStock AStock = new clsStock();
			//string variable to store any error message
			String Error = "";
			//set the quantity
			string QuantityInStock = "aa";
			//invoke the method
			Error = AStock.Valid(StockItemDescription, DateAdded, Price, QuantityInStock);
			//test to see that the result is correct
			Assert.AreNotEqual(Error, "");
		}


	}
}
