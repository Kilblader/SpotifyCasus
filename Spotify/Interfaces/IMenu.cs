using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMenu
{
    void Show();

    void Run(User user);

    void Clear();
}