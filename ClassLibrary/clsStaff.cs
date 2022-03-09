using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Id number property
        private Int32 mIdNumber;
        //private data member for the date begin property
        private DateTime mDateBegin;
        //private data member for the staff name property
        private String mStaffName;
        //private data member for the staff name property
        private Double mSalary;
        //private data member for the staff name property
        private Boolean mIsAdmin;

        //getters, setters methods
        public string StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }
        public bool IsAdmin
        {
            get
            {
                return mIsAdmin;
            }
            set
            {
                mIsAdmin = value;
            }
        }
        public DateTime DateBegin
        {
            get
            {
                return mDateBegin;
            }
            set
            {
                mDateBegin = value;
            }
        }
        public int IdNoOK
        {
            get
            {
                // this data code sends data out of the property
                return mIdNumber;
            }
            set
            {
                //this line of code allows data into property
                mIdNumber = value;
            }
        }
        public double Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }

        public bool Find(int staffIdNo)
        {
            //create an instance (object) of data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff idNo to search for
            DB.AddParameter("@StaffIdNo", staffIdNo);
            //ececute the stored procedure
            DB.Execute("sproc_tblStaffManagement_FilterByIdNo");
            //if one record is found (its either one or zero)
            if(DB.Count ==1)
            {
                //copy data from database to the private data members
                mIdNumber = Convert.ToInt32(DB.DataTable.Rows[0]["StaffIdNo"]);
                mDateBegin = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDateStarted"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mSalary = Convert.ToDouble(DB.DataTable.Rows[0]["StaffSalary"]);
                mIsAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAdmin"]);
                // return correct/ working information
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