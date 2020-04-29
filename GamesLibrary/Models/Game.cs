using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLibrary
{
    /// <summary>
    /// game model
    /// </summary>
    public class Game
    {
        /// <summary>
        /// game id
        /// </summary>
        public int GameId { get; }
        /// <summary>
        /// game name
        /// </summary>
        private string Name { get; set; }
        /// <summary>
        /// game genre
        /// </summary>
        private string Genre { get; set; }
        /// <summary>
        /// game console
        /// </summary>
        private string Console { get; set; }
        /// <summary>
        /// game publisher
        /// </summary>
        private string Publisher { get; set; }
        /// <summary>
        /// game developer
        /// </summary>
        private string Developer { get; set; }
        /// <summary>
        /// game release year
        /// </summary>
        private int ReleaseYear { get; set; }
        /// <summary>
        /// game constructor
        /// </summary>
        /// <param name="i">game id int</param>
        /// <param name="n">game name string</param>
        /// <param name="g">game genre</param>
        /// <param name="c">game console</param>
        /// <param name="p">game publisher</param>
        /// <param name="d">game developer</param>
        /// <param name="y">game year</param>
        public Game(int i, string n, string g, string c, string p, string d, int y)
        {
            GameId = i;
            Name = n;
            Genre = g;
            Console = c;
            Publisher = p;
            Developer = d;
            ReleaseYear = y;
        }
    }
}
