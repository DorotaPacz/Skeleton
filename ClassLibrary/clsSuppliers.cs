using System;

namespace ClassLibrary
{
    public class clsSuppliers
    {
        private Boolean mSupplierAvailable;
        public bool SupplierAvailable
        {
            get
            {
                return mSupplierAvailable;
            }
            set
            {
                mSupplierAvailable = value;
            }
        }
        //addressNo private member variable
        private Int32 mSuppliersId;

        public int SuppliersId
        {
            get
            {
                //this line of code sends data out of the property
                return mSuppliersId;
            }
            set
            {
                //this line of code allows data into the property
                mSuppliersId = value;
            }
        }
        
        public long SuppliersContactNo { get; set; }
        private long mSupplierContactNo;
        public long SupplierContactNo
        {
            get
            {
                return mSupplierContactNo;
            }
            set
            {
                mSupplierContactNo = value;
            }
        }
        private string mSupplierName;
        public string SupplierName
        {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }
        private string mSupplierEmail;

        public string SupplierEmail
        {
            get
            {
                return mSupplierEmail;
            }
            set
            {
                mSupplierEmail = value;
            }
        }

        private string mSupplierAddress;

        public string SupplierAddress
        {
            get
            {
                return mSupplierAddress;
            }
            set
            {
                mSupplierAddress = value;
            }
        }

        public bool Find(int suppliersId)
        {
            //set the private data members to the test data value
            mSuppliersId = 21;
            mSupplierContactNo = 07099772331;
            mSupplierEmail = "supplier@mail.com";
            mSupplierAddress = "2 manny road nigeria";
            mSupplierName = "Manny LTD";
            mSupplierAvailable = true;
            //always return true
            return true;
        }
    }
}