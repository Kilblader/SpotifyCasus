using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Classes
{
    public class User
    {
        public string Name;

        public int UserId { get; set; }
        public string name { get { return Name; } set { Name = value; }}
    }
}
