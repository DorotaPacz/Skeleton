using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstStaff
    {
       
        
            //good test data
            string StaffName = "Amy Zing";
            string StaffDateStart = DateTime.Now.Date.ToString();
            string StaffSalary = "£45678.50";

            [TestMethod]
            public void InstanceDBOK()
            {
                //create an instance of the class we want to create
                clsDataConnection ADataConnection = new clsDataConnection();
                Assert.IsNotNull(ADataConnection); //ADataConnection object should not be null.
            }

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

            [TestMethod]
            public void FindMethodOK()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //create boolean variable to store the results of the validation
                Boolean Found = false;
                //create test data to use with the method
                Int32 StaffIdNo = 10;
                //invoke the method
                Found = AStaff.Find(StaffIdNo);
                //test to see if result is true
                Assert.IsTrue(Found);
            }

            [TestMethod]
            public void TestIdNoFound()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //create boolean variable to store the results of the validation
                Boolean Found = false;
                //create boolean variable to record if data is ok (assume it is)
                Boolean OK = true;
                //create test data to use with the method
                Int32 StaffIdNo = 10;
                //invoke the method
                Found = AStaff.Find(StaffIdNo);
                // check the Id number property
                if (AStaff.IdNoOK != 10)
                {
                    OK = false;
                }
                //test to see if result is true
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestDateStartedFound()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //create boolean variable to store the results of the validation
                Boolean Found = false;
                //create boolean variable to record if data is ok (assume it is)
                Boolean OK = true;
                //create test data to use with the method
                Int32 StaffIdNo = 10;
                //invoke the method
                Found = AStaff.Find(StaffIdNo);
                // check the date property
                if (AStaff.DateBegin != Convert.ToDateTime("05/03/2022"))
                {
                    OK = false;
                }
                //test to see if result is true
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestStaffNameFound()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //create boolean variable to store the results of the validation
                Boolean Found = false;
                //create boolean variable to record if data is ok (assume it is)
                Boolean OK = true;
                //create test data to use with the method
                Int32 StaffIdNo = 10;
                //invoke the method
                Found = AStaff.Find(StaffIdNo);
                // check the date property
                if (AStaff.StaffName != "Amy Zing")
                {
                    OK = false;
                }
                //test to see if result is true
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestSalaryFound()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //create boolean variable to store the results of the validation
                Boolean Found = false;
                //create boolean variable to record if data is ok (assume it is)
                Boolean OK = true;
                //create test data to use with the method
                Int32 StaffIdNo = 10;
                //invoke the method
                Found = AStaff.Find(StaffIdNo);
                // check the date property
                if (AStaff.Salary != Convert.ToDouble("102030"))
                {
                    OK = false;
                }
                //test to see if result is true
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void ValidMethodOK()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //inveke the method 
                Error = AStaff.Valid(StaffName, StaffDateStart, StaffSalary);
                //test to see that result is correct
                Assert.AreEqual(Error, "");

            }

            [TestMethod]

            public void StaffNameMaxPlusOne()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create some test data to pass to the method
                string StaffName = "";
                StaffName = StaffName.PadRight(51, '*');//this should trigger an error
                                                        //invoke the method
                Error = AStaff.Valid(StaffName, StaffDateStart, StaffSalary);
                //test to see that the result is not correct
                Assert.AreNotEqual(Error, "");

            }
            [TestMethod]
            public void StaffNameMinPlusOne()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create some test data to pass to the method
                string StaffName = "ab"; //this should be ok
                                         //invoke the method
                Error = AStaff.Valid(StaffName, StaffDateStart, StaffSalary);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void StaffNameMin()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create some test data to pass to the method
                string StaffName = "a"; //this should be ok
                                        //invoke the method
                Error = AStaff.Valid(StaffName, StaffDateStart, StaffSalary);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffNameMaxMinusOne()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create some test data to pass to the method
                string StaffName = "";
                StaffName = StaffName.PadRight(20, '*');//this should be ok
                                                        //invoke the method
                Error = AStaff.Valid(StaffName, StaffDateStart, StaffSalary);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffNameMax()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create some test data to pass to the method
                string StaffName = "";
                StaffName = StaffName.PadRight(50, '*');//this should be ok
                                                        //invoke the method
                Error = AStaff.Valid(StaffName, StaffDateStart, StaffSalary);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, " ");
            }

            [TestMethod]
            public void StaffNameMid()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                string StaffName = "";
                //create some test data to pass to the method
                StaffName = StaffName.PadRight(25, 'a'); //this should be ok
                                                         //invoke the method
                Error = AStaff.Valid(StaffName, StaffDateStart, StaffSalary);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void NameExtreamMax()
            {
                //create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                string StaffName = "";
                //create some test data to pass to the method
                StaffName = StaffName.PadRight(500, '*'); //this should trigger an error
                                                          //invoke the method
                Error = AStaff.Valid(StaffName, StaffDateStart, StaffSalary);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }

            

        
    }

}

