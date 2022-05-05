using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSuppliersCollection
    {
        //private data member for the list
        List<clsSuppliers> mSuppliersList = new List<clsSuppliers>();
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
        public clsSuppliers ThisSuppliers { get; set; }
    }
}