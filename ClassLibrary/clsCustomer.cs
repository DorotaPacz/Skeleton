using System;

namespace ClassLibrary
{
    public class clsCustomer

    {
        
        public bool IsStudent { get; set; }
        public string CustomerName { get; set; }
        public double StudnetDisscountPercentage { get; set; }
        public DateTime CustomerDOB { get; set; }
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

            return true;
        }

    }
}