using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    Int32 ArtistID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ArtistID = Convert.ToInt32(Session["ArtistID"]);
        if (IsPostBack == false)
        {
            if (ArtistID != -1)
            {
                DisplayArtist();
            }
        }
    }
    void DisplayArtist()
    {
        clsArtistCollection Artist = new clsArtistCollection();
        Artist.ThisArtist.Find(ArtistID);
        txtArtistID.Text = Artist.ThisArtist.ArtistID.ToString();
        txtArtistName.Text = Artist.ThisArtist.ArtistName.ToString();
        txtArtistGenre.Text = Artist.ThisArtist.ArtistGenre.ToString();
        txtArtistNationality.Text = Artist.ThisArtist.ArtistNationality.ToString();

        checkIsSolo.Checked = Artist.ThisArtist.ArtistIsSolo;
        txtArtistImagePath.Text = Artist.ThisArtist.ArtistImage.ToString();
        txtArtistBiography.Text = Artist.ThisArtist.ArtistBiography.ToString();

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsArtist anArtist = new clsArtist();
        string ArtistID = txtArtistID.Text;
        string ArtistName = txtArtistName.Text;
        string ArtistNationality = txtArtistNationality.Text;
        string ArtistIsSolo = Convert.ToString(checkIsSolo.Checked);
        string ArtistGenre = txtArtistGenre.Text;
        string ArtistBiography = txtArtistBiography.Text;
        string ArtistImage = (txtArtistImagePath.Text);

        string Error = "";

        Error = anArtist.Valid(ArtistName, ArtistGenre, ArtistBiography, ArtistNationality, ArtistIsSolo, ArtistImage);
        if (Error == "")
        {

            
            anArtist.ArtistName = ArtistName;
            anArtist.ArtistGenre = ArtistGenre;
            anArtist.ArtistBiography = ArtistBiography;
            anArtist.ArtistNationality = ArtistNationality;
            anArtist.ArtistImage = ArtistImage;
            anArtist.ArtistIsSolo = Convert.ToBoolean(ArtistIsSolo);
            clsArtistCollection ArtistList = new clsArtistCollection();
            Response.Write(ArtistID);
            if (anArtist.ArtistID == -1)
            {
                ArtistList.ThisArtist = anArtist;
                ArtistList.Add();
            }
            else
            {
                ArtistList.ThisArtist.Find(anArtist.ArtistID);
                ArtistList.ThisArtist = anArtist;
                ArtistList.Update();

            }

            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


    }

    protected void txtAlbumEdition_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsArtist anArtist = new clsArtist();
        Int32 ArtistID;
        Boolean found = false;

        if (txtArtistID.Text.Length == 0) { lblError.Text = "You need to enter a number in ArtistID field in order to find a record"; }
        else if (!int.TryParse(txtArtistID.Text, out ArtistID))
        {
            lblError.Text = "ArtistID must be a number!";
        }
        else
        {
            ArtistID = Convert.ToInt32(txtArtistID.Text);
            found = anArtist.Find(ArtistID);
            if (found)
            {
                txtArtistID.Text = anArtist.ArtistID.ToString();
                txtArtistName.Text = anArtist.ArtistName.ToString();
                txtArtistGenre.Text = anArtist.ArtistGenre.ToString();
                txtArtistNationality.Text = anArtist.ArtistNationality.ToString();

                checkIsSolo.Checked = anArtist.ArtistIsSolo;
                txtArtistImagePath.Text = anArtist.ArtistImage.ToString();
                txtArtistBiography.Text = anArtist.ArtistBiography.ToString();

            }
            else { lblError.Text = " There is no recrod with such ArtistID "; }
        }


    }



    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockArtistList.aspx");
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
