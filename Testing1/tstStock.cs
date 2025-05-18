using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {   //Good test data//

        string AlbumTitle = "Xeu";
        string AlbumGenre = "Rap";
        string AlbumDescription = "Deuxième album studio du V";
        string AlbumEdition = "Standard";
        string AlbumDate = DateTime.Now.ToShortDateString();
        string AlbumPrice = Convert.ToString(15.00000);
        string AlbumArtistID = Convert.ToString(5);

        
        
        
        
        
        
        
        //------------------------------------Test for Album table------------------------------------------------------------------//
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
        //------------------------Testing methods--------------------------//
        [TestMethod]
        public void FindMethodOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            Boolean found = false;
            Int32 AlbumID = 17;
            found = anAlbum.Find(AlbumID);
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void testAlbumIDisFoundOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            Boolean found = false;
            Boolean OK = true;
            Int32 AlbumID = 17;
            found = anAlbum.Find(AlbumID);
            if (anAlbum.AlbumID != 17)
            {
                OK = false; 
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void testAlbumGenreIsFoundOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            Boolean found = false;
            Boolean OK = true;
            Int32 AlbumID = 17;
            found = anAlbum.Find(AlbumID);
            if (anAlbum.AlbumGenre != "Rap")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void testAlbumTitleIsFoundOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            Boolean found = false;
            Boolean OK = true;
            Int32 AlbumID = 17;
            found = anAlbum.Find(AlbumID);
            if (anAlbum.AlbumTitle != "Akimbo")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void testAlbumDescriptionIsFoundOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            Boolean found = false;
            Boolean OK = true;
            Int32 AlbumID = 17;
            found = anAlbum.Find(AlbumID);
            if (anAlbum.AlbumDescription != "Premier album studio de Ziak")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void testAlbumArtistIDIsFoundOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            Boolean found = false;
            Boolean OK = true;
            Int32 AlbumID = 17;
            found = anAlbum.Find(AlbumID);
            if (anAlbum.AlbumArtistID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void testAlbumReleaseDateIsFoundOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            Boolean found = false;
            Boolean OK = true;
            Int32 AlbumID = 17;
            found = anAlbum.Find(AlbumID);
            if (anAlbum.AlbumDate != Convert.ToDateTime("12/03/2021 00:00:00"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void testAlbumPriceIsFoundOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            Boolean found = false;
            Boolean OK = true;
            Int32 AlbumID = 17;
            found = anAlbum.Find(AlbumID);
            if (anAlbum.AlbumPrice != Convert.ToDecimal(16))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void testAlbumEditionIsFoundOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            Boolean found = false;
            Boolean OK = true;
            Int32 AlbumID = 17;
            found = anAlbum.Find(AlbumID);
            if (anAlbum.AlbumEdition != "Couteau")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //------------------------------------------------Validation Tests----------------------------------------//
        [TestMethod]
        public void ValidMethodOK()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumTitleMinLessOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumTitle = "";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumTitleMin()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumTitle = "V";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumTitleMinPlusOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumTitle = "VV";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        //50 characters length :'llllllllllllllllllllllllllllllllllllllllllllllllll'
        [TestMethod]
        public void AlbumTitleMax()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumTitle = "llllllllllllllllllllllllllllllllllllllllllllllllll";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumTitleMid()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumTitle = "lllllllllllllllllllllllll";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumTitleMaxLessOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumTitle = "lllllllllllllllllllllllllllllllllllllllllllllllll";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumTitleMaxPlusOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumTitle = "lllllllllllllllllllllllllllllllllllllllllllllllllll";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumTitleMaxExtreme()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumTitle = "";
            AlbumTitle = AlbumTitle.PadRight(1000,'l');
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumGenreMinLessOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumGenre = "DJ";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumGenreMin()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumGenre = "Pop";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumGenreMinExtreme()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumGenre = "";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumGenreMinPlusOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumGenre = "VVVV";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumGenreMaxLessOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumGenre = "lllllllllllllllllllllllllllllllllllllllllllllllll";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumGenreMax()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumGenre = "llllllllllllllllllllllllllllllllllllllllllllllllll";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumGenreMaxPlusOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumGenre = "lllllllllllllllllllllllllllllllllllllllllllllllllll";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumGenreMid()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumGenre = "lllllllllllllllllllllllll";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumGenreMaxExtreme()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumGenre = "";
            AlbumGenre = AlbumGenre.PadRight(1000, 'l');
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumEditionMaxLessOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumEdition = "lllllllllllllllllllllllllllllllllllllllllllllllll";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumEditionMax()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumEdition = "llllllllllllllllllllllllllllllllllllllllllllllllll";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumEditionMaxPlusOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumEdition = "lllllllllllllllllllllllllllllllllllllllllllllllllll";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumEditionMid()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumEdition = "lllllllllllllllllllllllll";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumEditionMaxExtreme()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumEdition = "";
            AlbumGenre = AlbumEdition.PadRight(1000, 'l');
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceMinLessOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            decimal testPrice = 0;
            AlbumPrice = testPrice.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceMin()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            decimal testPrice = 1;
            AlbumPrice = testPrice.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceMinPlusOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            decimal testPrice = 2;
            AlbumPrice = testPrice.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        //50 characters length :'llllllllllllllllllllllllllllllllllllllllllllllllll'
        [TestMethod]
        public void AlbumPriceMax()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = ""; 
            decimal testPrice = 2500;
            AlbumPrice = testPrice.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceMid()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            decimal testPrice = 1250;
            AlbumPrice = testPrice.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceMaxLessOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            decimal testPrice = 2499;
            AlbumPrice = testPrice.ToString(); ;
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceMaxPlusOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            decimal testPrice = 2501;
            AlbumPrice = testPrice.ToString(); 
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceMaxExtreme()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            decimal testPrice = 100000000;
            AlbumPrice = testPrice.ToString(); ;
           
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumArtistIDMinLessOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            int testArtistID = 0;
            AlbumArtistID = testArtistID.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumArtistIDMin()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            int testArtistID = 1;
            AlbumArtistID = testArtistID.ToString();
            
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumArtistIDMinPlusOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            int testArtistID = 2;
            AlbumArtistID = testArtistID.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        //50 characters length :'llllllllllllllllllllllllllllllllllllllllllllllllll'
        [TestMethod]
        public void AlbumArtistIDMax()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            int testArtistID = 1000;
            AlbumArtistID = testArtistID.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumArtistIDMid()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            int testArtistID = 500;
            AlbumArtistID = testArtistID.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumArtistIDMaxLessOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            int testArtistID = 999;
            AlbumArtistID = testArtistID.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumArtistIDMaxPlusOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            int testArtistID = 1001;
            AlbumArtistID = testArtistID.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumArtistIDMaxExtreme()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            int testArtistID = 100000000;
            AlbumArtistID = testArtistID.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumDateMinExtreme()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumDate;
             DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1000);
            AlbumDate = TestDate.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AlbumDateMinLessOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumDate;

            AlbumDate = "31/12/1981 00:00:00";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AlbumDateMin()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumDate;

            AlbumDate = "01/01/1982 00:00:00";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AlbumDateMinPlusOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumDate = "02/01/1982 00:00:00";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        //50 characters length :'llllllllllllllllllllllllllllllllllllllllllllllllll'
        [TestMethod]
        public void AlbumDateMax()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            DateTime testDate;
            testDate = DateTime.Now;
            string AlbumDate = testDate.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumDateMid()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumDate = "01/01/2002 00:00:00";
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumDateMaxLessOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            DateTime testDate;
            testDate = DateTime.Now;
            testDate = testDate.AddDays(-1);
            string AlbumDate = testDate.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumDateMaxPlusOne()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            DateTime testDate;
            testDate = DateTime.Now;
            testDate = testDate.AddDays(1);
            string AlbumDate = testDate.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumDateMaxExtreme()
        {
            clsAlbum anAlbum = new clsAlbum();
            String Error = "";
            String AlbumDate;
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1000);
            AlbumDate = TestDate.ToString();
            Error = anAlbum.Valid(AlbumTitle, AlbumGenre, AlbumDescription, AlbumEdition, AlbumPrice, AlbumDate, AlbumArtistID);
            Assert.AreNotEqual(Error, "");
        }
    }

}
