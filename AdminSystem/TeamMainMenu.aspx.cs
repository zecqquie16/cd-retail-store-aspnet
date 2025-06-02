using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["StaffID"] != null && Session["StaffName"] != null)
        {
            btnLogOut.Visible = true;
            lblUser.Text = "Logged in as: " + Session["StaffName"] + " (ID: " + Session["StaffID"] + "), Staff-level access granted. ";
        }
    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void btnAuthentication_Click(object sender, EventArgs e)
    {
        Response.Redirect("AuthentificationDataEntry.aspx");
    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Session["StaffID"] = null;
        Session["IsStaff"] = false;
        Session["StaffName"] = null;
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnUserRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("AuthentificationDataEntry.aspx");
    }
}