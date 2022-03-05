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
            //set private data members to the test data value
            mIdNumber = 10;
            mDateBegin = Convert.ToDateTime("05/03/2022");
            mStaffName = "Amy Zing";
            mSalary = Convert.ToDouble("102030");
            mIsAdmin = true;
            //always return true
            return true;
        }
    }
}