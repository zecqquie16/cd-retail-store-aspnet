using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    
    Int32 AlbumID;
    protected void Page_Load(object sender, EventArgs e)
    {
        AlbumID = Convert.ToInt32(Session["AlbumID"]);
        if (IsPostBack == false)
        {
            if (AlbumID != -1)
            {
                DisplayAlbum();
            }
        }
    }
    void DisplayAlbum()
    {
        clsAlbumCollection Album = new clsAlbumCollection();
        Album.ThisAlbum.Find(AlbumID);
        txtAlbumID.Text = Album.ThisAlbum.AlbumID.ToString();
        txtAlbumTitle.Text = Album.ThisAlbum.AlbumTitle.ToString();
        txtAlbumGenre.Text = Album.ThisAlbum.AlbumGenre.ToString();
        txtAlbumReleaseDate.Text = Album.ThisAlbum.AlbumDate.ToString();
        txtAlbumEdition.Text = Album.ThisAlbum.AlbumEdition.ToString();
        txtAlbumArtistID.Text = Album.ThisAlbum.AlbumArtistID.ToString();
        txtAlbumPrice.Text = Album.ThisAlbum.AlbumPrice.ToString();
        txtAlbumDescription.Text = Album.ThisAlbum.AlbumDescription.ToString();

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsAlbum anAlbum = new clsAlbum();
      
        string AlbumTitle = txtAlbumTitle.Text;
        
        

        string AlbumArtistID = (txtAlbumArtistID.Text);
        
        string AlbumGenre = txtAlbumGenre.Text;
        
        string AlbumDescription = txtAlbumDescription.Text;
        
        string AlbumDate =(txtAlbumReleaseDate.Text);
        
        string AlbumPrice =( txtAlbumPrice.Text);

        string AlbumEdition = ( txtAlbumEdition.Text);

        string Error = "";

        Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
        if (Error == "") 
        {   

            anAlbum.AlbumID = AlbumID;
            anAlbum.AlbumTitle = AlbumTitle;
            anAlbum.AlbumGenre = AlbumGenre;
            anAlbum.AlbumDescription = AlbumDescription;
            anAlbum.AlbumEdition = AlbumEdition;
            anAlbum.AlbumDate = Convert.ToDateTime(AlbumDate);
            anAlbum.AlbumPrice = Convert.ToDecimal(AlbumPrice);
            anAlbum.AlbumArtistID = Convert.ToInt32(AlbumArtistID);
           
            clsAlbumCollection AlbumList = new clsAlbumCollection();
            Response.Write(AlbumID);
            if (anAlbum.AlbumID == -1)
                {
                AlbumList.ThisAlbum = anAlbum;
                AlbumList.Add();
                 }
            else
            {
                AlbumList.ThisAlbum.Find(anAlbum.AlbumID);
                AlbumList.ThisAlbum = anAlbum;
                AlbumList.Update();

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
        clsAlbum anAlbum = new clsAlbum();
        Int32 AlbumID;
        Boolean found = false;
        
        if (txtAlbumID.Text.Length == 0) { lblError.Text = "You need to enter a number in AlbumID field in order to find a record"; }
        else if (!int.TryParse(txtAlbumID.Text, out AlbumID))
        {
            lblError.Text = "AlbumID must be a number!";
        }
        else
        {
            AlbumID = Convert.ToInt32(txtAlbumID.Text);
            found = anAlbum.Find(AlbumID);
            if (found)
            {
                txtAlbumTitle.Text = anAlbum.AlbumTitle;
                txtAlbumGenre.Text = anAlbum.AlbumGenre;
                txtAlbumReleaseDate.Text = Convert.ToString(anAlbum.AlbumDate);
                txtAlbumDescription.Text = anAlbum.AlbumDescription;
                txtAlbumEdition.Text = anAlbum.AlbumEdition;
                txtAlbumArtistID.Text = Convert.ToString(anAlbum.AlbumArtistID);
                txtAlbumPrice.Text = Convert.ToString((int)anAlbum.AlbumPrice);

            }
            else { lblError.Text = " There is no recrod with such AlbumID "; }
        }

        
    }
}