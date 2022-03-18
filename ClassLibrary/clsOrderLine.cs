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


        public bool Find(int stockItemNo)
        {
            //hardcoded data
            privateStockItemNo = 1;
            privateOrderID = 1;
            privateQuantity = 1;
            //always return true
            return true;
        }
    }
}