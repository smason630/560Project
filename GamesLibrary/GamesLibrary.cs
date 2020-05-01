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
        //this should work but it doesn't....
        string query = "SELECT g.GameName AS 'Game Name', g.Rating, pg.PublishDate AS 'Publish Year', gen.GenreName AS 'Genre', c.ConsoleName AS 'Console', p.PublisherName AS 'Publisher Name', d.DeveloperName AS 'Developer Name' " +
            "FROM GamesLibrary.Games g " + "INNER JOIN GamesLibrary.Genre gen ON gen.GenreId = g.GenreId " + "INNER JOIN GamesLibrary.Console c ON c.ConsoleId = g.ConsoleId " +
            "INNER JOIN GamesLibrary.PublishedGame pg ON pg.GameId = g.GameId " + "INNER JOIN GamesLibrary.Publisher p ON p.PublisherId = pg.PublisherId " +
            "INNER JOIN GamesLibrary.Developer d ON d.DeveloperId = pg.DeveloperId " + "ORDER BY g.GameId";
        /// <summary>
        /// int used to see which table we are at for the search or add function
        /// </summary>
        public int state = 0;
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
            uxTable.DataSource = GetDataSource(query);
        }

        private DataTable GetDataSource(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(zackcon))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.FillSchema(table,SchemaType.Source);
                da.Fill(table);
            }

            return table;
        }

        private void UX_GamesButton_Click(object sender, EventArgs e)
        {
            state = 0;
            uxTable.DataSource = GetDataSource(query);
        }

        private void UX_PublisherButton_Click(object sender, EventArgs e)
        {
            state = 1;
            uxTable.DataSource = GetDataSource("SELECT p.PublisherName AS 'Publisher Name', p.Country AS 'Country of Origin' FROM GamesLibrary.Publisher p");
        }

        private void UX_DeveloperButton_Click(object sender, EventArgs e)
        {
            state = 2;
            uxTable.DataSource = GetDataSource("SELECT d.DeveloperName AS 'Developer Name', d.Country AS 'Country of Origin' FROM GamesLibrary.Developer d");
        }

        private void UX_SearchButton_Click(object sender, EventArgs e)
        {
            string search = UX_SearchBar.Text;
            //this switch might work for the search bar but it doesn't work now... not sure how to use a variable from c# in the sql command
            switch(state)
            {
                case 0:
                    uxTable.DataSource = GetDataSource("SELECT g.GameName AS 'Game Name', g.Rating, pg.PublishDate AS 'Publish Year', gen.GenreName AS 'Genre', c.ConsoleName AS 'Console', p.PublisherName AS 'Publisher Name', d.DeveloperName AS 'Developer Name' " +
                        "FROM GamesLibrary.Games g " + "INNER JOIN GamesLibrary.Genre gen ON gen.GenreId = g.GenreId " +
                        "INNER JOIN GamesLibrary.Console c ON c.ConsoleId = g.ConsoleId " +
                        "INNER JOIN GamesLibrary.PublishedGame pg ON pg.GameId = g.GameId " +
                        "INNER JOIN GamesLibrary.Publisher p ON p.PublisherId = pg.PublisherId " +
                        "INNER JOIN GamesLibrary.Developer d ON d.DeveloperId = pg.DeveloperId " +
                        "WHERE GameName LIKE '%" + search + "%' OR Rating LIKE '%" + search + "%' OR PublishDate LIKE '%" + search + "%' OR GenreName LIKE '%" + search + "%' OR ConsoleName LIKE '%" + search + "%' OR PublisherName LIKE '%" + search + "%' OR DeveloperName LIKE '%" + search + "%'");
                    break;
                case 1:
                    uxTable.DataSource = GetDataSource("SELECT p.PublisherName AS 'Publisher Name', p.Country AS 'Country of Origin' FROM GamesLibrary.Publisher p WHERE [PublisherName] LIKE '%" + search + "%' OR [Country] LIKE '%" + search + "%'");
                    break;
                case 2:
                    uxTable.DataSource = GetDataSource("SELECT d.DeveloperName AS 'Developer Name', d.Country AS 'Country of Origin' FROM GamesLibrary.Developer d WHERE [DeveloperName] LIKE '%" + search + "%' OR [Country] LIKE '%" + search + "%'");
                    break;
            }
        }

        private void UX_AddButton_Click(object sender, EventArgs e)
        {
            AddView addForm = new AddView(state);
            addForm.ShowDialog();
            this.Refresh();
        }

        private void UX_GenreDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxTable.DataSource = GetDataSource("SELECT g.GameName AS 'Game Name', g.Rating, pg.PublishDate AS 'Publish Year', gen.GenreName AS 'Genre', c.ConsoleName AS 'Console', p.PublisherName AS 'Publisher Name', d.DeveloperName AS 'Developer Name' " +
                        "FROM GamesLibrary.Games g " + "INNER JOIN GamesLibrary.Genre gen ON gen.GenreId = g.GenreId " +
                        "INNER JOIN GamesLibrary.Console c ON c.ConsoleId = g.ConsoleId " +
                        "INNER JOIN GamesLibrary.PublishedGame pg ON pg.GameId = g.GameId " +
                        "INNER JOIN GamesLibrary.Publisher p ON p.PublisherId = pg.PublisherId " +
                        "INNER JOIN GamesLibrary.Developer d ON d.DeveloperId = pg.DeveloperId WHERE GenreName LIKE '%" + UX_GenreDropDown.Text + "%'");
        }

        private void UX_ConsoleDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxTable.DataSource = GetDataSource("SELECT g.GameName AS 'Game Name', g.Rating, pg.PublishDate AS 'Publish Year', gen.GenreName AS 'Genre', c.ConsoleName AS 'Console', p.PublisherName AS 'Publisher Name', d.DeveloperName AS 'Developer Name' " +
                        "FROM GamesLibrary.Games g " + "INNER JOIN GamesLibrary.Genre gen ON gen.GenreId = g.GenreId " +
                        "INNER JOIN GamesLibrary.Console c ON c.ConsoleId = g.ConsoleId " +
                        "INNER JOIN GamesLibrary.PublishedGame pg ON pg.GameId = g.GameId " +
                        "INNER JOIN GamesLibrary.Publisher p ON p.PublisherId = pg.PublisherId " +
                        "INNER JOIN GamesLibrary.Developer d ON d.DeveloperId = pg.DeveloperId WHERE ConsoleName LIKE '%" + UX_ConsoleDropDown.Text + "%'");
        }
    }
}
