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
        static string zackcon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TeamProject;Integrated Security=True";
        SqlConnection connection = new SqlConnection(zackcon);
        SqlDataAdapter adapter = new SqlDataAdapter();
        string query = "SELECT g.Name AS 'Genre Name' FROM GamesLibrary.Genre g";
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
            UX_Table.DataSource = GetDataSource(query);
        }

        private DataTable GetDataSource(string sql)
        {
            DataTable table = new DataTable();
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            UX_Table.DataSource = table;
            connection.Close();

            return table;
        }

        private void UX_GamesButton_Click(object sender, EventArgs e)
        {
            UX_Table.DataSource = GetDataSource("SELECT g.Name AS 'Genre Name' FROM GamesLibrary.Genre g");
        }

        private void UX_PublisherButton_Click(object sender, EventArgs e)
        {
            UX_Table.DataSource = GetDataSource("SELECT p.Name AS 'Publisher Name' FROM GamesLibrary.Publisher p");
        }

        private void UX_DeveloperButton_Click(object sender, EventArgs e)
        {
            UX_Table.DataSource = GetDataSource("SELECT d.Name AS 'Developer Name' FROM GamesLibrary.Developer d");
        }
    }
}
