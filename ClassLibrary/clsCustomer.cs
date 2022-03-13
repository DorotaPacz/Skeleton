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
        public double StudnetDisscountPercentage
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

        public bool Find(int customerID)
        {
            //throw new NotImplementedException();
            mCustomerID = 21;
            mCustomerDOB = Convert.ToDateTime("15/09/2000");
            mCustomerName = "Test Customer Name";
            mStudentDiscountPercentage = Convert.ToDouble("1.5");
            mIsStudent = true;
            //always return true
            return true;
        }

    }
}