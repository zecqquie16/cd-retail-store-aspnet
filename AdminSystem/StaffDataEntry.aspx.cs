using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();
        string Email = txtEmail.Text;
        string Password = txtPassword.Text;
        Boolean found = false;
        Email = Convert.ToString(txtEmail.Text);
        Password = Convert.ToString(txtPassword.Text); 
        found = aStaff.FindStaff(Email, Password);
        if (txtEmail.Text=="") { lblError.Text = "Enter an email!/ "; }
        else if (txtPassword.Text == "") { lblError.Text = "Enter a password!/ "; }
        else if (found) 
        { 
            
            //keeps staff ID, Name and that it is a staff for use in other pages
            Session["StaffID"] = aStaff.StaffID;
            Session["StaffName"] = aStaff.StaffName;
            Session["IsStaff"] = true;
            Response.Redirect("StockList.aspx");
        }
        else if (!found){ lblError.Text = "Login details are incorrect. Try again!/  "; }


    }
}