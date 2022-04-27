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
        private Int32 mSupplierId;

        public int SupplierId
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierId;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierId = value;
            }
        }
        
       // public long SuppliersContactNo { get; set; }
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

        public bool Find(int SupplierId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("SupplierId", SupplierId);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSupplierContactNo = Convert.ToInt64(DB.DataTable.Rows[0]["SupplierContactNo"]);
                mSupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                mSupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["SupplierEmail"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["SupplierAvailable"]);

                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string supplierName, string supplierAddress, string supplierContactNo, string supplierEmail)
        {
            throw new NotImplementedException();
        }
    }
}