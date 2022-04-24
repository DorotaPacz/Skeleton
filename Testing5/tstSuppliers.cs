using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstSuppliers
    {
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
            Int64 TestData = 77656512;
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
            string TestData = "6 manny land";
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

     }
}
