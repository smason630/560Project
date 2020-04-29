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
        static string scottcon = "Data Source=PC\\SQLEXPRESS;Initial Catalog=TeamProject;Integrated Security=True";
        static string ferncon = "Data Source=OMNIUS\\SQLEXPRESS;Initial Catalog=TeamProject;Integrated Security=True";
        static string zackcon = "Data Source=LAPTOP-DEHCVF5M\\SQLEXPRESS;Initial Catalog=TeamProject;Integrated Security=True";
        SqlConnection connection = new SqlConnection(scottcon);
        SqlDataAdapter adapter = new SqlDataAdapter();
        string query = "select * from GamesLibrary.Games";
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
            UX_Table.DataSource = GetDataSource();
        }

        private DataTable GetDataSource()
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable table = new DataTable();
            using (connection)
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
            }
            return table;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UX_ResetButton_Click(object sender, EventArgs e)
        {
        }
    }
}
