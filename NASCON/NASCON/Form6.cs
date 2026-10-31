using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form6 : Form
    {
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            string query = "SELECT U.Name AS ParticipantName, U.Email,A.Location AS AccommodationLocation, T.Name AS TeamName," +
                "CASE " +
                "WHEN U.AccommodationID IS NULL THEN 'NA'" +
                "WHEN P.PaymentID IS NOT NULL THEN 'Paid' " +
                "ELSE 'Unpaid' " +
                "END AS AccommodationStatus " +
                "FROM USER U " +
                "LEFT JOIN TEAM_PARTICIPATION TP ON U.UserID = TP.UserID " +
                "LEFT JOIN TEAM T ON TP.TeamID = T.TeamID " +
                "LEFT JOIN ACCOMMODATION A ON U.AccommodationID = A.AccommodationID " +
                "LEFT JOIN PAYMENT P ON A.AccommodationID = P.AccommodationID AND U.UserID = P.UserID " +
                "WHERE U.Role = 'Participant'; ";

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
