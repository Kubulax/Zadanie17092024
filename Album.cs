using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie17092024
{
    public class Album
    {
        public string artist;
        public string album;
        public int songsNumber;
        public int year; 
        public int downloadNumber;

        public Album(string artist, string album, int songsNumber, int year, int downloadNumber)
        {
            this.artist = artist;
            this.album = album;
            this.songsNumber = songsNumber;
            this.year = year;
            this.downloadNumber = downloadNumber;
        }
    }
}
