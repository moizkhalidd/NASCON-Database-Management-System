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
    public partial class Form26 : Form
    {
        private int userId;
        public Form26(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            string query = "SELECT EVE.EventID, EVE.Name AS EVENTNAME, EVE.Description,EVE.Start_Date_Time, EVE.End_Date_Time,EVE.Category,EVE.Rules, EVE.Max_Participants, EVE.RegistrationFee, V.Name AS VENUENAME, V.Location, V.Type " +
                "FROM JUDGE_EVALUATION JE " +
                "JOIN EVALUATION EV ON JE.EvaluationID = EV.EvaluationID " +
                "JOIN EVENT EVE ON EV.EventID = EVE.EventID " +
                "JOIN VENUE V ON EVE.VenueID = V.VenueID " +
                "WHERE JE.JudgeID = @userId;";

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
