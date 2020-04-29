using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLibrary.Models
{
    /// <summary>
    /// Console model
    /// </summary>
    public class Genre
    {
        /// <summary>
        /// Genre ID
        /// </summary>
        public int GenreId { get; }
        /// <summary>
        /// Genre Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Genre Constructor
        /// </summary>
        /// <param name="i">genre id</param>
        /// <param name="n">genre name</param>
        public Genre(int i, string n)
        {
            GenreId = i;
            Name = n;
        }
    }
}
