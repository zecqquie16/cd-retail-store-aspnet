using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsAlbum anAlbum = new clsAlbum();
        anAlbum = (clsAlbum)Session["anAlbum"];
        Response.Write("Titre: "+  anAlbum.AlbumTitle + "<br/><br/>");
        Response.Write("ID de l'album:" + anAlbum.AlbumID + "<br/><br/>");
        Response.Write("Genre musical de l'album: " + anAlbum.AlbumGenre + "<br/><br/>");
        Response.Write("Description de l'album: " + anAlbum.AlbumDescription + "<br/><br/>");
        Response.Write("Date de sortie de l'album: " + anAlbum.AlbumDate + "<br/><br/>");
        Response.Write("ID de l'artiste: " + anAlbum.AlbumArtistID + "<br/><br/>");
        Response.Write("Edition de l'album: " + anAlbum.AlbumEdition + "<br/><br/>");
        Response.Write("Prix unitaire de l'album: " + anAlbum.AlbumPrice + "<br/><br/>");
    }
}