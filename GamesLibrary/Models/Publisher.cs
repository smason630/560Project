using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLibrary.Models
{
    /// <summary>
    /// Publisher Model
    /// </summary>
    public class Publisher
    {
        /// <summary>
        /// Publisher ID
        /// </summary>
        public int PublisherId { get; }
        /// <summary>
        /// Publisher name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Publisher Country
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Publisher Constructor
        /// </summary>
        /// <param name="i">publisher id</param>
        /// <param name="n">publisher name</param>
        /// <param name="c">publisher country</param>
        public Publisher(int i, string n, string c)
        {
            PublisherId = i;
            Name = n;
            Country = c;
        }
    }
}
