using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && Request.QueryString["CostumerID"] != null)
        {
            int id;
            if (int.TryParse(Request.QueryString["CostumerID"], out id))
            {
                clsCustomer c = new clsCustomer();
                if (c.Find(id))
                {
                    lblCostumerID.Text = c.CustomerID.ToString();
                    lblCostumerName.Text = c.CustomerName;
                    lblEmail.Text = c.EmailAddress;
                    lblBilling.Text = c.BillingAddress;
                    lblPhone.Text = c.PhoneNumber;
                    lblGender.Text = c.Gender;
                    lblPassword.Text = c.Password;
                    lblActive.Text = c.Active ? "Yes" : "No";
                }
                else
                {
                    lblMessage.Text = "No record found for that Costumer ID.";
                }
            }
            else
            {
                lblMessage.Text = "Invalid Costumer ID.";
            }
        }
    }
}