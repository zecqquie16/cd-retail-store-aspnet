using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

public partial class _1_DataEntry : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Optional initialization logic
    }

    protected void txtBillingAddress_TextChanged(object sender, EventArgs e)
    {
        // Handle the text change event here
        string billingAddress = txtBillingAddress.Text;

        // Example: You could validate or log the input
        // For now, just leave it empty or add your own code
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        string customerName = txtCustomerName.Text;
        string phone = txtPhone.Text;
        string email = txtEmail.Text;
        string billingAddress = txtBillingAddress.Text;
        string password = txtPassword.Text;
        bool active = chkActive.Checked;

        // Optional: You can add gender input too if you have the control in UI
        string gender = "Not Specified"; // or use a DropDown if present

        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Table_Costumer ([Customer Name], [Phone number], [Email address], [Billing address], [Password:], [Active], [Gender]) " +
                           "VALUES (@CustomerName, @Phone, @Email, @BillingAddress, @Password, @Active, @Gender)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@BillingAddress", billingAddress);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Active", active);
                cmd.Parameters.AddWithValue("@Gender", gender); // Adjust if using gender field

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Logic for Cancel button click
    }
}
