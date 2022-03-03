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
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff); //AStaff object should not be null.
        }
        [TestMethod]
        public void StaffNameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Cindy Crawford";
            //assign the data to the property
            AStaff.StaffName = TestData; //description assign to test data 
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, TestData); 
        }

        [TestMethod]
        public void IsAdminOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.IsAdmin = TestData; //description assign to test data 
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.IsAdmin, TestData);
        }

        [TestMethod]
        public void DateStartedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateBegin = TestData; //description assign to test data 
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateBegin, TestData);
        }

        [TestMethod]
        public void IdNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.IdNoOK = TestData; //description assign to test data 
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.IdNoOK, TestData);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            double TestData = 1.35;
            //assign the data to the property
            AStaff.Salary = TestData; //description assign to test data 
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Salary, TestData);
        }


    }
}
