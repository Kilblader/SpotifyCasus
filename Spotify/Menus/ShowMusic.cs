using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ShowMusic : IMenu
{
    private User __user;
    public void Run(User user)
    {
        this.__user = user;
        Show();
        menuChoice();
    }
    
    public void Show(Song song = null)
    {
        if (song != null) Console.WriteLine(song.ToString());
        Console.WriteLine("");
        Console.WriteLine($"Music\n" +
            $" 1 - Show music\n" +
            $" 2 - Show albums\n" +  // Maybe later implemented
            $" 3 - Show artists\n" + // Maybe later implemented
            $" 4 - Home\n");
    }
    public void Clear()
    {
        Console.Clear();
    }


    public void menuChoice()
    {
        Console.WriteLine("Input: ");
        switch (__user.IntInput())
        {
            case 1:
                MusicShow();
                break;
            case 2:
                
                break;
            case 3:
                
                break;
            case 4:
                return;
        }

        Run(__user);
    }

    public void MusicShow()
    {
        for (int i = 0; i < __user.playlists.Count; i++)
        {
            Console.WriteLine(__user.playlists[i]);
            foreach (Song s in __user.playlists[__user.IntInput() - 1].songs)
            {
                Console.WriteLine($"{s.Name}, {s.artist}");
            }
        }
    }

}