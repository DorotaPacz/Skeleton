using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsOrderLine anOrderLine = new clsOrderLine();
            // test to see that it exists
            Assert.IsNotNull(anOrderLine);
        }
    }
}
