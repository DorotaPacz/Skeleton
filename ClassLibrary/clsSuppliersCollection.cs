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

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", mThisSuppliers.SupplierId);
            DB.Execute("sproc_tblSuppliers_Delete");
        }
    }
}