using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Playlist
{
    public string playlistName;
    public List<Song> songs;

    public int PlaylistId { get; set; }

    public string PlaylistName { get; set; }

    public Playlist(string name)
    {
        this.songs = new List<Song>();
        this.PlaylistName = name;
    }

    public override string ToString()
    {
        return $"{this.PlaylistName}";
    }

    public void AddSong(Song song)
    {
        songs.Add(song);
    }
}
