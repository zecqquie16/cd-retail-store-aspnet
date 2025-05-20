using System;
using System.Collections.Generic;
using ClassLibrary;
namespace ClassLibrary
{
    public class clsAlbumCollection
    {
      
       public clsAlbumCollection() 
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblAlbum_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsAlbum anAlbum = new clsAlbum();
                anAlbum.AlbumID = Convert.ToInt32(DB.DataTable.Rows[Index]["AlbumID"]);
                anAlbum.AlbumTitle= Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                anAlbum.AlbumGenre = Convert.ToString(DB.DataTable.Rows[Index]["Genre"]);
                anAlbum.AlbumEdition = Convert.ToString(DB.DataTable.Rows[Index]["Edition"]);
                anAlbum.AlbumDescription= Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                anAlbum.AlbumArtistID = Convert.ToInt32(DB.DataTable.Rows[Index]["ArtistID"]);
                anAlbum.AlbumPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                anAlbum.AlbumDate= Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
                mAlbumList.Add(anAlbum);
                Index++;
            }

        }
        List<clsAlbum> mAlbumList = new List<clsAlbum>();
        clsAlbum mThisAlbum = new clsAlbum();
        public List<clsAlbum> AlbumList 
        { get 
            {
                return mAlbumList;
            }
            set
            {
                mAlbumList = value;
            }
        }
        public int Count
        {
            get
            {
                return mAlbumList.Count;
            }
            set
            {
                //
            }
        }
        public clsAlbum ThisAlbum 
        {
            get 
                 { 
                return mThisAlbum;
                 }
            set
                 {
                mThisAlbum = value;
                 }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Title",mThisAlbum.AlbumTitle);
            DB.AddParameter("@Genre", mThisAlbum.AlbumGenre);
            DB.AddParameter("@ReleaseDate", mThisAlbum.AlbumDate);
            DB.AddParameter("@Description", mThisAlbum.AlbumDescription);
            DB.AddParameter("@Edition", mThisAlbum.AlbumEdition);
            DB.AddParameter("@ArtistID", mThisAlbum.AlbumArtistID);
            DB.AddParameter("@Price", mThisAlbum.AlbumPrice);
            return DB.Execute("sproc_tblAlbum_Insert");
        }
    }
}