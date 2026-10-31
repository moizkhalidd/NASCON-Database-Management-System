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
    public partial class Form28 : Form
    {
        private int userId;
        public Form28(int userId)
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.userId = userId;
        }

        private void Form28_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            Form17 dashboard = new Form17();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form29 form29 = new Form29();
            Form29 dashboard = new Form29();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string eventRound = comboBox1.SelectedItem?.ToString();
            string eventIdText = textBox2.Text.Trim();
            string teamIdText = textBox4.Text.Trim();
            string scoreText = textBox5.Text.Trim();

            if (string.IsNullOrWhiteSpace(eventRound) || string.IsNullOrWhiteSpace(eventIdText) ||
                string.IsNullOrWhiteSpace(teamIdText) || string.IsNullOrWhiteSpace(scoreText))
            {
                MessageBox.Show("Please fill in all fields.");
                MessageBox.Show("Failed to insert evaluation.");
                Form25 form255 = new Form25(userId);
                Form25 dashboard5 = new Form25(userId);
                dashboard5.StartPosition = FormStartPosition.CenterScreen;
                dashboard5.Show();
                this.Close();
                return;
            }

            if (!int.TryParse(eventIdText, out int eventId) ||
                !int.TryParse(teamIdText, out int teamId) ||
                !int.TryParse(scoreText, out int score))
            {
                MessageBox.Show("EventID, TeamID, and Score must be valid integers.");
                MessageBox.Show("Failed to insert evaluation.");
                Form25 form255 = new Form25(userId);
                Form25 dashboard5 = new Form25(userId);
                dashboard5.StartPosition = FormStartPosition.CenterScreen;
                dashboard5.Show();
                this.Close();
                return;
            }

          
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM EVALUATION " +
                            "WHERE TeamID = @TeamID AND EventRound = @EventRound AND EventID = @EventID;";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@TeamID", teamId);
                    checkCmd.Parameters.AddWithValue("@EventRound", eventRound);
                    checkCmd.Parameters.AddWithValue("@EventID", eventId);

                    object checkResult = checkCmd.ExecuteScalar();

                    if (Convert.ToInt32(checkResult) > 0)
                    {
                        MessageBox.Show("This evaluation already exists.");
                        Form25 form255 = new Form25(userId);
                        Form25 dashboard5 = new Form25(userId);
                        dashboard5.StartPosition = FormStartPosition.CenterScreen;
                        dashboard5.Show();
                        this.Close();
                        return;
                    }


                    // Step 1: Insert into EVALUATION
                    string insertEvaluationQuery = "INSERT INTO EVALUATION (Score, TeamID, EventRound, EventID) " +
                                                   "VALUES (@Score, @TeamID, @EventRound, @EventID); SELECT LAST_INSERT_ID();";

                    MySqlCommand evalCmd = new MySqlCommand(insertEvaluationQuery, connection);
                    evalCmd.Parameters.AddWithValue("@Score", score);
                    evalCmd.Parameters.AddWithValue("@TeamID", teamId);
                    evalCmd.Parameters.AddWithValue("@EventRound", eventRound);
                    evalCmd.Parameters.AddWithValue("@EventID", eventId);

                    object evalIdObj = evalCmd.ExecuteScalar();
                    if (evalIdObj == null)
                    {
                        MessageBox.Show("Failed to insert evaluation.");
                        Form25 form255 = new Form25(userId);
                        Form25 dashboard5 = new Form25(userId);
                        dashboard5.StartPosition = FormStartPosition.CenterScreen;
                        dashboard5.Show();
                        this.Close();
                        return;
                    }

                    int evalId = Convert.ToInt32(evalIdObj);

                    // Step 2: Insert into JUDGE_EVALUATION
                    string insertJudgeEval = "INSERT INTO JUDGE_EVALUATION (EvaluationID, JudgeID) " +
                                             "VALUES (@EvaluationID, @JudgeID);";

                    MySqlCommand judgeCmd = new MySqlCommand(insertJudgeEval, connection);
                    judgeCmd.Parameters.AddWithValue("@EvaluationID", evalId);
                    judgeCmd.Parameters.AddWithValue("@JudgeID", userId);

                    int judgeResult = judgeCmd.ExecuteNonQuery();

                    if (judgeResult > 0)
                    {
                        MessageBox.Show("Evaluation successful.");
                    }
                    else
                    {
                        MessageBox.Show("Evaluation Failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            Form25 form25 = new Form25(userId);
            Form25 dashboardz = new Form25(userId);
            dashboardz.StartPosition = FormStartPosition.CenterScreen;
            dashboardz.Show();
            this.Close();
        }
    }
}
