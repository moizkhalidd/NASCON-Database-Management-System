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
    public partial class Form36 : Form
    {
        private int userId;
        public Form36(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            Form17 dashboard = new Form17();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form29 form29 = new Form29();
            Form29 dashboard = new Form29();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";

            if (!int.TryParse(textBox2.Text.Trim(), out int eventId) || !int.TryParse(textBox3.Text.Trim(), out int teamId))
            {
                MessageBox.Show("Invalid EventID or TeamID.");
                Form30 form303 = new Form30(userId);
                Form30 dashboardz3 = new Form30(userId);
                dashboardz3.StartPosition = FormStartPosition.CenterScreen;
                dashboardz3.Show();
                this.Close();
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if EventID exists
                    string checkEventQuery = "SELECT COUNT(*) FROM EVENT WHERE EventID = @EventID;";
                    using (MySqlCommand checkEventCmd = new MySqlCommand(checkEventQuery, connection))
                    {
                        checkEventCmd.Parameters.AddWithValue("@EventID", eventId);
                        int eventExists = Convert.ToInt32(checkEventCmd.ExecuteScalar());

                        if (eventExists == 0)
                        {
                            MessageBox.Show("EventID does not exist.");
                            Form30 form303 = new Form30(userId);
                            Form30 dashboardz3 = new Form30(userId);
                            dashboardz3.StartPosition = FormStartPosition.CenterScreen;
                            dashboardz3.Show();
                            this.Close();
                            return;
                        }
                    }

                    // Check if TeamID exists
                    string checkTeamQuery = "SELECT COUNT(*) FROM TEAM WHERE TeamID = @TeamID;";
                    using (MySqlCommand checkTeamCmd = new MySqlCommand(checkTeamQuery, connection))
                    {
                        checkTeamCmd.Parameters.AddWithValue("@TeamID", teamId);
                        int teamExists = Convert.ToInt32(checkTeamCmd.ExecuteScalar());

                        if (teamExists == 0)
                        {
                            MessageBox.Show("TeamID does not exist.");
                            Form30 form303 = new Form30(userId);
                            Form30 dashboardz3 = new Form30(userId);
                            dashboardz3.StartPosition = FormStartPosition.CenterScreen;
                            dashboardz3.Show();
                            this.Close();
                            return;
                        }
                    }

                    // Check if user is already registered for this event with the same team
                    string checkParticipationQuery = "SELECT COUNT(*) FROM TEAM_PARTICIPATION WHERE UserID = @UserID AND EventID = @EventID AND TeamID = @TeamID;";
                    using (MySqlCommand checkParticipationCmd = new MySqlCommand(checkParticipationQuery, connection))
                    {
                        checkParticipationCmd.Parameters.AddWithValue("@UserID", userId);
                        checkParticipationCmd.Parameters.AddWithValue("@EventID", eventId);
                        checkParticipationCmd.Parameters.AddWithValue("@TeamID", teamId);
                        int alreadyExists = Convert.ToInt32(checkParticipationCmd.ExecuteScalar());

                        if (alreadyExists > 0)
                        {
                            MessageBox.Show("User is already participating in this event with the specified team.");
                        }
                        else
                        {

                            string insertParticipationQuery = "INSERT INTO TEAM_PARTICIPATION (UserID, EventID, TeamID) VALUES (@UserID, @EventID, @TeamID);";
                            using (MySqlCommand insertParticipationCmd = new MySqlCommand(insertParticipationQuery, connection))
                            {
                                insertParticipationCmd.Parameters.AddWithValue("@UserID", userId);
                                insertParticipationCmd.Parameters.AddWithValue("@EventID", eventId);
                                insertParticipationCmd.Parameters.AddWithValue("@TeamID", teamId);
                                insertParticipationCmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Registration Complete");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            Form30 form30 = new Form30(userId);
            Form30 dashboardz = new Form30(userId);
            dashboardz.StartPosition = FormStartPosition.CenterScreen;
            dashboardz.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";

            // Ask user for team name
            string teamName = Microsoft.VisualBasic.Interaction.InputBox("Enter Team Name:", "New Team", "");

            if (string.IsNullOrWhiteSpace(teamName))
            {
                MessageBox.Show("Team name cannot be empty.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if team name already exists
                    string checkQuery = "SELECT COUNT(*) FROM TEAM WHERE Name = @teamName;";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@teamName", teamName);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("This team name is already taken. Please choose another.");
                            return;
                        }
                    }

                    // Insert new team
                    string insertQuery = "INSERT INTO TEAM (Name) VALUES (@teamName);";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@teamName", teamName);
                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Team added successfully!");
                        else
                            MessageBox.Show("Failed to add the team.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
