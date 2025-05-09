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
      
        anAlbum.AlbumTitle = txtAlbumTitle.Text;
        
        anAlbum.AlbumID = Convert.ToInt32(txtAlbumID.Text);

        anAlbum.AlbumArtistID = Convert.ToInt32(txtAlbumArtistID.Text);
        
        anAlbum.AlbumGenre = txtAlbumGenre.Text;
        
        anAlbum.AlbumDescription = txtAlbumDescription.Text;
        
        anAlbum.AlbumDate = Convert.ToDateTime(txtAlbumReleaseDate.Text);
        
        anAlbum.AlbumPrice = Convert.ToDecimal( txtAlbumPrice.Text);
      
        anAlbum.AlbumEdition = (txtAlbumEdition.Text);
        Session["anAlbum"] = anAlbum;
        Response.Redirect("StockViewer.aspx");
    }
}