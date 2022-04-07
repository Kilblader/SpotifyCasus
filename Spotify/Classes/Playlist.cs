using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Classes
{
    public class Playlist
    {
        public string Name;

        public int PlaylistId { get; set; }

        public string PlaylistName { get {return Name ; } set{ value = Name; }
    }
}
