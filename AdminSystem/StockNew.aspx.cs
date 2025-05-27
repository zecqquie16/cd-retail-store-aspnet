using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_Nouveau : System.Web.UI.Page
{
    Int32 AlbumID;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        AlbumID = Convert.ToInt32(Session["AlbumID"]);
        clsAlbumCollection Album = new clsAlbumCollection();
        Album.ThisAlbum.Find(AlbumID);
        lblTitle.Text = Album.ThisAlbum.AlbumTitle;
        lblReleaseDate0.Text = Album.ThisAlbum.AlbumDate.ToString();
        lblGenre.Text = Album.ThisAlbum.AlbumGenre;
        lblPrice.Text = Album.ThisAlbum.AlbumPrice.ToString() + "$";
        lblDescription.Text = Album.ThisAlbum.AlbumDescription;


    }

    protected void btnEntryToMain_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}