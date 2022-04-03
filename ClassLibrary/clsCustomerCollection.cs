using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        private List<clsCustomer> mCustomerList = new List<clsCustomer>();

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
        
        public clsCustomer ThisCustomer { get; set; }


        //constructor for the class
        public clsCustomerCollection()
        {
            ////Create the item of test data
            //clsCustomer TestItem = new clsCustomer();
            ////set its properties
            //TestItem.IsStudent = true;
            //TestItem.CustomerID = 1;
            //TestItem.CustomerName = "Jake John";
            //TestItem.CustomerDOB = DateTime.Now.Date;
            //TestItem.StudnetDiscountPercentage = 1.5000;
            ////add the item to teh test list
            //mCustomerList.Add(TestItem);
            ////re initialise the object for some new data
            //TestItem = new clsCustomer();
            ////set its properties
            //TestItem.IsStudent = true;
            //TestItem.CustomerID = 5;
            //TestItem.CustomerName = "Laura Shaw";
            //TestItem.CustomerDOB = DateTime.Now.Date;
            //TestItem.StudnetDiscountPercentage = 1.5000;
            ////add the ietem to the test list 
            //mCustomerList.Add(TestItem);

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
    }
}