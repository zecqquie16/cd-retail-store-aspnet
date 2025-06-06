using System;
using ClassLibrary;

public partial class AuthentificationList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCostumerList();
        }
    }

    private void LoadCostumerList()
    {
        clsCostumerCollection costumers = new clsCostumerCollection();
        gvCostumers.DataSource = costumers.CostumerList;
        gvCostumers.DataBind();
    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Session["CostumerID"] = null;
        Response.Redirect("AuthentificationDataEntry.aspx");
    }
}

internal class clsCostumerCollection
{
    internal object CostumerList;

    public clsCostumerCollection()
    {
    }
}