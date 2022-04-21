using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ShowMusic : IMenu
{
    private User __user;


    public void Show()
    {
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

    public void Run(User user)
    {
        this.__user = user;
        Show();
        menuChoice();
    }

    public void menuChoice()
    {
        Console.WriteLine("Input: ");
        switch (__user.IntInput())
        {
            case 1:
                //PlaylistCreate();
                break;
            case 2:
                //PlaylistShow();
                break;
            case 3:
                //PlaylistEdit();
                break;
            case 4:
                return;
        }

        Run(__user);
    }

}