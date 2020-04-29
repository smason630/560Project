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
    public class Console
    {
        /// <summary>
        /// Console id
        /// </summary>
        public int ConsoleId { get; }
        /// <summary>
        /// console name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Console constructor
        /// </summary>
        /// <param name="i">console id</param>
        /// <param name="n">console name</param>
        public Console(int i, string n)
        {
            ConsoleId = i;
            Name = n;
        }
    }
}
