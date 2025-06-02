
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
        //Displays staff member's name and ID 
        if (Session["StaffID"] != null && Session["StaffName"] != null)
        {
            btnLogOut.Visible = true;
            lblUser.Text = "Logged in as: " + Session["StaffName"] + " (ID: " + Session["StaffID"] + "), Staff-level access granted. ";
        }
    }
    void DisplayAlbums()
    {
        

        clsAlbumCollection Albums = new clsAlbumCollection();
        
       
        if (Albums.Count ==0 ) { lblError.Text = lblError.Text + " There are no album records available at the moment! /"; }
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
        if (Session["IsStaff"] != null && (bool)Session["IsStaff"] == true)
        {
            Session["AlbumID"] = -1;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text =  " You must be a staff member to perform this action! ";
        }
}

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 AlbumID;
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
            lblError.Text =  " You must be a staff member to perform this action!";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 AlbumID;
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
            lblError.Text =  " You must be a staff member to perform this action!";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsAlbumCollection allAlbums = new clsAlbumCollection();
        allAlbums.ReportByTitle(txtFilter.Text);
        lstAlbumList.DataSource = allAlbums.AlbumList;
        lstAlbumList.DataTextField = "AlbumTitle";
        lstAlbumList.DataValueField = "AlbumID";
        lstAlbumList.DataBind();
        if (allAlbums.Count == 0)
        {
            lblError.Text = "No album available match your title";
        }
    }

        protected void btnClear_Click(object sender, EventArgs e)
    {
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
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void txtFilter_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Session["StaffID"] = null;
        Session["IsStaff"] = false;
        Session["StaffName"] = null;
        Response.Redirect("StockList.aspx");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("AuthentificationDataEntry.aspx");
    }

    protected void btnUserLog_Click(object sender, EventArgs e)
    {
        Response.Redirect("AuthentificationViewer.aspx");
    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffDataEntry.aspx");
    }
}