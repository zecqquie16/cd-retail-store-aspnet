
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
        Session["AlbumID"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 AlbumID;
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

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 AlbumID;
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
}