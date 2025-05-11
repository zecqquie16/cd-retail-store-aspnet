using System;

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
            mAlbumID = 5;
            mAlbumGenre = "Rap";
            mAlbumTitle = "Ce monde est cruel";
            mAlbumDescription = "Troisième album studio de Vald, Ce monde est cruel sort le 11 octobre 2019. Il est certifié disque d'or en France par le SNEP neuf jours après sa sortie, puis disque de platine avec plus de 100 000 ventes début février 2020.";
            mAlbumArtistID = 3;
            mAlbumDate = Convert.ToDateTime("11/10/2019 00:00:00");
            mAlbumPrice = 15;
            mAlbumEdition = "Standard";
            return true;
        }
    }
}