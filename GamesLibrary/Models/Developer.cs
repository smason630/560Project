using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLibrary
{
    /// <summary>
    /// Game developer model
    /// </summary>
    public class Developer
    {
        /// <summary>
        /// dev id
        /// </summary>
        public int DeveloperId { get; }
        /// <summary>
        /// developer name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// developer country
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// developer constructor
        /// </summary>
        /// <param name="i">dev id</param>
        /// <param name="n">dev name</param>
        /// <param name="c">dev country</param>
        public Developer(int i, string n, string c)
        {
            DeveloperId = i;
            Name = n;
            Country = c;
        }
    }
}
