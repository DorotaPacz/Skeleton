using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
	[TestClass]
	public class tstStock
	{
		[TestMethod]
		public void InstanceOK()
		{
			//create and instance of the class we want to create
			clsStock AnStock = new clsStock();
			//test to see that it exists
			Assert.IsNotNull(AnStock);
		}
	}
}
