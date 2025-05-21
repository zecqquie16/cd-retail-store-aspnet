using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace ClassLibrary
{
    public class clsAlbum
    {
        private int mAlbumID;
        private string mAlbumGenre;
        private string mAlbumTitle;
        private string mAlbumDescription;
        private int mAlbumArtistID;
        private DateTime mAlbumDate;
        private decimal mAlbumPrice;
        private string mAlbumEdition;
        

        public string AlbumTitle
        {
            get
            {
                return mAlbumTitle;
            }
            set
            {
                mAlbumTitle = value;
            }
        }
        public int AlbumID 
        { 
            get
            {
                return mAlbumID;
            }
            set
            {
                mAlbumID = value; 
            }

            } //primary key
        public string AlbumGenre
        {
            get
            {
                return mAlbumGenre;
            }
            set
            {
                mAlbumGenre = value;
            }
        }
        public int AlbumArtistID
        {
            get
            {
                return mAlbumArtistID;
            }
            set
            {
                mAlbumArtistID = value;
            }

        } //foreign key
        public decimal AlbumPrice
        {
            get
            {
                return mAlbumPrice;
            }
            set
            {
                mAlbumPrice = value;
            }

        }
        public string AlbumDescription
        {
            get
            {
                return mAlbumDescription;
            }
            set
            {
                mAlbumDescription = value;
            }
        }
        public string AlbumEdition
        {
            get
            {
                return mAlbumEdition;
            }
            set
            {
                mAlbumEdition = value;
            }
        }
        public DateTime AlbumDate
        {
            get
            {
                return mAlbumDate;
            }
            set
            {
                mAlbumDate = value;
            }

        }

        public bool Find(int AlbumID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("AlbumID",AlbumID);
            


            DB.Execute("sproc_tblAlbum_FilterByAlbumID_test");
            System.Diagnostics.Debug.WriteLine("Nombre de lignes après exécution : " + DB.Count);

            if (DB.Count==1)
            {
                mAlbumID = Convert.ToInt32(DB.DataTable.Rows[0]["AlbumID"]);
                mAlbumGenre = Convert.ToString(DB.DataTable.Rows[0]["Genre"]);
                mAlbumTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mAlbumDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mAlbumArtistID = Convert.ToInt32(DB.DataTable.Rows[0]["ArtistID"]);
                mAlbumDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                mAlbumPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mAlbumEdition = Convert.ToString(DB.DataTable.Rows[0]["Edition"]);
                return true;
            }

            
            else 
            {
                Console.WriteLine("Chaîne de connexion utilisée : " + DB.ConnectionString);

                return false;
             }
        }

        public string Valid(string albumTitle, string albumGenre, string albumDescription, string albumEdition, string albumPrice, string albumDate, string albumArtistID)
        {
            DateTime tempDate;
            string Error = "";
            if (albumTitle.Length ==0 )
            {
                Error = Error + "The album title may not be blank !/ ";
            }
            if (albumTitle.Length > 50 )
            {
                Error = Error + "The album title may not exceed 50 characters!/ ";
            }
            
            if (albumGenre.Length < 3) 
            {
                Error = Error + "The album genre must contain at least 3 characters!/ ";
            }
            if(albumGenre.Length > 50 )
            {
                Error = Error + "The album genre cannot exceed 50 characters!/ ";
            }
            if (albumEdition.Length > 50)
            {
                Error = Error + "The album edition may not exceed 50 characters!/ ";
            }
            decimal testPrice;
            if (albumPrice.Length == 0) 
            { Error = Error + "The album price may not be blank!/ "; }
            else
            {
                testPrice = decimal.Parse(albumPrice);


                if (albumPrice.Length > 10)
                {
                    Error = Error + "Album price may not exceed 10 characters"
    ;
                }
                if (testPrice < 1)
                {
                    Error = Error + "Album price cannot be less than one !/ ";
                }
                if (testPrice > 2500)
                {
                    Error = Error + "Price cannot exceed 2500!/ ";
                }
            }
            
            int testArtistID;
            
            if (albumArtistID.Length ==0)
            {
                Error = Error + "Artist ID may not be blank!/ ";
            }
            else
            {
                testArtistID = int.Parse(albumArtistID);
                if (testArtistID < 1)
                {
                    Error = Error + "Artist ID cannot be less than 1!/ ";
                }
                if (testArtistID > 1000)
                {
                    Error = Error + "Artist ID cannot be greater than 1000!/ ";
                }
            }
            
            
            if (albumDate.Length == 0 )
            {
                Error = Error + " Release Date cannot be Null!/ ";
            }
            else 
            {
                tempDate = Convert.ToDateTime(albumDate);
                if (tempDate < Convert.ToDateTime("01/01/1982 00:00:00"))
                {
                    Error = Error + "Release Date cannot be before 1982!/ ";
                }
                if (tempDate > DateTime.Now)
                {
                    Error = Error + "Release Date cannot be in the future!/ ";
                }
            }
            
            return Error;
        }
    }
}