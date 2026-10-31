using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NASCON
{
    public partial class Form10 : Form
    {
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            string query = "SELECT u.UserID, u.Name AS ORGANIZERNAME, u.Email, o.Type, " +
               "(SELECT Name FROM EVENT e WHERE e.EventID = o.EventID) AS EVENTNAME, " +
               "(SELECT Name FROM USER su WHERE su.UserID = (SELECT s.UserID FROM SPONSOR s WHERE s.SponsorID = o.SponsorID)) AS SPONSORNAME, " +
               "(SELECT Name FROM VENUE v WHERE v.VenueID = o.VenueID) AS VENUE, " +
               "(SELECT Location FROM ACCOMMODATION a WHERE a.AccommodationID = o.AccommodationID) AS ACCOMMODATION " +  // <-- space added here
               "FROM ORGANIZER o JOIN USER u ON o.UserID = u.UserID";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    adapter = new MySqlDataAdapter(query, cnn);

                    // Auto-generate INSERT, UPDATE, DELETE commands
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                    dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
