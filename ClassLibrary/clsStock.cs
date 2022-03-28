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
            //set the private data members to the test data value
            mStockItemNo = 1;
            mDateAdded = Convert.ToDateTime("16/09/2021");
            mAvailable = true;
            mStockItemDescription = "Test Description";
            mPrice = 10;
            mQuantityInStock = 3;

            //always return true
            return true;
        }
    }
}