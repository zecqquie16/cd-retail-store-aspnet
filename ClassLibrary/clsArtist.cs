namespace ClassLibrary
{
    public class clsArtist
    {
        public int ArtistLabelID { get; set; } //foreign key
        public string ArtistBiography { get; set; }
        public string ArtistNationality { get; set; }
        public string ArtistGenre { get; set; }
        public bool ArtistSolo { get; set; }
        public string ArtistName { get; set; }
        public int ArtistID { get; set; } //primary key 
    }
}