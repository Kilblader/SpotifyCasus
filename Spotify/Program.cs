using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        User rick = new User("Rick", true);

        MenuHome startmenu = new MenuHome();

        while (true)
        {
            startmenu.Run(rick);
        }



    }
}
