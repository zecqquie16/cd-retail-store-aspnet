using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsAlbum  anAlbum = new clsAlbum();
            Assert.IsNotNull( anAlbum);
        }
    }
}
