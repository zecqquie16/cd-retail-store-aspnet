using System;

namespace ClassLibrary
{
    public class clsAlbum
    {
        public string AlbumTitle { get; set; }
        public int AlbumID { get; set; } //primary key
        public string AlbumGenre { get; set; }
        public int AlbumArtistID { get; set; } //foreign key
        public decimal AlbumPrice { get; set; }
        public string AlbumDescription { get; set; }
        public string AlbumEdition { get; set; }
        public DateTime AlbumDate { get; set; }
    }
}