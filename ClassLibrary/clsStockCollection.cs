using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public List<clsStock> StockList 
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }

        public int Count 
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //empty
            }
        }

        public clsStock ThisStock 
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            {
                clsDataConnection DB = new clsDataConnection();

                DB.AddParameter("@StockItemNo", mThisStock.StockItemNo);
                DB.AddParameter("@StockItemDescription", mThisStock.StockItemDescription);
                DB.AddParameter("@DateAdded", mThisStock.DateAdded);
                DB.AddParameter("@Price", mThisStock.Price);
                DB.AddParameter("@QuantityInStock", mThisStock.QuantityInStock);
                DB.AddParameter("@Available", mThisStock.Available);

                return DB.Execute("sproc_tblStockItem_Insert");
            }
        }

        //private data member
        List<clsStock> mStockList = new List<clsStock>();

        clsStock mThisStock = new clsStock();

        public clsStockCollection()
        {
            //var for index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStockItem_SelectAll");
            RecordCount = DB.Count;

            while(Index < RecordCount)
            {
                clsStock AStock = new clsStock();
                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AStock.StockItemDescription = Convert.ToString(DB.DataTable.Rows[Index]["StockItemDescription"]);
                AStock.StockItemNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StockItemNo"]);
                AStock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AStock.QuantityInStock = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityInStock"]);
                AStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);

                mStockList.Add(AStock);
                Index++;
            }
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockItemNo", mThisStock.StockItemNo);
            DB.AddParameter("@StockItemDescription", mThisStock.StockItemDescription);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@QuantityInStock", mThisStock.QuantityInStock);
            DB.AddParameter("@Available", mThisStock.Available);

            DB.Execute("sproc_tblStockItem_Update");
        }
    }
}