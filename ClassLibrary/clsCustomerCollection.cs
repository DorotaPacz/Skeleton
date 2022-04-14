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
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stord porcedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

            //************************************************

            ////var for the index
            //Int32 Index = 0;
            ////var to store the recored count 
            //Int32 RecoredCount = 0;
            ////object for data connection
            //clsDataConnection DB = new clsDataConnection();
            ////execute the stored procedure
            //DB.Execute("sproc_tblCustomer_SelectAll");
            ////Get the count of records
            //RecoredCount = DB.Count;
            ////while there are recored to process
            //while (Index < RecoredCount)
            //{
            //    //craete a blacnk customer
            //    clsCustomer Customer = new clsCustomer();
            //    //read in the fiels from the current recored
            //    Customer.IsStudent = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsStudent"]);
            //    Customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
            //    Customer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
            //    Customer.CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
            //    Customer.StudnetDiscountPercentage = Convert.ToDouble(DB.DataTable.Rows[Index]["StudentDiscountPercentage"]);
            //    //Add the recored to the private data member
            //    mCustomerList.Add(Customer);
            //    //point at the next recored
            //    Index++;
        }




        public int Add()
        {
            //adds a new recored to the database based on the va;ues of thisCustomer
            //connect to the data base
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stores procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerDOB", mThisCustomer.CustomerDOB);
            DB.AddParameter("@StudentDiscountPercentage", mThisCustomer.StudentDiscountPercentage);
            //DB.AddParameter("StudentDiscountPercentage", mThisCustomer.StudentDiscountPercentage);
            DB.AddParameter("@IsStudent", mThisCustomer.IsStudent);
            //execute the query returning the primary key
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing recored baed on the values of ThisCustomer
            //connect to the datbase
            clsDataConnection DB = new clsDataConnection();
            //set the parameters fo rthe stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerDOB", mThisCustomer.CustomerDOB);
            DB.AddParameter("@StudentDiscountPercentage", mThisCustomer.StudentDiscountPercentage);
            DB.AddParameter("@IsStudent", mThisCustomer.IsStudent);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");

        }

        public void Delete()
        {
            //feletes the recored pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parametrs for theh stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerName(string CustomerName)
        {
            //filters the recoreds based on a full or partial Customer Name
            //connect to the databsed
            clsDataConnection DB = new clsDataConnection();
            //sent the customer name parameter to the database
            DB.AddParameter("@CustomerName", CustomerName);
            //execute teh stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerName");
            PopulateArray(DB);

        }
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store recored count 
            Int32 RecoredCount;
            //get the count of recoreds
            RecoredCount = DB.Count;
            //create the private array llist
            mCustomerList = new List<clsCustomer>();
            //while there are recored to process
            while (Index < RecoredCount)
            {
                //create a blank customer
                clsCustomer Customer = new clsCustomer();
                //read in the fields from teh current recored
                Customer.IsStudent = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsStudent"]);
                Customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                Customer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                Customer.CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
                Customer.StudentDiscountPercentage = Convert.ToDouble(DB.DataTable.Rows[Index]["StudentDiscountPercentage"]);
                //add the recored to the private data member
                mCustomerList.Add(Customer);
                //point at the next recored
                Index++;
            }
        }
    }
}