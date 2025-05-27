using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstcostumer
    {
        [TestMethod]
        public void InstanceOk()
        {
            // create an instance of the class we want to create
            clscostumer ACostumer = new clscostumer();
            // test to see it exists
            Assert.IsNotNull(ACostumer);
        }
    }
}
