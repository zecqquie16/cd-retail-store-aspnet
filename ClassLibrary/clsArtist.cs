using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace ClassLibrary
{
    public class clsArtist
    {
        private int mArtistID;
        private string mArtistName;
        private bool mArtistIsSolo;
        private string mArtistGenre;
        private string mArtistNationality;
        private string mArtistBiography;
        private string mArtistImage;

      
        public string ArtistName
        {
            get
            {
                return mArtistName;
            }
            set
            {
                mArtistName = value;
            }
        }
        public int ArtistID
        {
            get
            {
                return mArtistID;
            }
            set
            {
                mArtistID = value;
            }

        } //primary key
        public string ArtistGenre
        {
            get
            {
                return mArtistGenre;
            }
            set
            {
                mArtistGenre = value;
            }
        }
       
       
        public bool ArtistIsSolo
        {
            get
            {
                return mArtistIsSolo;
            }
            set
            {
                mArtistIsSolo = value;
            }

        }
        public string ArtistNationality
        {
            get
            {
                return mArtistNationality;
            }
            set
            {
                mArtistNationality = value;
            }
        }
        public string ArtistBiography
        {
            get
            {
                return mArtistBiography;
            }
            set
            {
                mArtistBiography = value;
            }
        }
        public string ArtistImage
        {
            get
            {
                return mArtistImage;
            }
            set
            {
                mArtistImage = value;
            }
        }


        public bool Find(int ArtistID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("ArtistID", ArtistID);



            DB.Execute("sproc_tblArtist_FilterByArtistID");
            System.Diagnostics.Debug.WriteLine("Nombre de lignes après exécution : " + DB.Count);

            if (DB.Count == 1)
            {
                mArtistID = Convert.ToInt32(DB.DataTable.Rows[0]["ArtistID"]);
                mArtistGenre = Convert.ToString(DB.DataTable.Rows[0]["Genre"]);
                mArtistName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mArtistNationality = Convert.ToString(DB.DataTable.Rows[0]["Nationality"]);
                mArtistImage = Convert.ToString(DB.DataTable.Rows[0]["Image"]);
                mArtistBiography = Convert.ToString(DB.DataTable.Rows[0]["Biography"]);
                mArtistIsSolo = Convert.ToBoolean(DB.DataTable.Rows[0]["Solo"]);
                return true;
            }


            else
            {
                Console.WriteLine("Chaîne de connexion utilisée : " + DB.ConnectionString);

                return false;
            }
        }
        public string Valid(string artistName, string artistGenre, string artistBiography, string artistNationality, string artiistIsSolo, string artistImage)
        {
            
            string Error = "";
            if (artistName.Length == 0)
            {
                Error = Error + "The artist name may not be blank !/ ";
            }
            if (artistName.Length > 50)
            {
                Error = Error + "The artist name may not exceed 50 characters!/ ";
            }

            if (artistGenre.Length < 3)
            {
                Error = Error + "The artist genre must contain at least 3 characters!/ ";
            }
            if (artistGenre.Length > 50)
            {
                Error = Error + "The artist genre cannot exceed 50 characters!/ ";
            }
            if (artistNationality.Length > 50)
            {
                Error = Error + "The artist nationality may not exceed 50 characters!/ ";
            }
            if (artistBiography.Length == 0)
            {
                Error = Error + "The artist biography may not be blank !/ ";
            }
            if (artistNationality.Length == 0)
            {
                Error = Error + "The artist nationality may not be blank !/ ";
            }





        

            return Error;
        }


    }
}