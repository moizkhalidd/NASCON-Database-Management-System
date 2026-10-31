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
    public partial class Form25 : Form
    {
        private int userId;
        public Form25(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form25_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = " SELECT COUNT(DISTINCT E.EventID) AS TotalEvents " +
                        "FROM JUDGE_EVALUATION JE " +
                        "JOIN EVALUATION E ON JE.EvaluationID = E.EvaluationID " +
                        "WHERE JE.JudgeID = @userId;";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int totalEvents = Convert.ToInt32(result);
                        textBox9.Text = totalEvents.ToString();
                    }

                    string teamQuery = "SELECT COUNT(DISTINCT E.TeamID) AS TotalTeams " +
                               "FROM JUDGE_EVALUATION JE " +
                               "JOIN EVALUATION E ON JE.EvaluationID = E.EvaluationID " +
                               "WHERE JE.JudgeID = @userId;";

                    MySqlCommand teamCmd = new MySqlCommand(teamQuery, connection);
                    teamCmd.Parameters.AddWithValue("@userId", userId);

                    object teamResult = teamCmd.ExecuteScalar();

                    if (teamResult != null && teamResult != DBNull.Value)
                    {
                        int totalTeams = Convert.ToInt32(teamResult);
                        textBox10.Text = totalTeams.ToString();  // Total Teams (you can change the textbox as needed)
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form26 form26 = new Form26(userId);
            Form26 dashboard = new Form26(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form27 form27 = new Form27(userId);
            Form27 dashboard = new Form27(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form28 form28 = new Form28(userId);
            Form28 dashboard = new Form28(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
