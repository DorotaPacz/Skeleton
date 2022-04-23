using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {


        private List<clsOrder> mOrderList = new List<clsOrder>();
        private clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_select_all");
            RecordCount = DB.Count;

            while(Index < RecordCount)
            {
                clsOrder newOrder = new clsOrder();
                newOrder.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                newOrder.IsFulfilled = Convert.ToBoolean(DB.DataTable.Rows[Index]["isFulfilled"]);
                newOrder.TotalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalPrice"]);
                newOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                mOrderList.Add(newOrder);
                Index++;

            }
        }


        public List<clsOrder> OrderList 
        { 
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count 
        { 
            get
            {
                return mOrderList.Count;
            }
            set 
            { 
                //worry later
            }
        }
        public clsOrder ThisOrder 
        { 
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisOrder
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.AddParameter("@isFulfilled", mThisOrder.IsFulfilled);

            return DB.Execute("sproc_tblOrder_Insert");
        }
    }
}