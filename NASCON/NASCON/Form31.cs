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
    public partial class Form31 : Form
    {
        private int userId;
        public Form31(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form31_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            string query = @"SELECT E.*, V.Name, v.Location, V.Type, 
            CASE 
            WHEN P.PaymentID IS NULL THEN 'Unpaid'
            ELSE 'Paid'
            END AS PaymentStatus
            FROM TEAM_PARTICIPATION TP
            JOIN EVENT E ON TP.EventID = E.EventID
            LEFT JOIN VENUE V ON E.VenueID = V.VenueID
            LEFT JOIN PAYMENT P ON TP.UserID = P.UserID AND TP.EventID = P.EventID
            WHERE TP.UserID = @userId";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@userId", userId);
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
    }
}
