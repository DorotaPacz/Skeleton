using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        private List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        private clsStaff mThisStaff = new clsStaff();

        //public property for the staff list
        public List<clsStaff> StaffList 
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data 
                mStaffList = value;
            }
        }
        public int Count 
        {
            get 
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set 
            {
              //we will worry about it later
            } 
        }
        public clsStaff ThisStaff 
        {
            get
            {
                //return private data
                return mThisStaff;
            }
            set 
            {
                //set private data
                mThisStaff = value;
            } 
        }
     // constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //populate the array list with the data table
            PopulateArray(DB);
            //execute the stored procedure
            DB.Execute("sproc_tblStaffManagement_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records process
            while(Index < RecordCount)
            {
                //create a blank staff record
                clsStaff AStaff = new clsStaff();
                AStaff.IsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAdmin"]);
                AStaff.IdNoOK = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffIdNo"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.DateBegin = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDateStarted"]);
                AStaff.Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["StaffSalary"]);
                //add the item to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
            
        }

        public int Add()
        {
            //adds the new record to the database based on the values of thisStaff
            //connect to the database

            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffDateStarted", mThisStaff.DateBegin);
            DB.AddParameter("@StaffSalary", mThisStaff.Salary);
            DB.AddParameter("@IsAdmin", mThisStaff.IsAdmin);

            //execute query returning the primary key value
            return DB.Execute("sproc_tblStaffManagement_Insert");
        }

        public void Update()
        {
            //update an existing record to the database based on the values of thisStaff
            //connect to the database

            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffIdNo", mThisStaff.IdNoOK);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffDateStarted", mThisStaff.DateBegin);
            DB.AddParameter("@StaffSalary", mThisStaff.Salary);
            DB.AddParameter("@IsAdmin", mThisStaff.IsAdmin);

            //execute query returning the primary key value
            DB.Execute("sproc_tblStaffManagement_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffIdNo", mThisStaff.IdNoOK);
            //execute the stored procedure
            DB.Execute("sproc_tblStaffManagement_Delete");

        }

        public void ReportByStaffName(string StaffName)
        {
            //filters the records based on the full or partial staff name
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the name parameter to the database
            DB.AddParameter("@StaffName", StaffName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaffManagement_FilteredByStaffName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while(Index < RecordCount)
            {
                //create blank staff name
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.IsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAdmin"]);
                AStaff.IdNoOK = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffIdNo"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.DateBegin = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDateStarted"]);
                AStaff.Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["StaffSalary"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }


        }
    }
}