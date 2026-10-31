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
    public partial class Form46 : Form
    {
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form46()
        {
            InitializeComponent();
        }

        private void Form46_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            string query = "SELECT E1.EventID AS Event1_ID,E1.Name AS Event1_Name, E1.Start_Date_Time AS Event1_Start, E1.End_Date_Time AS Event1_End, E2.EventID AS Event2_ID, E2.Name AS Event2_Name,  E2.Start_Date_Time AS Event2_Start, E2.End_Date_Time AS Event2_End, V.VenueID, V.Name AS VenueName " +
                "FROM EVENT E1 " +
                "JOIN EVENT E2 ON E1.VenueID = E2.VenueID " +
                "AND E1.EventID < E2.EventID " + // Avoid self and duplicate comparisons
                "AND E1.Start_Date_Time < E2.End_Date_Time " +
                "AND E1.End_Date_Time > E2.Start_Date_Time " +
                "JOIN VENUE V ON E1.VenueID = V.VenueID;";

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
    }
}
