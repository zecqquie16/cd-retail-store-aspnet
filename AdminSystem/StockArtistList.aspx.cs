using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayArtistAlbums();
        }
        if (Session["StaffID"] != null && Session["StaffName"] != null)
        {
            btnLogOut.Visible = true;
            btnAdd.Visible = true;
            btnEdit.Visible = true;
            lblStaffFunctionalities.Visible = true;
            lblUser.Text = "Logged in as: " + Session["StaffName"] + " (ID: " + Session["StaffID"] + "), Staff-level access granted. ";
        }
        Int32 ArtistID;
        ArtistID = Convert.ToInt32(Session["ArtistID"]);
        clsArtistCollection anArtist = new clsArtistCollection();
        anArtist.ThisArtist.Find(ArtistID);
        lblBiographyTitle.Text = lblBiographyTitle.Text + anArtist.ThisArtist.ArtistName + ":";
        lblArtistName.Text = anArtist.ThisArtist.ArtistName;
        lblGenree.Text = anArtist.ThisArtist.ArtistGenre;
        lblNationalityy.Text = anArtist.ThisArtist.ArtistNationality;
        lblBiography.Text = anArtist.ThisArtist.ArtistBiography;
        ImageArtist.ImageUrl = anArtist.ThisArtist.ArtistImage;
        if (anArtist.ThisArtist.ArtistIsSolo == true)
        { lblIsSoloo.Text = "Yes"; }
        else
        {
            lblIsSoloo.Text = "No";
        }
    }
    void DisplayArtistAlbums()
    {
        clsDataConnection DB = new clsDataConnection();

        clsAlbumCollection Albums = new clsAlbumCollection();
        Int32 ArtistID;
        ArtistID = Convert.ToInt32(Session["ArtistID"]);
        DB.AddParameter("@ArtistID", ArtistID);




        lstArtistAlbum.DataSource = DB.ExecuteDataTable("sproc_tblArtistAlbum_FindArtistAlbums");

        lstArtistAlbum.DataValueField = "AlbumID";
        lstArtistAlbum.DataTextField = "AlbumDisplay";
        lstArtistAlbum.DataBind();



    }

    protected void btnEntryToMain_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
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

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        Int32 AlbumID;
        if (lstArtistAlbum.SelectedIndex != -1)
        {

            AlbumID = Convert.ToInt32(lstArtistAlbum.SelectedValue);
            Session["AlbumID"] = AlbumID;
            Response.Redirect("StockNew.aspx");
        }
    }

    protected void lstArtistAlbum_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Second layer of security to make sure only logged in staff can add
        if (Session["IsStaff"] != null && (bool)Session["IsStaff"] == true)
        {
            Session["ArtistID"] = -1;
            Response.Redirect("StockArtistDataEntry.aspx");
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockArtistDataEntry.aspx");
    }
}