using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        private List<clsStaff> mStaffList = new List<clsStaff>();

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
        public clsStaff ThisStaff { get; set; }
     // constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
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

    }
}