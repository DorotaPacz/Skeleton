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
            Int32 TestData = 1;
            //assign the data to the property
            AnSuppliers.SuppliersId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.SuppliersId, TestData);
        }
        [TestMethod]
        public void SupplierContactNoPropertyOk()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            Int64 TestData = 07099772331;
            AnSuppliers.SupplierContactNo = TestData;
            Assert.AreEqual(AnSuppliers.SupplierContactNo, TestData);

        }
        [TestMethod]
        public void SupplierNameOK()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            string TestData = "MIK Rescue";
            AnSuppliers.SupplierName = TestData;
            Assert.AreEqual(AnSuppliers.SupplierName, TestData);
        }
        [TestMethod]
        public void SupplierEmailOK()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            string TestData = "supplier@mail.com";
            AnSuppliers.SupplierEmail = TestData;
            Assert.AreEqual(AnSuppliers.SupplierEmail, TestData);

        }
        [TestMethod]
        public void SupplierAddressOK()
        {
            clsSuppliers AnSuppliers = new clsSuppliers();
            string TestData = "2 manny road nigeria";
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
            Int32 SuppliersId = 21;
            //invoke the method
            Found = AnSuppliers.Find(SuppliersId);
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
            Int32 SuppliersId = 21;
            //invoke the method
            Found = AnSuppliers.Find(SuppliersId);
            //check the address no
            if (AnSuppliers.SuppliersId != 21)
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
            Int32 SupplierId = 21;
            Found = AnSuppliers.Find(SupplierId);
            if (AnSuppliers.SupplierName != "Manny LTD")
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
            Int32 SupplierId = 21;
            Found = AnSuppliers.Find(SupplierId);
            if (AnSuppliers.SupplierEmail != "supplier@mail.com")
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
            Int32 SupplierId = 21;
            Found = AnSuppliers.Find(SupplierId);
            if (AnSuppliers.SupplierAddress != "2 manny road nigeria")
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
            Int32 SupplierId = 21;
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
            Int32 SupplierId = 21;
            Found = AnSuppliers.Find(SupplierId);
            if (AnSuppliers.SupplierAvailable != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        }
}
