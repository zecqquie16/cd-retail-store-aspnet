using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsAlbum anAlbum = new clsAlbum();
      
        string AlbumTitle = txtAlbumTitle.Text;
        
        string AlbumID = (txtAlbumID.Text);

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
            anAlbum.AlbumTitle = AlbumTitle;
            anAlbum.AlbumGenre = AlbumGenre;
            anAlbum.AlbumDescription = AlbumDescription;
            anAlbum.AlbumEdition = AlbumEdition;
            anAlbum.AlbumDate = Convert.ToDateTime(AlbumDate);
            anAlbum.AlbumPrice = Convert.ToDecimal(AlbumPrice);
            anAlbum.AlbumArtistID = Convert.ToInt32(AlbumArtistID);
            anAlbum.AlbumID = Convert.ToInt32(AlbumID);
            Session["anAlbum"] = anAlbum;
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


    }

    protected void txtAlbumEdition_TextChanged(object sender, EventArgs e)
    {

    }
}