using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MenuHome : IMenu
{
    public MenuPlaylist plm = new MenuPlaylist();
    public MenuFriendlist flm = new MenuFriendlist();
    public ShowMusic shm = new ShowMusic();
    private User __user;
    private Song song;

    public void Run(User user)
    {
        this.__user = user;
        Clear();
        Show(this.song);
        menuChoice();
    }

    public void Show(Song song)
    {
        if (song != null) Console.WriteLine(song.ToString());
        Console.WriteLine("");
        Console.WriteLine($"Home\n" +
            $" 1 - Playlists\n" +
            $" 2 - Friendlists\n" + // WiP
            $" 3 - Show music\n" + // WiP
            $" 4 - Play random song\n" +
            $" 5 - Stop music\n" +
            $" 6 - Next song\n");

    }

    public void menuChoice()
    {
        Console.WriteLine("Input: ");
        switch (__user.IntInput())
        {
            case 1:
                Change(plm,this.song);
                break;
            case 2:
                Change(flm, this.song);
                break;
            case 3:
                Change(shm, this.song);
                break;
            case 4:
               song = __user.PlayRandom();
                break;
            case 5:
                song = __user.StopMusic(song);
                break;
            case 6:
                song = __user.NextSong();
                break;
        }
    }

    private void Change(IMenu obj, Song song)
    {
        obj.Clear();
        obj.Show(this.song);
        obj.Run(__user);
    }

    public void Clear()
    {
        Console.Clear();
    }
}
