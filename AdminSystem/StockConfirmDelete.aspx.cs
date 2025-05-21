using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 AlbumID;
    protected void Page_Load(object sender, EventArgs e)
    {
        AlbumID = Convert.ToInt32(Session["AlbumID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsAlbumCollection AllAlbums = new clsAlbumCollection();
        AllAlbums.ThisAlbum.Find(AlbumID);
        AllAlbums.Delete();
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Write("Le bouton clique bien");
        Response.Redirect("StockList.aspx");
    }
}