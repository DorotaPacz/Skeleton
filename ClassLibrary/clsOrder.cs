using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the ID property
        private Int32 privateID;
        //ID public property
        public Int32 ID
        {
            get
            {
                //this line of the code sends data out of the property
                return privateID;
            }
            set
            {
                //this line of code allows data into the property
                privateID = value;
            }
        }

        //private data member for Date property
        private DateTime privateDate;
        //Date public property
        public DateTime Date
        {
            get
            {
                return privateDate;
            }
            set
            {
                privateDate = value;
            }
        }

        //private data member for IsFulfilled property
        private bool privateIsFulfilled;
        //IsFulfilled public property
        public bool IsFulfilled
        {
            get
            {
                return privateIsFulfilled;
            }
            set
            {
                privateIsFulfilled = value;
            }
        }

        //private data member for TotalPrice property
        private double privateTotalPrice;
        //TotalPrice public property
        public double TotalPrice
        {
            get
            {
                return privateTotalPrice;
            }
            set
            {
                privateTotalPrice = value;
            }
        }

        public bool Find(int iD)
        {
            //set the private data members to the test data value
            //subject to change later 
            //this is just hardcoding values
            privateID = 1;
            privateDate = Convert.ToDateTime("16/03/2022");
            privateIsFulfilled = false;
            privateTotalPrice = 1.99;

            //always return true
            return true;
        }
    }
}