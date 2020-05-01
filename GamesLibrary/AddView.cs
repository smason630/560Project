using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GamesLibrary
{
    /// <summary>
    /// Default implementation
    /// </summary>
    public partial class AddView : Form
    {
        static string scottcon = "Data Source=PC\\SQLEXPRESS;Initial Catalog=TeamProject;Integrated Security=True";
        int state;
        /// <summary>
        /// Default implementation
        /// </summary>
        public AddView(int passedState)
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(scottcon))
            {
                connection.Open();
                string st = "SELECT * FROM GamesLibrary.Genre";
                SqlCommand cmd = new SqlCommand(st, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    uxGenre.Items.Add(rdr[1].ToString());
                }
                rdr.Close();
                st = "SELECT Console.ConsoleName FROM GamesLibrary.Console";
                cmd = new SqlCommand(st, connection);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    uxConsole.Items.Add(rdr[0].ToString());
                }
                rdr.Close();
                st = "SELECT Developer.DeveloperName FROM GamesLibrary.Developer";
                cmd = new SqlCommand(st, connection);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    uxDeveloper.Items.Add(rdr[0].ToString());
                }
                rdr.Close();
                st = "SELECT Publisher.PublisherName FROM GamesLibrary.Publisher";
                cmd = new SqlCommand(st, connection);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    uxPublisher.Items.Add(rdr[0].ToString());
                }
                rdr.Close();
                st = "SELECT DISTINCT Publisher.Country FROM GamesLibrary.Publisher LEFT JOIN GamesLibrary.Developer ON Publisher.Country = Developer.Country";
                cmd = new SqlCommand(st, connection);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    uxCountry.Items.Add(rdr[0].ToString());
                }
            }
                state = passedState;
            if (state == 1 )
            {
                labelGenre.Visible = false;
                labelConsole.Visible = false;
                labelYear.Visible = false;
                labelDev.Visible = false;
                labelRating.Visible = false;
                uxGenre.Visible = false;
                uxConsole.Visible = false;
                uxYear.Visible = false;
                uxDeveloper.Visible = false;
                uxRating.Visible = false;

                labelPub.Location = new Point(66,33);
                uxPublisher.Location = new Point(44, 50);
                uxSubmit.Location = new Point(62, 240);
            }
            else if(state == 2)
            {
                labelGenre.Visible = false;
                labelConsole.Visible = false;
                labelYear.Visible = false;
                labelPub.Visible = false;
                labelRating.Visible = false;
                uxGenre.Visible = false;
                uxConsole.Visible = false;
                uxYear.Visible = false;
                uxPublisher.Visible = false;
                uxRating.Visible = false;

                labelDev.Location = new Point(66, 33);
                uxDeveloper.Location = new Point(44, 50);
                uxSubmit.Location = new Point(62, 240);
            }
            if (state == 1 || state == 2)
            {
                this.Width = 207;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(scottcon))
            {
                connection.Open();
                if (state == 1)
                {
                    string st = "INSERT GamesLibrary.Publisher(PublisherName, Country) VALUES (@name, @country)";
                    SqlCommand cmd = new SqlCommand(st, connection);
                    cmd.Parameters.AddWithValue("@name", uxPublisher.Text);
                    cmd.Parameters.AddWithValue("@country", uxCountry.Text);
                    cmd.ExecuteNonQuery();
                }
                else if (state == 2)
                {
                    string st = "INSERT GamesLibrary.Developer(DeveloperName, Country) VALUES (@name, @country)";
                    SqlCommand cmd = new SqlCommand(st, connection);
                    cmd.Parameters.AddWithValue("@name", uxDeveloper.Text);
                    cmd.Parameters.AddWithValue("@country", uxCountry.Text);
                    cmd.ExecuteNonQuery();
                }
                else if (state == 0)
                {
                    string st = "INSERT GamesLibrary.Games(GameName, GenreId, ConsoleId, Rating) VALUES(@Name, @GenreId, @ConsoleId, @Rating)";
                    SqlCommand cmd = new SqlCommand(st, connection);
                    cmd.Parameters.AddWithValue("@Name", uxName.Text);
                    cmd.Parameters.AddWithValue("@GenreId", uxGenre.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@ConsoleId", uxConsole.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@Rating", uxRating.SelectedIndex);
                    cmd.ExecuteNonQuery();

                    string gameId = "SELECT TOP 1(Games.GameId) FROM GamesLibrary.Games ORDER BY GameId DESC";
                    SqlCommand command = new SqlCommand(gameId, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    int game = 0;
                    while (reader.Read())
                    {
                        game = (int)reader[0];
                    }
                    reader.Close();

                    st = "INSERT GamesLibrary.PublishedGame(DeveloperId, PublisherId, GameId, PublishDate) VALUES(@DeveloperId, @PublisherId, @GameId, @PublishDate)";
                    cmd = new SqlCommand(st, connection);
                    cmd.Parameters.AddWithValue("@DeveloperId", uxDeveloper.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@PublisherId", uxPublisher.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@GameId", game);
                    cmd.Parameters.AddWithValue("@PublishDate", Convert.ToInt32(uxYear.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            this.Close();
        }
        //publisher, dev, genre, console
        //game
        //publishedgame
        // The add view should only show the inputs required based on the table that was open, if game was open it shows everything except country, if genre/console just name, if publisher/dev name and country
    }
}
