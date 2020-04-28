using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLibrary
{
    class Game
    {
        private string Name { get; set; }
        private string Genre { get; set; }
        private string Console { get; set; }
        private string Publisher { get; set; }
        private string Developer { get; set; }
        private int ReleaseYear { get; set; }

        public Game(string n, string g, string c, string p, string d, int y)
        {
            Name = n;
            Genre = g;
            Console = c;
            Publisher = p;
            Developer = d;
            ReleaseYear = y;
        }
    }
}
