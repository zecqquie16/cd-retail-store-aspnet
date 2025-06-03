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
        if (Session["StaffID"] != null && Session["StaffName"] != null)
        {
            btnLogOut.Visible = true;
            lblUser.Text = "Logged in as: " + Session["StaffName"] + " (ID: " + Session["StaffID"] + "), Staff-level access granted. ";
        }
        AlbumID = Convert.ToInt32(Session["AlbumID"]);
        clsAlbumCollection Album = new clsAlbumCollection();
        Album.ThisAlbum.Find(AlbumID);
        clsArtistCollection ArtistCollection = new clsArtistCollection();
        int artistID = Album.ThisAlbum.AlbumArtistID;
        ArtistCollection.ThisArtist.Find(artistID);
        Session["ArtistID"] = artistID;
        hlArtistName.Text = ArtistCollection.ThisArtist.ArtistName;
        hlArtistName.NavigateUrl = "StockArtistList.aspx";
        if (!IsPostBack)
        {
            // Step 1: Get all albums with the same title
            string albumTitle = Album.ThisAlbum.AlbumTitle;
            clsAlbumCollection editions = new clsAlbumCollection();
            editions.ReportByTitle(albumTitle);  

            // Step 2: Bind dropdown list
            ddlEdition.DataSource = editions.AlbumList;
            ddlEdition.DataTextField = "AlbumEdition";
            ddlEdition.DataValueField = "AlbumID";
            ddlEdition.DataBind();

            // Step 3: Select the current edition in dropdown
            ddlEdition.SelectedValue = AlbumID.ToString();
        }
        lblTitle.Text = Album.ThisAlbum.AlbumTitle;
        lblReleaseDate0.Text = Album.ThisAlbum.AlbumDate.ToString();
        lblGenre.Text = Album.ThisAlbum.AlbumGenre;
        lblPrice.Text = Album.ThisAlbum.AlbumPrice.ToString() + "$";
        lblDescription.Text = Album.ThisAlbum.AlbumDescription;
        imgCover.ImageUrl = Album.ThisAlbum.AlbumCover;
        


    }

    protected void btnEntryToMain_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void ddlEdition_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedAlbumID = Convert.ToInt32(ddlEdition.SelectedValue);
        Session["AlbumID"] = selectedAlbumID;
        Response.Redirect("StockNew.aspx");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("AuthentificationDataEntry.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("AuthentificationDataEntry.aspx");
    }

    protected void btnStaffGateway_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Session["StaffID"] = null;
        Session["IsStaff"] = false;
        Session["StaffName"] = null;
        Response.Redirect("StockNew.aspx");
    }

    protected void btnBuy_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderDataEntru.aspx");
    }
}