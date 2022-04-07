using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Classes
{
    public class Album
    {
        public string title;
        public string artist;
        public int releaseYear;

        public string Title { get { return title; } set { title = value; } }
        public string Artist { get { return artist; } set { artist = value; } }
        public int Release { get { return releaseYear; } set { releaseYear = value; } }

        public Album(string title, string artist, int ry)
        {
            this.title = title;
            this.artist = artist;
            this.releaseYear = ry;
        }

        public void AddAlbum(string title, string artist, int ry)
        {
            Album album = new Album(title, artist, ry);
        }

    }

    
}
