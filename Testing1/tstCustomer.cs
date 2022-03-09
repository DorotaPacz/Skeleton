using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstancOK()
        {
            //To create an instance of the class 
            clsCustomer Customer = new clsCustomer();
            //Test to see that it exists
            Assert.IsNotNull(Customer);

        }
    }
}
