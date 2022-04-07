﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Classes
{
    public class Song
    {
        public string name;
        public string artist;
        public int duration;
        public string genre;

        public string Name { get { return name; } set { name = value; } }
        public string Artist { get { return artist; } set { artist = value; } }
        public int Duration { get { return duration; } set { duration = value; } } 
        public string Genre { get { return genre; } set { genre = value; } }


        public Song(string name, string artist, int dur)
        {
            this.name = name;
            this.artist = artist;
            this.duration = dur;
        }

        public void AddSong(string name, string artist, int dur)
        {
            Song songs = new Song(name, artist, dur);
        }

    }
}
