using System;
using System.Collections.Generic;
using System.Data.Common;
using ClassLibrary;
namespace ClassLibrary
{
    public class clsArtistCollection
    {

        public clsArtistCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblArtist_SelectAll");

            PopulateArray(DB);//

        }
        List<clsArtist> mArtistList = new List<clsArtist>();
        clsArtist mThisArtist = new clsArtist();
        public List<clsArtist> ArtistList
        {
            get
            {
                return mArtistList;
            }
            set
            {
                mArtistList = value;
            }
        }
        public int Count
        {
            get
            {
                return mArtistList.Count;
            }
            set
            {
                //
            }
        }
        public clsArtist ThisArtist
        {
            get
            {
                return mThisArtist;
            }
            set
            {
                mThisArtist = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", mThisArtist.ArtistName);
            DB.AddParameter("@Genre", mThisArtist.ArtistGenre);
            DB.AddParameter("@Biography", mThisArtist.ArtistBiography);
            DB.AddParameter("@Nationality", mThisArtist.ArtistNationality);
            DB.AddParameter("@Solo", mThisArtist.ArtistIsSolo);
            DB.AddParameter("@Image", mThisArtist.ArtistImage);
         
            return DB.Execute("sproc_tblArtist_Insert");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ArtistID", mThisArtist.ArtistID);
            DB.AddParameter("@Name", mThisArtist.ArtistName);
            DB.AddParameter("@Genre", mThisArtist.ArtistGenre);
            DB.AddParameter("@Biography", mThisArtist.ArtistBiography);
            DB.AddParameter("@Nationality", mThisArtist.ArtistNationality);
            DB.AddParameter("@Solo", mThisArtist.ArtistIsSolo);
            DB.Execute("sproc_tblArtist_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AlbumID", mThisArtist.ArtistID);
            DB.Execute("sproc_tblArtist_Delete");
        }

        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", Name);
            DB.Execute("sproc_tblAlbum_FilterByName");
            PopulateArray(DB);

        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mArtistList = new List<clsArtist>();
            while (Index < RecordCount)
            {
                clsArtist anArtist = new clsArtist();
                anArtist.ArtistID = Convert.ToInt32(DB.DataTable.Rows[Index]["ArtistID"]);
                anArtist.ArtistName = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                anArtist.ArtistGenre = Convert.ToString(DB.DataTable.Rows[Index]["Genre"]);
                anArtist.ArtistNationality = Convert.ToString(DB.DataTable.Rows[Index]["Nationality"]);
                anArtist.ArtistBiography = Convert.ToString(DB.DataTable.Rows[Index]["Biography"]);
                anArtist.ArtistIsSolo = Convert.ToBoolean(DB.DataTable.Rows[Index]["Solo"]);
                mArtistList.Add(anArtist);
                Index++;
            }
            // validation à faire le goat <3 
        }
    }
}