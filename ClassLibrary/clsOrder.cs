using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the ID property
        private Int32 privateID;
        //ID public property
        public Int32 ID
        {
            get
            {
                //this line of the code sends data out of the property
                return privateID;
            }
            set
            {
                //this line of code allows data into the property
                privateID = value;
            }
        }

        //private data member for Date property
        private DateTime privateDate;
        //Date public property
        public DateTime Date
        {
            get
            {
                return privateDate;
            }
            set
            {
                privateDate = value;
            }
        }

        //private data member for IsFulfilled property
        private bool privateIsFulfilled;
        //IsFulfilled public property
        public bool IsFulfilled
        {
            get
            {
                return privateIsFulfilled;
            }
            set
            {
                privateIsFulfilled = value;
            }
        }

        //private data member for TotalPrice property
        private double privateTotalPrice;
        //TotalPrice public property
        public double TotalPrice
        {
            get
            {
                return privateTotalPrice;
            }
            set
            {
                privateTotalPrice = value;
            }
        }

        public bool Find(int iD)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the ID to search for
            DB.AddParameter("@ID", ID);

            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByID");

            //if one record is found (there should be either one or zero!)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                privateID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                privateDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                privateIsFulfilled = Convert.ToBoolean(DB.DataTable.Rows[0]["isFulfilled"]);
                privateTotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["TotalPrice"]);
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
    }
}