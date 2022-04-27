using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstSuppliers

    {
        string SupplierName = "manny and co";
        string SupplierEmail = "Supplier2@email.com";
        string SupplierAddress = "2 manny land";
        string SupplierContactNo = "07099772331";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //test to see that it exists
            Assert.IsNotNull(AnSuppliers);

        }
        [TestMethod]
        public void SupplierAvailablePropertOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some of the test data
            Boolean TestData = true;
            //assign the data to the property
            AnSuppliers.SupplierAvailable = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnSuppliers.SupplierAvailable, TestData);
        }
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnSuppliers.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.SupplierId, TestData);
        }
        [TestMethod]
        public void SupplierContactNoPropertyOk()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            long TestData = 77656512;
            AnSuppliers.SupplierContactNo = TestData;
            Assert.AreEqual(AnSuppliers.SupplierContactNo, TestData);

        }
        [TestMethod]
        public void SupplierNameOK()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            string TestData = "manny and co";
            AnSuppliers.SupplierName = TestData;
            Assert.AreEqual(AnSuppliers.SupplierName, TestData);
        }
        [TestMethod]
        public void SupplierEmailOK()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            string TestData = "supplier2@email.com";
            AnSuppliers.SupplierEmail = TestData;
            Assert.AreEqual(AnSuppliers.SupplierEmail, TestData);

        }
        [TestMethod]
        public void SupplierAddressOK()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            string TestData = "2 manny land";
            AnSuppliers.SupplierAddress = TestData;
            Assert.AreEqual(AnSuppliers.SupplierAddress, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //Boolean varaible to store the result of the validation
            Boolean Found = false;
            //create some test data to use with method
            Int32 SupplierId = 2;
            //invoke the method
            Found = AnSuppliers.Find(SupplierId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestSuppliersIdFound()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 2;
            //invoke the method
            Found = AnSuppliers.Find(SupplierId);
            //check the address no
            if (AnSuppliers.SupplierId != 2)
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = AnSuppliers.Find(SupplierId);
            if (AnSuppliers.SupplierName != "manny and co")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierEmailFound()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = AnSuppliers.Find(SupplierId);
            if (AnSuppliers.SupplierEmail != "supplier2@email.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierAddressFound()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = AnSuppliers.Find(SupplierId);
            if (AnSuppliers.SupplierAddress != "2 manny land")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierContactNoFound()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = AnSuppliers.Find(SupplierId);
            if (AnSuppliers.SupplierContactNo != 07099772331)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierAvailableFound()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = AnSuppliers.Find(SupplierId);
            if (AnSuppliers.SupplierAvailable != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            string Error = "";
            string Valid(string SupplierName, string SupplierAddress, string SupplierContactNo, string SupplierEmail)
            {
                return "";
            }
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContacNo)
            {
                String Error = "";
                if (SupplierName.Length == 0)
                {
                    Error = Error + "The house may not work still: ";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierNameMin()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierName.Length == 1)
                {
                    Error = Error + "m";
                }
                return Error;
            }

        }
        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierName.Length == 2)
                {
                    Error = Error + "ma";
                }
                return Error;
            }

        }
        [TestMethod]
        public void SupplierNameMaxlessOne()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierName.Length == 49)
                {
                    Error = Error + "manny and coooooooooooooooooooooooooooooooooooooo";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierNameMax()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierName.Length == 50)
                {
                    Error = Error + "manny and coooooooooooooooooooooooooooooooooo.com";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierName.Length == 0)
                {
                    Error = Error + "This name may not be blank ";
                }
                if (SupplierName.Length > 50)
                {
                    Error = Error + "This name must be less than 50 characters : ";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierNameMid()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierName.Length == 25)
                {
                    Error = Error + "mmmmmmmmmmmmmmmmmmmmmmmmm";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            clsSuppliers AnSupplier = new clsSuppliers();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a');
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, SupplierContactNo);
            Assert.AreNotEqual(Error, "");
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        [TestMethod]
        public void SupplierEmailMinLessOne()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContacNo)
            {
                String Error = "";
                if (SupplierEmail.Length == 0)
                {
                    Error = Error + "Supplier2@email.com ";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierEmailMin()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierEmail.Length == 1)
                {
                    Error = Error + "s";
                }
                return Error;
            }

        }
        [TestMethod]
        public void SupplierEmailMinPlusOne()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierEmail.Length == 2)
                {
                    Error = Error + "su";
                }
                return Error;
            }

        }
        [TestMethod]
        public void SupplierEmailMaxlessOne()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierEmail.Length == 49)
                {
                    Error = Error + "manny and coooooooooooooooooooooooooooooooooooooo";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierEmailMax()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierEmail.Length == 50)
                {
                    Error = Error + "manny and coooooooooooooooooooooooooooooooooo.com";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierEmailMaxPlusOne()
        {
            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierEmail.Length == 0)
                {
                    Error = Error + "This name may not be blank ";
                }
                if (SupplierEmail.Length > 50)
                {
                    Error = Error + "This name must be less than 50 characters : ";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierEmailMid()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierEmail.Length == 25)
                {
                    Error = Error + "suppliersuppliersupl.comm";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierEmailExtremeMax()
        {
            clsSuppliers AnSupplier = new clsSuppliers();
            String Error = "";
            string SupplierEmail = "";
            SupplierEmail = SupplierEmail.PadRight(500, 'a');
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, SupplierContactNo);
            Assert.AreNotEqual(Error, "");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void SupplierAddressMinLessOne()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContacNo)
            {
                String Error = "";
                if (SupplierAddress.Length == 0)
                {
                    Error = Error + "manny land ";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierAddressMin()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierAddress.Length == 1)
                {
                    Error = Error + "m";
                }
                return Error;
            }

        }
        [TestMethod]
        public void SupplierAddressMinPlusOne()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierAddress.Length == 2)
                {
                    Error = Error + "ma";
                }
                return Error;
            }

        }
        [TestMethod]
        public void SupplierAddressMaxlessOne()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierAddress.Length == 49)
                {
                    Error = Error + "manny and coooooooooooooooooooooooooooooooooooooo";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierAddressMax()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierAddress.Length == 50)
                {
                    Error = Error + "manny and coooooooooooooooooooooooooooooooooo.com";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierAddressMaxPlusOne()
        {
            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierAddress.Length == 0)
                {
                    Error = Error + "This name may not be blank ";
                }
                if (SupplierAddress.Length > 50)
                {
                    Error = Error + "This name must be less than 50 characters : ";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierAddressMid()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierAddress.Length == 25)
                {
                    Error = Error + "suppliersuppliersupl.comm";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierAddressExtremeMax()
        {
            clsSuppliers AnSupplier = new clsSuppliers();
            String Error = "";
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(500, 'a');
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, SupplierContactNo);
            Assert.AreNotEqual(Error, "");

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void SupplierContactNoMinLessOne()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContacNo)
            {
                String Error = "";
                if (SupplierContactNo.Length == 0)
                {
                    Error = Error + "0887746648764 ";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierContactNoMin()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierContactNo.Length == 1)
                {
                    Error = Error + "0";
                }
                return Error;
            }

        }
        [TestMethod]
        public void SupplierContactNoMinPlusOne()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierContactNo.Length == 2)
                {
                    Error = Error + "+2";
                }
                return Error;
            }

        }
        [TestMethod]
        public void SupplierContactNoMaxlessOne()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierContactNo.Length == 49)
                {
                    Error = Error + "+2349887676534545";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierContactNoMax()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierContactNo.Length == 50)
                {
                    Error = Error + "0997865676456644 765467544578297556363737735 9888";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierContactNoMaxPlusOne()
        {
            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierContactNo.Length == 0)
                {
                    Error = Error + "This name may not be blank ";
                }
                if (SupplierContactNo.Length > 50)
                {
                    Error = Error + "This name must be less than 50 characters : ";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierContactNoMid()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();

            string Valid(string SupplierName, string SupplierEmail, string SupplierAddress, string SupplierContactNo)
            {
                String Error = "";
                if (SupplierContactNo.Length == 25)
                {
                    Error = Error + "0086545353773663555223222";
                }
                return Error;
            }
        }
        [TestMethod]
        public void SupplierContactNoExtremeMax()
        {
            clsSuppliers AnSupplier = new clsSuppliers();
            String Error = "";
            string SupplierContactNo = "";
            SupplierContactNo = SupplierContactNo.PadRight(500, 'a');
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, SupplierContactNo);
            Assert.AreNotEqual(Error, "");
        }
    }
}
