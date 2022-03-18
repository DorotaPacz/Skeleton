using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        //private data member for the StockItemNo property
        private Int32 privateStockItemNo;
        //StockItemNo public property
        public Int32 StockItemNo
        {
            get
            {
                //this line of the code sends data out of the property
                return privateStockItemNo;
            }
            set
            {
                //this line of code allows data into the property
                privateStockItemNo = value;
            }
        }

        //private data member for the OrderID property
        private Int32 privateOrderID;
        //OrderID public property
        public Int32 OrderID
        {
            get
            {
                //this line of the code sends data out of the property
                return privateOrderID;
            }
            set
            {
                //this line of code allows data into the property
                privateOrderID = value;
            }
        }

        //private data member for the OrderID property
        private Int32 privateQuantity;
        //OrderID public property
        public Int32 Quantity
        {
            get
            {
                //this line of the code sends data out of the property
                return privateQuantity;
            }
            set
            {
                //this line of code allows data into the property
                privateQuantity = value;
            }
        }


        public bool Find(int StockItemNo)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the StockItemNo to search for
            DB.AddParameter("@StockItemNo", StockItemNo);

            //execute stored procedure
            DB.Execute("sproc_tblOrderLine_FilterByStockItemNo");

            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy data from the database to the private data members
                privateOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                privateStockItemNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockItemNo"]);
                privateQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);

                //return that everything worked OK
                return true;
            }
            // if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}