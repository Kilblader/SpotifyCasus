using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Album
{
    private string title;
    private string artist;
    private int releaseYear;
    private List<Song> albumsongs;

    public string Title { get { return title; } set { title = value; } }
    public string Artist { get { return artist; } set { artist = value; } }
    public int Release { get { return releaseYear; } set { releaseYear = value; } }

    public Album(string title, string artist, int ry)
    {
        this.title = title;
        this.artist = artist;
        this.releaseYear = ry;
        this.albumsongs = new List<Song>();
    }

    //public void AddAlbum(string title, string artist, int ry)
    //{
    //    Album album = new Album(title, artist, ry);
    //}

    public void AddSong(string name, string artist, int dur)
    {
        this.albumsongs.Add(new Song(name, artist, dur));
    }

}
