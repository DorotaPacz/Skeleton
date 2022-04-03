using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        private List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //priavet data member ThisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //Return the private data
                return mCustomerList;
            }
            set
            {
                //Set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //No code needed for now
            }
        }
        
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }


        //constructor for the class
        public clsCustomerCollection()
        {
           

            //var for the index
            Int32 Index = 0;
            //var to store the recored count 
            Int32 RecoredCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //Get the count of records
            RecoredCount = DB.Count;
            //while there are recored to process
            while (Index < RecoredCount)
            {
                //craete a blacnk customer
                clsCustomer Customer = new clsCustomer();
                //read in the fiels from the current recored
                Customer.IsStudent = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsStudent"]);
                Customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                Customer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                Customer.CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
                Customer.StudnetDiscountPercentage = Convert.ToDouble(DB.DataTable.Rows[Index]["StudentDiscountPercentage"]);
                //Add the recored to the private data member
                mCustomerList.Add(Customer);
                //point at the next recored
                Index++;
            }
        }

        public int Add()
        {
            //adds a new recored to the database based on the va;ues of thisCustomer
            //connect to the data base
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stores procedure
            DB.AddParameter("CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("CustomerDOB", mThisCustomer.CustomerDOB);
            DB.AddParameter("StudentDiscountPercentage", mThisCustomer.StudnetDiscountPercentage);
            DB.AddParameter("IsStudent", mThisCustomer.IsStudent);
            //execute the query returning the primary key
            return DB.Execute("sproc_tblCustomer_Insert");
        }
    }
}