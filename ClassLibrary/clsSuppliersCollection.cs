using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSuppliersCollection
    {
        //private data member for the list
        List<clsSuppliers> mSuppliersList = new List<clsSuppliers>();
        clsSuppliers mThisSuppliers = new clsSuppliers();
        public List<clsSuppliers> SuppliersList
        {
            get
            {
                return mSuppliersList;
            }
            set
            {
                mSuppliersList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSuppliersList.Count;
            }
            set
            {
            }
        }
        public clsSuppliers ThisSuppliers
        {
            get
            {
                return mThisSuppliers;
            }
            set
            {
                mThisSuppliers = value;
            }
        }

        public int Add()
        {
            mThisSuppliers.SupplierId = 123;
            return mThisSuppliers.SupplierId;

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("SupplierName", mThisSuppliers.SupplierName);
            DB.AddParameter("SupplierEmail", mThisSuppliers.SupplierEmail);
            DB.AddParameter("SupplierAddress", mThisSuppliers.SupplierAddress);
            DB.AddParameter("SupplierAvailable", mThisSuppliers.SupplierAvailable);
            DB.AddParameter("@SupplierContactNo", mThisSuppliers.SupplierContactNo);
            return DB.Execute("sproc_tblSupplier_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", mThisSuppliers.SupplierId);
            DB.AddParameter("@SupplierName", mThisSuppliers.SupplierName);
            DB.AddParameter("@SupplierAddress", mThisSuppliers.SupplierAddress);
            DB.AddParameter("@SupplierEmail", mThisSuppliers.SupplierEmail);
            DB.AddParameter("@SupplierAvailable", mThisSuppliers.SupplierAvailable);
            DB.AddParameter("@SupplierContactNo", mThisSuppliers.SupplierContactNo);
            DB.Execute("sproc_tblSuppliers_Update");
        }

        public void ReportBySupplierName(object text)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", mThisSuppliers.SupplierId);
            DB.Execute("sproc_tblSuppliers_Delete");
        }

        public void ReportBySupplierName(string SupplierName)

        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierName", SupplierName);
            DB.Execute("sproc_tblSuppliers_FilterBySupplierName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mSuppliersList = new List<clsSuppliers>();
            while (Index < RecordCount)
            {
                clsSuppliers AnSuppliers = new clsSuppliers();
                AnSuppliers.SupplierAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["SupplierAvailable"]);
                AnSuppliers.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSuppliers.SupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["SupplierAddress"]);
                AnSuppliers.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                AnSuppliers.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AnSuppliers.SupplierContactNo = Convert.ToInt64(DB.DataTable.Rows[Index]["SupplierContactNo"]);
                mSuppliersList.Add(AnSuppliers);
                Index++;
            }
        }
        
    }
}