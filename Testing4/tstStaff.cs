using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff  aStaff = new clsStaff();
            Assert.IsNotNull(aStaff);
        }
        [TestMethod]
        public void StaffIDOK()
        {
            clsStaff aStaff = new clsStaff();
            Int32 TestData = 1;
            aStaff.StaffID = TestData;
            Assert.AreEqual(aStaff.StaffID, TestData);
        }
        [TestMethod]
        public void StaffNameOK()
        {
            clsStaff aStaff = new clsStaff();
            String TestData = "Zakaria";
            aStaff.StaffName = TestData;
            Assert.AreEqual(aStaff.StaffName, TestData);
        }
        [TestMethod]
        public void StaffEmailOK()
        {
            clsStaff aStaff = new clsStaff();
            String TestData = "ZakariaEmail";
            aStaff.Email = TestData;
            Assert.AreEqual(aStaff.Email, TestData);
        }
        [TestMethod]
        public void StaffPasswordOK()
        {
            clsStaff aStaff = new clsStaff();
            String TestData = "ZakariaPassword";
            aStaff.Password = TestData;
            Assert.AreEqual(aStaff.Password, TestData);
        }
        [TestMethod]
        public void StaffPhoneNumberOK()
        {
            clsStaff aStaff = new clsStaff();
            String TestData = "ZakariaPhoneNumber";
            aStaff.StaffPhoneNumber = TestData;
            Assert.AreEqual(aStaff.StaffPhoneNumber, TestData);
        }
        [TestMethod]
        public void StaffBillingAddressOK()
        {
            clsStaff aStaff = new clsStaff();
            String TestData = "ZakariaAddress";
            aStaff.StaffBillingAddress = TestData;
            Assert.AreEqual(aStaff.StaffBillingAddress, TestData);
        }
        [TestMethod]
        public void StaffStatusOK()
        {
            clsStaff aStaff = new clsStaff();
            String TestData = "Active";
            aStaff.StaffStatus = TestData;
            Assert.AreEqual(aStaff.StaffStatus, TestData);
        }
        [TestMethod]
        public void FindStaffMethodOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean found = false;
            string Email = "TestEmailAddress";
            string Password = "PasswordTest";
            found = aStaff.FindStaff(Email, Password);
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestEmailPasswordFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            string Email = "TestEmailAddress";
            string Password = "PasswordTest";
            found = aStaff.FindStaff(Email, Password);
            if (aStaff.Email !=  Email && aStaff.Password != Password)  { OK = false; }
            Assert.IsTrue(OK);
        }
    }
}
