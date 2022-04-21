using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class User 
{
    public List<Playlist> playlists = new List<Playlist>();
    public string Name;
    public bool debug;
    private int curpl, cursong;


    public int UserId { get; set; }
    public string name { get { return Name; } set { Name = value; }}
    public bool Debug { get { return debug; } set { debug = value; } }


    public User(string name, bool debug = false) 
    { 
        this.Name = name;

        if (debug)
        {
            playlists.Add(new Playlist("Metal"));
            playlists.Add(new Playlist("Metalcore"));

            // Playlist 1
            playlists[0].AddSong(new Song("Du Hast", "Rammstein", 300));
            playlists[0].AddSong(new Song("Deutschland", "Rammstein", 360));
            playlists[0].AddSong(new Song("Heart from your hate", "Trivium", 280));
            playlists[0].AddSong(new Song("Ten Thousand Fists", "Disturbed", 260));
            playlists[0].AddSong(new Song("Raining Blood", "Slayer", 210));

            // Playlist 2
            playlists[1].AddSong(new Song("Crushed", "Parkway Drive", 210));
            playlists[1].AddSong(new Song("Bottom Feeder", "Parkway Drive", 230));
            playlists[1].AddSong(new Song("Blinded", "As I Lay Dying", 230));
            playlists[1].AddSong(new Song("Shaped by Fire", "As I Lay Dying", 225));
            playlists[1].AddSong(new Song("Undertow", "As I Lay Dying", 225));
        }

    }

    public string TextInput()
    {
        string y = Console.ReadLine();
        return y;
    }

    public int IntInput()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        return x;
    }

    public Song PlayRandom()
    {
        Random rand = new Random();
        curpl = rand.Next(playlists.Count);
        cursong = rand.Next(playlists[curpl - 1].songs.Count);
        Console.WriteLine(playlists[curpl].songs[cursong].ToString());
        return playlists[curpl].songs[cursong];
    }

    public Song StopMusic(Song song)
    {
        song = null;
        return song;
    }

    public Song NextSong()
    {
       if (cursong == playlists[curpl].songs.Count - 1)
       {
          Song nextSong = playlists[curpl].songs[0];
          cursong = 0;
          return nextSong;
       }
       else
       {
            Song nextSong = playlists[curpl].songs[cursong + 1];
            
            cursong ++;
            Console.WriteLine(cursong);
            return nextSong;
       }
    }
}

