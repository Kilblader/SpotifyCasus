using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MenuPlaylist : IMenu
{
    private User __user;
    private bool editPL, editSong, created = false;

    public void Show()
    {
        if (created) Console.WriteLine("New playlist made");
        Console.WriteLine("");
        Console.WriteLine($"Playlist\n" +
            $" 1 - Create Playlist\n" +
            $" 2 - Show Playlists\n" +
            $" 3 - Edit Playlists\n" +
            $" 4 - Show Playlist content\n" +
            $" 5 - Add music to playlist\n" +
            $" 6 - Home\n");

    }

    public void Clear()
    {
        Console.Clear();
    }
    public void Run(User user)
    {
        this.__user = user;
        Show();
        menuChoice();
    }


    public void menuChoice()
    {
        Console.WriteLine("Input: ");
        if (created) created = false; 
        switch (__user.IntInput())
        {
            case 1:
                PlaylistCreate();
                break;
            case 2:
                PlaylistShow();
                break;
            case 3:
                PlaylistEdit();
                break;
            case 4:
                PlaylistContent();
                break;
            case 5:
                PlaylistAdd();
                break;
            case 6:
                return;
                

        }

        Run(__user);
    }

    private void PlaylistAdd()
    {
        Clear();
        PlaylistShow();
        Console.WriteLine("Which playlist do you want to add to?");
        Console.WriteLine("");
        int x = __user.IntInput();

        Console.WriteLine("Please fill in the name of the song you want to add.");
        __user.playlists[x].AddSong(new Song(__user.TextInput(), __user.TextInput(), __user.IntInput()));
    }

    private void PlaylistCreate()
    {
        Console.WriteLine("Enter name for Playlist");
        string y = Console.ReadLine();
        __user.playlists.Add(new Playlist(y));
        created = true;
    }

    private void PlaylistShow()
    {
        Clear();
        Console.WriteLine("");
        for (int i = 0; i < __user.playlists.Count; i++)
        {
            Console.WriteLine((i + 1) + ") " + __user.playlists[i].ToString());
        }
    }

    private void PlaylistEdit()
    {
        editPL = true;
        editSong = true;

        Clear();
        PlaylistShow();
        Console.WriteLine("Which playlist do you want to edit?");
        Console.WriteLine("");
        while (editPL)
        {
            try
            {

                int x = __user.IntInput();
                if (x == 0) return;
                Console.WriteLine(__user.playlists[x - 1].ToString());
                Console.WriteLine("");
                foreach (Song s in __user.playlists[x - 1].songs)
                {
                    Console.WriteLine(s.Name);
                }

                editPL = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.Substring(0,24));
            }
        }

        while (editSong)
        {
            try
            {
                Console.WriteLine("What song do you want to delete?");

                int y = __user.IntInput();
                if (y == 0) return;
                Remove(y);
                Clear();
                editSong = false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.Substring(0, 24));
            }
        }
    }

    private void Remove(int y)
    {
        __user.playlists[0].songs.RemoveAt(y-1);
    }

    private void PlaylistContent()
    {
        PlaylistShow();
        Console.WriteLine("Which playlist do you want to view?");
        Console.WriteLine("");

        while (true)
        {
            try
            {
                foreach (Song s in __user.playlists[__user.IntInput() - 1].songs)
                {
                    Console.WriteLine(s.Name);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message.Substring(0, 24));
                Console.WriteLine("");
            }
        }
        return;

    }
}
