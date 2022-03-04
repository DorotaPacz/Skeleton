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
            string TestData = "22 madden street Leicester";
            AnSuppliers.SupplierAddress = TestData;
            Assert.AreEqual(AnSuppliers.SupplierAddress, TestData);
        }
    }
}
