using System;

namespace ClassLibrary
{
    public class clsCustomer

    {

        private bool mIsStudent;
        public bool IsStudent
        {
            get
            {
                return mIsStudent;
            }
            set
            {
                mIsStudent = value;
            }
        }

        private string mCustomerName;
        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }
        private double mStudentDiscountPercentage;
        public double StudentDiscountPercentage
        {
            get
            {
                return mStudentDiscountPercentage;
            }
            set
            {
                mStudentDiscountPercentage = value;
            }
        }


        private DateTime mCustomerDOB;
        public DateTime CustomerDOB
        {
            get
            {
                return mCustomerDOB;
            }
            set
            {
                mCustomerDOB = value;
            }
        }



        private Int32 mCustomerID;
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an instance of teh data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mStudentDiscountPercentage = Convert.ToDouble(DB.DataTable.Rows[0]["StudentDiscountPercentage"]);
                mIsStudent = Convert.ToBoolean(DB.DataTable.Rows[0]["IsStudent"]);
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

        public string Valid(string customerName, string customerDOB, string studnetDiscountPercentage)
        {
            //create a string variable to stre the error 
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            Double StudnetDiscountPercentageTemp;

            //if the CusomerName is balck
            if (customerName.Length == 0)
            {
                //record the  error 
                Error = Error + "The Customer Name may not be blank: ";
            }
            //if the cutsomer name is greater than 50 characters
            if (customerName.Length > 50)
            {
                //recored the error
                Error = Error + "The Customer Name must be less than 50 characters: ";
            }
            try
            {
                //copy the CustomerBOD value to the DateTemp var
                DateTemp = Convert.ToDateTime(customerDOB);
          
                if (DateTemp > DateTime.Now.Date)
                {
                    //recored the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //recored the error
                Error = Error + "The date was not a valid date : ";
            }
            //if the StudnetDiscountPercentage is balnk
            if (studnetDiscountPercentage.Length == 0)
            {
                //recored the error
                Error = Error + " The StudnetDiscountPercentage cannot be blank :  ";
            }
            // if the StudnetDiscountPercentage is less than 0
            try
            {
                StudnetDiscountPercentageTemp = Convert.ToDouble(studnetDiscountPercentage);
                if (StudnetDiscountPercentageTemp < 0)
                {
                    Error = Error + "The StudnetDiscountPercentage cannot be smaller than 0";
                }
              
            }
            catch
            {
                Error = Error + "The StudnetDiscountPercentage was not a valid data type";
            }
            //return any error message 

            return Error;
        }
    }
}