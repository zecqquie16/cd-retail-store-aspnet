using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private int mStaffID;
        private string mStaffName;
        private string mEmail;
        private string mStaffPhoneNumber;
        private string mPassword;
        private string mStaffBillingAddress;
        private string mStaffStatus;
        public int StaffID
        { 
            get  {return mStaffID; } set {  mStaffID = value; }

        }
        public string StaffName
        {
            get { return mStaffName; }
            set { mStaffName = value; }

        }
        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }

        }
        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }

        }
        public string StaffPhoneNumber
        {
            get { return mStaffPhoneNumber; }
            set { mStaffPhoneNumber = value; }

        }
        public string StaffBillingAddress
        {
            get { return mStaffBillingAddress; }
            set { mStaffBillingAddress = value; }

        }
        public string StaffStatus
        {
            get { return mStaffStatus; }
            set { mStaffStatus = value; }

        }
       

        public bool FindStaff(string Email, string Password)
        {
           clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Email", Email);
            DB.AddParameter("@Password", Password);



            DB.Execute("sproc_tblStaff_FindEmailPassword");
            System.Diagnostics.Debug.WriteLine("Nombre de lignes après exécution : " + DB.Count);

            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mStaffPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mStaffBillingAddress = Convert.ToString(DB.DataTable.Rows[0]["BillingAddress"]);
                mStaffStatus = Convert.ToString(DB.DataTable.Rows[0]["Status"]);

                return true;
            }


            else
            {
                Console.WriteLine("Chaîne de connexion utilisée : " + DB.ConnectionString);

                return false;
            }
        }
    }
}