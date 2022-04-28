using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MenuFriendlist : IMenu
{
    private User __user;

    public void Show(Song song = null)
    {
        if (song != null) Console.WriteLine(song.ToString());
        Console.WriteLine("");
        Console.WriteLine($"Friendlist\n" +
            $"1 - View Friendlist\n" +
            $"2 - Add Friend\n" +
            $"3 - Remove Friend\n" +
            $"4 - Home\n");
    }
    public void Clear()
    {
        Console.Clear();
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
        switch (__user.IntInput())
        {
            case 1:
                FriendlistShow();
                break;
            case 2:
                FriendlistAdd();
                break;
            case 3:
                FriendlistRemove();
                break;
            case 4:
                return;


        }

        Run(__user);
    }

    private void FriendlistShow()
    {
        
    }

    private void FriendlistAdd()
    {

    }

    private void FriendlistRemove()
    {

    }

}
