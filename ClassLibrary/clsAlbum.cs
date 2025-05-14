using System;
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

        public bool Find(int albumID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AlbumID", AlbumID);

            DB.Execute("sproc_tblAlbum_FilterByAlbumID");
            if (DB.Count==1)
            {
                mAlbumID = Convert.ToInt32(DB.DataTable.Rows[0]["AlbumID"]);
                mAlbumGenre = Convert.ToString(DB.DataTable.Rows[0]["Genre"]);
                mAlbumTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mAlbumDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mAlbumArtistID = Convert.ToInt32(DB.DataTable.Rows[0]["ArtistID"]);
                mAlbumDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Release Date"]);
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
    }
}