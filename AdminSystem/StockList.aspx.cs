using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayAlbums();
        }
        //Displays staff member's name and ID and makes visible buttons for staff only
        if (Session["StaffID"] != null && Session["StaffName"] != null)

        {
            lblStaffFunctionality.Visible = true;
            btnAdd.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnLogOut.Visible = true;
            lblUser.Text = "Logged in as: " + Session["StaffName"] + " (ID: " + Session["StaffID"] + "), Staff-level access granted. ";
        }
    }
    void DisplayAlbums()
    {


        clsAlbumCollection Albums = new clsAlbumCollection();


        if (Albums.Count == 0) { lblError.Text = lblError.Text + " There are no album records available at the moment! /"; }
        else
        {

            lstAlbumList.DataSource = Albums.AlbumList;
            lstAlbumList.DataValueField = "AlbumID";
            lstAlbumList.DataTextField = "AlbumTitle";
            lstAlbumList.DataBind();
        }


    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Second layer of security to make sure only logged in staff can add
        if (Session["IsStaff"] != null && (bool)Session["IsStaff"] == true)
        {
            Session["AlbumID"] = -1;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = " You must be a staff member to perform this action! ";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 AlbumID;
        //Second layer of security to make sure only logged in staff can edit
        if (Session["IsStaff"] != null && (bool)Session["IsStaff"] == true)
        {
            if (lstAlbumList.SelectedIndex != -1)
            {

                AlbumID = Convert.ToInt32(lstAlbumList.SelectedValue);
                Session["AlbumID"] = AlbumID;
                Response.Redirect("StockDataEntry.aspx");
            }
            else
            {
                lblError.Text = "Please select a record you want to edit ! ";
            }
        }
        else
        {
            lblError.Text = " You must be a staff member to perform this action!";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 AlbumID;
        //Second layer of security to make sure only logged in staff can delete
        if (Session["IsStaff"] != null && (bool)Session["IsStaff"] == true)
        {
            if (lstAlbumList.SelectedIndex != -1)
            {
                AlbumID = Convert.ToInt32(lstAlbumList.SelectedValue);
                Session["AlbumID"] = AlbumID;
                Response.Redirect("StockConfirmDelete.aspx");
            }
            else
            {
                lblError.Text = " Please select the record you want to delete";
            }
        }
        else
        {
            lblError.Text = " You must be a staff member to perform this action!";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    //Code for apply filter button using ReportByTitle method in clsAlbumCollection
    {
        clsAlbumCollection allAlbums = new clsAlbumCollection();
        allAlbums.ReportByTitle(txtFilter.Text);
        lstAlbumList.DataSource = allAlbums.AlbumList;
        lstAlbumList.DataTextField = "AlbumTitle";
        lstAlbumList.DataValueField = "AlbumID";
        lstAlbumList.DataBind();
        //error message displayed to inform users in case of empty album list.
        if (allAlbums.Count == 0)
        {
            lblError.Text = "No album available match your title";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //Code for clear filter button which displays original album list
        clsAlbumCollection allAlbums = new clsAlbumCollection();
        allAlbums.ReportByTitle("");
        txtFilter.Text = "";
        lstAlbumList.DataSource = allAlbums.AlbumList;
        lstAlbumList.DataTextField = "AlbumTitle";
        lstAlbumList.DataValueField = "AlbumID";
        lstAlbumList.DataBind();
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        //button that allows user to get more information regarding a specific album and serves as last page of stock before order system.
        Int32 AlbumID;
        if (lstAlbumList.SelectedIndex != -1)
        {

            AlbumID = Convert.ToInt32(lstAlbumList.SelectedValue);
            Session["AlbumID"] = AlbumID;
            Response.Redirect("StockNew.aspx");
        }
        else
        {
            lblError.Text = "Please select a record you want to display ";
        }
    }

    protected void btnEntryToMain_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");//shortcut button to main menu to facilitate navigation through pages.
    }

    protected void txtFilter_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {//button that cancels staff level permissions and logs out staff.
        Session["StaffID"] = null;
        Session["IsStaff"] = false;
        Session["StaffName"] = null;
        //redirecting to same page before logging out
        Response.Redirect("StockList.aspx");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //shortcut button to customer registration page to facilitate navigation through pages.
        Response.Redirect("AuthentificationDataEntry.aspx");
    }

    protected void btnUserLog_Click(object sender, EventArgs e)
    {
        //shortcut button to customer login page to facilitate navigation through pages.
        Response.Redirect("AuthentificationViewer.aspx");
    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {//shortcut button to staff login page to facilitate navigation through pages.
        Response.Redirect("StaffDataEntry.aspx");
    }
}
