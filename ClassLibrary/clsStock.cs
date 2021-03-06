using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the stock no
        private Int32 mStockItemNo;
        //private data member for date
        private DateTime mDateAdded;
        //private data member for availability
        private Boolean mAvailable;
        //private data member for description
        private string mStockItemDescription;
        //private data member for price
        private double mPrice;
        //private data member for quantity
        private Int32 mQuantityInStock;



        public bool Available 
        {
            get 
            {
                //return the private data
                return mAvailable;
            }

            set 
            {
                //set the private data
                mAvailable = value;
            }
        }
        public DateTime DateAdded 
        { 
            get 
            {
                return mDateAdded;
            }

            set 
            {
                mDateAdded = value;
            } 
        }
        public int StockItemNo 
        {
            get 
            {
                //this line of code sends data out of the property
                return mStockItemNo;
            }
            set
            {
                //this line of code allows data into the property
                mStockItemNo = value;
            }
        }
        public string StockItemDescription 
        {
            get 
            {
                //return the private data
                return mStockItemDescription;
            }

            set
            {
                //set the private data
                mStockItemDescription = value;
            }
        }
        public double Price 
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }
        public int QuantityInStock
        {
            get
            {
                //return the private data
                return mQuantityInStock;
            }
            set
            {
                //set the private data
                mQuantityInStock = value;
            }
        }

        public bool Find(int StockItemNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock item no. to search for
            DB.AddParameter("@StockItemNo", StockItemNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStockItem_FilterByStockItemNo");
            //if one record is found (there should be 1 or 0)
            if(DB.Count == 1)
            {
                //copy the data from database to the private data members
                mStockItemNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockItemNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mStockItemDescription = Convert.ToString(DB.DataTable.Rows[0]["StockItemDescription"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mQuantityInStock = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityInStock"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string stockItemDescription, string dateAdded, string price, string quantityInStock)
        {
            //create a string variable to store the error
            String Error = "";
            //temporary variables
            DateTime DateTemp;
            Double PriceTemp;
            Int32 QuantityInStockTemp;

            try
            {
                //if quantity is blank
                if (quantityInStock.Length == 0)
                {
                    //record the error
                    Error = Error + "The quantity may not be blank";
                }

                //if quantity is greater than 500
                QuantityInStockTemp = Convert.ToInt32(quantityInStock);
                if (QuantityInStockTemp > 10000)
                {
                    //record the error
                    Error = Error + "There can not be more than 10000 items in stock";
                }

                //if quantity is below 0
                if (QuantityInStockTemp < 0)
                {
                    //record the error
                    Error = Error + "There can not be less than 0 items in stock";
                }
            }
            catch
            {
                Error = Error + "Quantity is not valid";
            }
            //if the StockItemDescription is blank
            if(stockItemDescription.Length == 0)
            {
                //record the error
                Error = Error + "The Stock Item Description may not be blank : ";
            }
            //if the StockItemDescription is greater than 50 characters
            if(stockItemDescription.Length > 50)
            {
                Error = Error + "The StockItemDescription must be less than 50 characters : ";
            }


            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";

                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }

            //if price is blank
            if (price.Length == 0)
            {
                //record the error
                Error = Error + "The price cannot be blank! ";
            }

            //if price is less than 0
            try
            {
                PriceTemp = Convert.ToDouble(price);
                if (PriceTemp < 0)
                {
                    Error = Error + "The price cannot be smaller than zero! ";
                }

                PriceTemp = Convert.ToDouble(price);
                if (PriceTemp > 10000000)
                {
                    Error = Error + "The price cannot be grater than 10M ";
                }

            }
            catch
            {
                Error = Error + "The price is not valid";
            }

            //return any error messages
            return Error;
        }
    }
}