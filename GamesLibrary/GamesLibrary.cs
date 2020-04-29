using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class GamesLibrary : Form
    {
        /// <summary>
        /// global variables used for testing
        /// </summary>
        static string ferncon = "Data Source=OMNIUS\\SQLEXPRESS;Initial Catalog=TeamProject;Integrated Security=True";
        static string scottcon = "Data Source=PC\\SQLEXPRESS;Initial Catalog=TeamProject;Integrated Security=True";
        static string zackcon = "Data Source=LAPTOP-DEHCVF5M\\SQLEXPRESS;Initial Catalog=Master;Integrated Security=True";
        SqlConnection connection = new SqlConnection(ferncon);
        SqlDataAdapter adapter = new SqlDataAdapter();
        string query = "select * from GamesLibrary.Games";
        public DataSet dataset = new DataSet();
        public BindingSource bs = new BindingSource();
        /// <summary>
        /// Default implementation
        /// </summary>
        public GamesLibrary()
        {
            InitializeComponent();
        }
        /// <summary>
        /// doesnt do anything, fernando added this
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GamesLibrary_Load(object sender, EventArgs e)
        {
            adapter.SelectCommand = new SqlCommand(query, connection);
            adapter.Fill(dataset);
            bs.DataSource = dataset;
            UX_Table.DataSource = bs;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
