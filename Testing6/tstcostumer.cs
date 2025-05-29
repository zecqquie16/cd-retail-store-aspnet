using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstCustomer
    {
        // Test to ensure that an instance of clscostumer can be created
        [TestMethod]
        public void InstanceOK()
        {
            clscostumer ACustomer = new clscostumer();
            Assert.IsNotNull(ACustomer);
        }

        // Test the CustomerID property
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clscostumer ACustomer = new clscostumer();
            Int64 TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        // Test the CustomerName property
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            clscostumer ACustomer = new clscostumer();
            string TestData = "John Smith";
            ACustomer.CustomerName = TestData;
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        // Test the EmailAddress property
        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            clscostumer ACustomer = new clscostumer();
            string TestData = "john@example.com";
            ACustomer.EmailAddress = TestData;
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
        }

        // Test the BillingAddress property
        [TestMethod]
        public void BillingAddressPropertyOK()
        {
            clscostumer ACustomer = new clscostumer();
            string TestData = "123 Main Street";
            ACustomer.BillingAddress = TestData;
            Assert.AreEqual(ACustomer.BillingAddress, TestData);
        }

        // Test the PhoneNumber property
        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            clscostumer ACustomer = new clscostumer();
            string TestData = "0123456789";
            ACustomer.PhoneNumber = TestData;
            Assert.AreEqual(ACustomer.PhoneNumber, TestData);
        }

        // Test the Gender property
        [TestMethod]
        public void GenderPropertyOK()
        {
            clscostumer ACustomer = new clscostumer();
            string TestData = "Male";
            ACustomer.Gender = TestData;
            Assert.AreEqual(ACustomer.Gender, TestData);
        }

        // Test the Password property
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clscostumer ACustomer = new clscostumer();
            string TestData = "pass123456";
            ACustomer.Password = TestData;
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        // Test the Active property (boolean)
        [TestMethod]
        public void ActivePropertyOK()
        {
            clscostumer ACustomer = new clscostumer();
            bool TestData = true;
            ACustomer.Active = TestData;
            Assert.AreEqual(ACustomer.Active, TestData);
        }
    }
}
