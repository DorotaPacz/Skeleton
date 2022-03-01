using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff); //AStaff object should not be null.
        }
        [TestMethod]
        public void StaffNameOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Dorota Paczkowska";
            AStaff.StaffName = TestData; //description assign to test data 
            Assert.AreEqual(AStaff.StaffName, TestData); //AStaff object should not be null.
        }

       
    }
}
