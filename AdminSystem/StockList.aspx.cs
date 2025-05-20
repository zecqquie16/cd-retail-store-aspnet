
using System;
using System.Collections.Generic;
using System.Linq;
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
        Response.Write("Nb d'albums : " + Albums.Count);
        lstAlbumList.DataSource = Albums.AlbumList;
        lstAlbumList.DataValueField = "AlbumID";
        lstAlbumList.DataTextField = "AlbumTitle";
        lstAlbumList.DataBind();

    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["AlbumID"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }
}