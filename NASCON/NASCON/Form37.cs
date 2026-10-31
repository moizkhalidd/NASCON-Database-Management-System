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
    public partial class Form37 : Form
    {
        decimal eventID;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form37(decimal eventID)
        {
            InitializeComponent();
            this.eventID = eventID;
        }

        private void Form37_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            string query = "SELECT " +
            "u.UserID, " +
            "u.Name AS ParticipantName, " +
            "u.Email, " +
            "E.Name AS EventName, " +
            "T.Name AS TeamName, " +
            "A.Location AS AccommodationLocation, " +
            "CASE " +
            "WHEN P.PaymentID IS NOT NULL THEN 'Paid' " +
            "ELSE 'Unpaid' " +
            "END AS PaymentStatus " +
            "FROM USER u " +
            "JOIN TEAM_PARTICIPATION TP ON u.UserID = TP.UserID " +
            "JOIN EVENT E ON TP.EventID = E.EventID " +
            "JOIN TEAM T ON TP.TeamID = T.TeamID " +
            "LEFT JOIN ACCOMMODATION A ON u.AccommodationID = A.AccommodationID " +
            "LEFT JOIN PAYMENT P ON u.UserID = P.UserID AND P.EventID = E.EventID " +
            "WHERE TP.EventID = @eventId";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@eventId", eventID); // Pass the event ID to the query

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

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
