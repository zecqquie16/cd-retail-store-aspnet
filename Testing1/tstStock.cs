using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {//------------------------------------Test for Album table------------------------------------------------------------------//
        [TestMethod]
        public void InstanceOK()
        {
            clsAlbum  anAlbum = new clsAlbum();
            Assert.IsNotNull( anAlbum);
        }
        
        [TestMethod]
        public void AlbumTitleOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            string testdata = "Nimporte quoi frère" ;
            anAlbum.AlbumTitle = testdata;
            Assert.AreEqual(anAlbum.AlbumTitle, testdata);
        }
        [TestMethod]
        public void AlbumIDOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            Int32 testdata = 2;
            anAlbum.AlbumID = testdata;
            Assert.AreEqual(anAlbum.AlbumID, testdata);
        }
        [TestMethod]
        public void AlbumGenreOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            string testdata = "Rai";
            anAlbum.AlbumGenre = testdata;
            Assert.AreEqual(anAlbum.AlbumGenre, testdata);
        }
        [TestMethod]
        public void AlbumDateOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            DateTime testdata = DateTime.Now.Date;
            anAlbum.AlbumDate = testdata;
            Assert.AreEqual(anAlbum.AlbumDate, testdata);
        }
        [TestMethod]
        public void AlbumEditionOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            string testdata = "Bleu";
            anAlbum.AlbumEdition = testdata;
            Assert.AreEqual(anAlbum.AlbumEdition, testdata);
        }
        [TestMethod]
        public void AlbumDescriptionOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            string testdata = "Xeu le deux";
            anAlbum.AlbumDescription = testdata;
            Assert.AreEqual(anAlbum.AlbumDescription, testdata);
        }
        [TestMethod]
        public void AlbumArtistIDOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            Int32 testdata = 2;
            anAlbum.AlbumArtistID = testdata;
            Assert.AreEqual(anAlbum.AlbumArtistID, testdata);
        }
        [TestMethod]
        public void AlbumPriceOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            decimal testdata = 15;
            anAlbum.AlbumPrice = testdata;
            Assert.AreEqual(anAlbum.AlbumPrice, testdata);
        }
        //---------------------------------------------Test for Label table--------------------------------------------//
        [TestMethod]
        public void InstanceLabelOK()
        {
            clsLabel aLabel = new clsLabel();
            Assert.IsNotNull(aLabel);
        }

        [TestMethod]
        public void LabelNameOK()
        {
            clsLabel aLabel = new clsLabel();
            string testdata = "Echelon";
            aLabel.LabelName = testdata;
            Assert.AreEqual(aLabel.LabelName, testdata);
        }

        [TestMethod]
        public void LabelPrincipalGenreOK()
        {
            clsLabel aLabel = new clsLabel();
            string testdata = "Rap";
            aLabel.LabelPrincipalGenre = testdata;
            Assert.AreEqual(aLabel.LabelPrincipalGenre, testdata);
        }

        [TestMethod]
        public void LabelWebsiteURLOK()
        {
            clsLabel aLabel = new clsLabel();
            string testdata = "site-web.org";
            aLabel.LabelWebsiteURL = testdata;
            Assert.AreEqual(aLabel.LabelWebsiteURL, testdata);
        }

        [TestMethod]
        public void LabelFoundationDateOK()
        {
            clsLabel aLabel = new clsLabel();
            DateTime testdata = DateTime.Now.Date;
            aLabel.LabelFoundationDate = testdata;
            Assert.AreEqual(aLabel.LabelFoundationDate, testdata);
        }
        [TestMethod]
        public void LabelIDOK()
        {
            clsLabel anAlbum = new clsLabel();
            Int32 testdata = 54;
            anAlbum.LabelID = testdata;
            Assert.AreEqual(anAlbum.LabelID, testdata);
        }
        //----------------------------------------------------Test for Artist table---------------------------//
        [TestMethod]
        public void InstanceArtistOK()
        {
            clsArtist anArtist = new clsArtist();
            Assert.IsNotNull(anArtist);
        }

        [TestMethod]
        public void ArtistNameOK()
        {
            clsArtist anArtist = new clsArtist();
            string testdata = "PNL";
            anArtist.ArtistName = testdata;
            Assert.AreEqual(anArtist.ArtistName, testdata);
        }

        [TestMethod]
        public void ArtistSoloOK()
        {
            clsArtist anArtist = new clsArtist();
            bool testdata = false;
            anArtist.ArtistSolo = testdata;
            Assert.AreEqual(anArtist.ArtistSolo, testdata);
        }

        [TestMethod]
        public void ArtistGenreOK()
        {
            clsArtist anArtist = new clsArtist();
            string testdata = "Rap";
            anArtist.ArtistGenre = testdata;
            Assert.AreEqual(anArtist.ArtistGenre, testdata);
        }

        [TestMethod]
        public void ArtistNationalityOK()
        {
            clsArtist anArtist = new clsArtist();
            string testdata = "Algeria";
            anArtist.ArtistNationality = testdata;
            Assert.AreEqual(anArtist.ArtistNationality, testdata);
        }

        [TestMethod]
        public void ArtistBiographyOK()
        {
            clsArtist anArtist = new clsArtist();
            string testdata = "Un duo emblématique du rap français.";
            anArtist.ArtistBiography = testdata;
            Assert.AreEqual(anArtist.ArtistBiography, testdata);
        }

        [TestMethod]
        public void ArtistLabelIDOK()
        {
            clsArtist anArtist = new clsArtist();
            int testdata = 1;
            anArtist.ArtistLabelID = testdata;
            Assert.AreEqual(anArtist.ArtistLabelID, testdata);
        }
        [TestMethod]
        public void ArtistIDOK()
        {
            clsArtist anArtist = new clsArtist();
            Int32 testdata = 1;
            anArtist.ArtistID = testdata;
            Assert.AreEqual(anArtist.ArtistID, testdata);
        }

    }
}
