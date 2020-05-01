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
            state = passedState;
            InitializeComponent();
            if (state == 1 )
            {
                labelGenre.Visible = false;
                labelConsole.Visible = false;
                labelYear.Visible = false;
                labelDev.Visible = false;
                uxGenre.Visible = false;
                uxConsole.Visible = false;
                uxYear.Visible = false;
                uxDev.Visible = false;

                labelPub.Location = new Point(66,33);
                uxPub.Location = new Point(55, 50);
                uxSubmit.Location = new Point(62, 240);
            }
            else if(state == 2)
            {
                labelGenre.Visible = false;
                labelConsole.Visible = false;
                labelYear.Visible = false;
                labelPub.Visible = false;
                uxGenre.Visible = false;
                uxConsole.Visible = false;
                uxYear.Visible = false;
                uxPub.Visible = false;

                labelDev.Location = new Point(66, 33);
                uxDev.Location = new Point(55, 50);
                uxSubmit.Location = new Point(62, 240);
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
                    cmd.Parameters.AddWithValue("@name", uxPub.Text);
                    cmd.Parameters.AddWithValue("@country", uxCountry.Text);
                    cmd.ExecuteNonQuery();
                }
                else if (state == 2)
                {
                    string st = "INSERT GamesLibrary.Developer(DeveloperName, Country) VALUES (@name, @country)";
                    SqlCommand cmd = new SqlCommand(st, connection);
                    cmd.Parameters.AddWithValue("@name", uxDev.Text);
                    cmd.Parameters.AddWithValue("@country", uxCountry.Text);
                    cmd.ExecuteNonQuery();
                }
                else if (state == 0)
                {
                    try
                    {
                        string st = "SELECT g.GenreName FROM GamesLibrary.Genre g WHERE GenreName LIKE '%"+uxGenre.Text+"%'";
                        SqlCommand cmd = new SqlCommand(st, connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            MessageBox.Show(reader.GetString(0));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("something broke");
                    }
                }
            }
        }
        //publisher, dev, genre, console
        //game
        //publishedgame
        // The add view should only show the inputs required based on the table that was open, if game was open it shows everything except country, if genre/console just name, if publisher/dev name and country
    }
}
