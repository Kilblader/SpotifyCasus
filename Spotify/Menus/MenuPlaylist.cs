using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MenuPlaylist : IMenu
{
    private User __user;
    private bool editPL, editSong, created, content = false;

    public void Run(User user)
    {
        this.__user = user;
        Clear();
        Show();
        menuChoice();
    }

    public void Show(Song song = null)
    {
        if (song != null) Console.WriteLine(song.ToString());
        if (created) Console.WriteLine("New playlist made");
        Console.WriteLine("");
        Console.WriteLine($"Playlist\n" +
            $" 1 - Create Playlist\n" +
            $" 2 - Edit Playlists\n" +
            $" 3 - Show Playlist content\n" +
            $" 4 - Add music to playlist\n" +
            $" 5 - Home\n");

    }

    public void Clear()
    {
        Console.Clear();
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
                PlaylistEdit();
                break;
            case 3:
                PlaylistContent();
                break;
            case 4:
                PlaylistAdd();
                break;
            case 5:
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
        content = true;
        PlaylistShow();
        Console.WriteLine("");

        while (content == true)
        {
            try
            {
                Console.WriteLine("Which playlist do you want to view?");
                foreach (Song s in __user.playlists[__user.IntInput() - 1].songs)
                {
                    Console.WriteLine($"{s.Name}, {s.artist}");
                }
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.Substring(0, 24));
                Console.WriteLine("");
                return;
            }
        }
        
    }
}
