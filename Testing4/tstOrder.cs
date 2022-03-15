using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            // test to see that it exists
            Assert.IsNotNull(anOrder);
        }
    }
}
