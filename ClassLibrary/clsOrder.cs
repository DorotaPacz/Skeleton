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

        public bool Find(int ID)
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

        public string Valid(string testDate, string testTotalPrice)
        {
            //create a string variable to store the error
            String Error = "";

            //create temporary variable to store date values
            DateTime DateTemp;
            Double TotalPriceTemp;

            //********* TOTAL PRICE VALIDATION ****************
            //if the TotalPrice is blank
            if (testTotalPrice.Length == 0)
            {
                //record the error
                Error = Error + "The totalPrice cannot be blank";
            }

            //if TotalPrice is less than 0
            try
            {
                TotalPriceTemp = Convert.ToDouble(testTotalPrice);
                if (TotalPriceTemp < 0)
                {
                    Error = Error + "The totalPrice cannot be smaller than 0";
                }

            }
            catch
            {
                Error = Error + "The totalPrice was not a valid data type";
            }

            //************* DATE VALIDATION ****************
            try
            { 
                DateTemp = Convert.ToDateTime(testDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date ";
            }

            //return any error messages
            return Error;
        }
    }
}