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

    public void Show()
    {
        if (song != null) Console.WriteLine(song.ToString());
        Console.WriteLine("");
        Console.WriteLine($"Home\n" +
            $" 1 - Playlists\n" +
            $" 2 - Friendlists\n" +
            $" 3 - Show music\n" +
            $" 4 - Play random song\n" +
            $" 5 - Stop music\n" +
            $" 6 - Next song\n");

    }

    public void Run(User user)
    {
        this.__user = user;
        Clear();
        Show();
        menuChoice();
    }

    public void menuChoice()
    {
        Console.WriteLine("Input: ");
        switch (__user.IntInput())
        {
            case 1:
                Change(plm);
                break;
            case 2:
                Change(flm);
                break;
            case 3:
                Change(shm);
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

    private void Change(IMenu obj)
    {
        obj.Clear();
        obj.Run(__user);
    }

    public void Clear()
    {
        Console.Clear();
    }
}
