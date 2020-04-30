using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesLibrary
{
    /// <summary>
    /// Default implementation
    /// </summary>
    public partial class AddView : Form
    {
        /// <summary>
        /// Default implementation
        /// </summary>
        public AddView()
        {
            InitializeComponent();
        }

        // The add view should only show the inputs required based on the table that was open, if game was open it shows everything except country, if genre/console just name, if publisher/dev name and country
    }
}
