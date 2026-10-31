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
    public partial class Form24 : Form
    {
        private int userId;
        public Form24(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form24_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            Form17 dashboard5 = new Form17();
            dashboard5.StartPosition = FormStartPosition.CenterScreen;
            dashboard5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string eventIdText = textBox2.Text.Trim();
            string fundsText = textBox4.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(eventIdText) || string.IsNullOrEmpty(fundsText) || !int.TryParse(eventIdText, out int eventId) || !decimal.TryParse(fundsText, out decimal funds))
            {
                MessageBox.Show("Please enter valid EventID and Funds.");
                Form21 form211 = new Form21(userId);
                Form21 dashboard1 = new Form21(userId);
                dashboard1.StartPosition = FormStartPosition.CenterScreen;
                dashboard1.Show();
                this.Close();
                return;
            }

            // Fetch sponsor category for the given EventID
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Get the current EventID and Category for the sponsor
                    string categoryQuery = "SELECT Category, EventID FROM SPONSOR WHERE EventID = @EventID";
                    MySqlCommand categoryCmd = new MySqlCommand(categoryQuery, connection);
                    categoryCmd.Parameters.AddWithValue("@EventID", eventId);

                    using (MySqlDataReader reader = categoryCmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No sponsor found for the given EventID.");
                            Form21 form211 = new Form21(userId);
                            Form21 dashboard1 = new Form21(userId);
                            dashboard1.StartPosition = FormStartPosition.CenterScreen;
                            dashboard1.Show();
                            this.Close();
                            return;
                        }

                        reader.Read();

                        // Check if EventID is NULL
                        object currentEventId = reader["EventID"];
                        if (currentEventId != DBNull.Value)
                        {
                            MessageBox.Show("This sponsor is already associated with an Event. Can't update the EventID.");
                            Form21 form211 = new Form21(userId);
                            Form21 dashboard1 = new Form21(userId);
                            dashboard1.StartPosition = FormStartPosition.CenterScreen;
                            dashboard1.Show();
                            this.Close();
                            return;
                        }

                        // Get sponsor category
                        string category = reader["Category"].ToString();

                        // Validate funds based on sponsor category
                        if ((category == "Title Sponsor" && funds <= 100000) ||
                            (category == "Gold Sponsor" && funds <= 50000) ||
                            (category == "Silver Sponsor" && funds <= 25000) ||
                            (category == "Media Partner" && funds <= 15000))
                        {
                            MessageBox.Show($"For {category}, funds must be greater than the minimum required amount.");
                            Form21 form211 = new Form21(userId);
                            Form21 dashboard1 = new Form21(userId);
                            dashboard1.StartPosition = FormStartPosition.CenterScreen;
                            dashboard1.Show();
                            this.Close();
                            return;
                        }

                        // Update the sponsor funds if all checks pass
                        reader.Close();  // Close the previous reader to execute the update query

                        string updateQuery = "UPDATE SPONSOR SET Funds = @Funds WHERE EventID = @EventID";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                        updateCmd.Parameters.AddWithValue("@Funds", funds);
                        updateCmd.Parameters.AddWithValue("@EventID", eventId);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sponsor funds updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update sponsor funds.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            Form21 form2112 = new Form21(userId);
            Form21 dashboard12 = new Form21(userId);
            dashboard12.StartPosition = FormStartPosition.CenterScreen;
            dashboard12.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
