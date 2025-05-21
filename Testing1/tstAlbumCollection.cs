using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstAlbumCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsAlbumCollection allAlbums = new clsAlbumCollection();
            Assert.IsNotNull(allAlbums);
        }
        [TestMethod]
        public void AlbumListOK()
        {
            clsAlbumCollection allAlbums = new clsAlbumCollection();
            List<clsAlbum> TestList = new List<clsAlbum>();
            clsAlbum testItem = new clsAlbum();
            testItem.AlbumID = 26;
            testItem.AlbumTitle = "Vréel4";
            testItem.AlbumGenre = "Rap";
            testItem.AlbumDescription = "4e Vréel de Kekra";
            testItem.AlbumDate = Convert.ToDateTime("16/05/2025 00:00:00");
            testItem.AlbumEdition = " Sale";
            testItem.AlbumArtistID = 8;
            testItem.AlbumPrice = 38;
            TestList .Add(testItem);
            allAlbums.AlbumList = TestList;
            Assert.AreEqual(allAlbums.AlbumList, TestList);
        }
       
        [TestMethod]
        public void ThisAlbumOK()
        {
            clsAlbumCollection allAlbums = new clsAlbumCollection();
            
            clsAlbum testAlbum = new clsAlbum();
            testAlbum.AlbumID = 26;
            testAlbum.AlbumTitle = "Vréel4";
            testAlbum.AlbumGenre = "Rap";
            testAlbum.AlbumDescription = "4e Vréel de Kekra";
            testAlbum.AlbumDate = Convert.ToDateTime("16/05/2025 00:00:00");
            testAlbum.AlbumEdition = " Sale";
            testAlbum.AlbumArtistID = 8;
            testAlbum.AlbumPrice = 38;
            
            allAlbums.ThisAlbum = testAlbum;
            Assert.AreEqual(allAlbums.ThisAlbum, testAlbum);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsAlbumCollection allAlbums = new clsAlbumCollection();
            List<clsAlbum> TestList = new List<clsAlbum>();
            clsAlbum testAlbum = new clsAlbum();
            testAlbum.AlbumID = 26;
            testAlbum.AlbumTitle = "Vréel4";
            testAlbum.AlbumGenre = "Rap";
            testAlbum.AlbumDescription = "4e Vréel de Kekra";
            testAlbum.AlbumDate = Convert.ToDateTime("16/05/2025 00:00:00");
            testAlbum.AlbumEdition = " Sale";
            testAlbum.AlbumArtistID = 8;
            testAlbum.AlbumPrice = 38;
            TestList.Add(testAlbum);
            allAlbums.AlbumList= TestList;
            Assert.AreEqual(allAlbums.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsAlbumCollection allAlbums = new clsAlbumCollection();
            
            clsAlbum testAlbum = new clsAlbum();
            Int32 PrimaryKey = 0;
            testAlbum.AlbumID = 30;
            testAlbum.AlbumTitle = "Kekra";
            testAlbum.AlbumGenre = "Rap";
            testAlbum.AlbumDescription = "Album de Kekra";
            testAlbum.AlbumDate = Convert.ToDateTime("15/07/2022 00:00:00");
            testAlbum.AlbumEdition = " Sous-côté";
            testAlbum.AlbumArtistID = 8;
            testAlbum.AlbumPrice = 22;
            allAlbums.ThisAlbum = testAlbum;
            PrimaryKey = allAlbums.Add();
            testAlbum.AlbumID= PrimaryKey;
            allAlbums.ThisAlbum.Find(PrimaryKey);
            Assert.AreEqual(allAlbums.ThisAlbum, testAlbum);    

        }
         [TestMethod]
        public void UpdateMethodOK()
        {
            clsAlbumCollection allAlbums = new clsAlbumCollection();
            
            clsAlbum testAlbum = new clsAlbum();
            Int32 PrimaryKey = 0;
            testAlbum.AlbumID = 30;
            testAlbum.AlbumTitle = "Kekra";
            testAlbum.AlbumGenre = "Rap";
            testAlbum.AlbumDescription = "Album de Kekra";
            testAlbum.AlbumDate = Convert.ToDateTime("15/07/2022 00:00:00");
            testAlbum.AlbumEdition = " Sous-côté";
            testAlbum.AlbumArtistID = 8;
            testAlbum.AlbumPrice = 22;
            allAlbums.ThisAlbum = testAlbum;
            PrimaryKey = allAlbums.Add();
            testAlbum.AlbumID= PrimaryKey;
            
            testAlbum.AlbumTitle = "Deo Favente";
            testAlbum.AlbumGenre = "Rap";
            testAlbum.AlbumDescription = "3e Album d'SCH";
            testAlbum.AlbumDate = Convert.ToDateTime("01/07/2017 00:00:00");
            testAlbum.AlbumEdition = " Vraiment cool";
            testAlbum.AlbumArtistID = 19;
            testAlbum.AlbumPrice = 54;
            allAlbums.ThisAlbum = testAlbum;
            allAlbums.Update();
            allAlbums.ThisAlbum.Find(PrimaryKey);
            Assert.AreEqual(allAlbums.ThisAlbum, testAlbum);    

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsAlbumCollection allAlbums = new clsAlbumCollection();

            clsAlbum testAlbum = new clsAlbum();
            Int32 PrimaryKey = 0;
            testAlbum.AlbumID = 30;
            testAlbum.AlbumTitle = "Kekra";
            testAlbum.AlbumGenre = "Rap";
            testAlbum.AlbumDescription = "Album de Kekra";
            testAlbum.AlbumDate = Convert.ToDateTime("15/07/2022 00:00:00");
            testAlbum.AlbumEdition = " Sous-côté";
            testAlbum.AlbumArtistID = 8;
            testAlbum.AlbumPrice = 22;
            allAlbums.ThisAlbum = testAlbum;
            PrimaryKey = allAlbums.Add();
            testAlbum.AlbumID = PrimaryKey;

            allAlbums.ThisAlbum.Find(PrimaryKey);
            allAlbums.Delete();
            Boolean found = allAlbums.ThisAlbum.Find(PrimaryKey);
            Assert.IsFalse(found);

        }
        [TestMethod]
        public void ReportByTitleMethodOK()
        {
            clsAlbumCollection allAlbums = new clsAlbumCollection();
            clsAlbumCollection FilteredAlbums = new clsAlbumCollection();
            FilteredAlbums.ReportByTitle("");
            Assert.AreEqual(FilteredAlbums.Count, allAlbums.Count);

        }
        [TestMethod]
        public void ReportByTitleNoneFound()
        {
            
            clsAlbumCollection FilteredAlbums = new clsAlbumCollection();
            FilteredAlbums.ReportByTitle("N'existePas");
            Assert.AreEqual(FilteredAlbums.Count, 0);

        }
        [TestMethod]
        public void ReportByTitleTestDataFound()
        {

            clsAlbumCollection FilteredAlbums = new clsAlbumCollection();
            Boolean OK = true;
            FilteredAlbums.ReportByTitle("Ce monde est cruel");
            if (FilteredAlbums.Count == 2)
            {
                if (FilteredAlbums.AlbumList[0].AlbumID != 5) OK = false;
                if (FilteredAlbums.AlbumList[1].AlbumID != 12) OK = false;
            }
            else OK = false;
            Assert.IsTrue(OK); 

        }
    }
}
