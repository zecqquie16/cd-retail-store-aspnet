using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace AlbumTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            clsAlbum album = new clsAlbum();
            int albumID = 16;

            bool found = album.Find(albumID);

            if (found)
            {
                Console.WriteLine("Album trouvé !");
                Console.WriteLine("Titre : " + album.AlbumTitle);
                Console.WriteLine("Genre : " + album.AlbumGenre);
                Console.WriteLine("Prix : " + album.AlbumPrice);
                Console.WriteLine("Date : " + album.AlbumDate);
                Console.WriteLine("Edition : " + album.AlbumEdition);
                Console.WriteLine("Description : " + album.AlbumDescription);
            }
            else
            {
                Console.WriteLine($"Aucun album trouvé avec l'ID: {albumID}");
                

            }

            Console.ReadLine(); // pour garder la console ouverte
        }
    }
}


