using System;
using System.Web.UI;

public partial class AuthentificationDataEntry : Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer customer = new clsCustomer();

        try
        {
            customer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        }
        catch
        {
            // Handle conversion errors or provide default ID
            customer.CustomerID = 0;
        }

        customer.CustomerName = txtCustomerName.Text;
        customer.EmailAddress = txtEmailAddress.Text;
        customer.BillingAddress = txtBillingAddress.Text;
        customer.PhoneNumber = txtPhoneNumber.Text;
        customer.Gender = txtGender.Text;

        clsCustomerCollection collection = new clsCustomerCollection();
        collection.Add(customer);  // or collection.Update(customer); if updating

        // Redirect after adding
        Response.Redirect("AuthentificationViewer.aspx");
    }
}