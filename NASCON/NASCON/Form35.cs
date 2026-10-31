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
    public partial class Form35 : Form
    {
        private int userId;
        public Form35(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form35_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form20 form19 = new Form20();
            Form20 dashboard = new Form20();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            string accommodationIdText = textBox2.Text.Trim();

            if (!int.TryParse(accommodationIdText, out int accommodationId))
            {
                MessageBox.Show("Invalid Accommodation ID.");
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

                    // Check if user already has an accommodation assigned
                    string checkQuery = "SELECT AccommodationID FROM `USER` WHERE UserID = @UserID;";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@UserID", userId);
                        object existingAccId = checkCmd.ExecuteScalar();

                        if (existingAccId != DBNull.Value && existingAccId != null)
                        {
                            MessageBox.Show("User already has accommodation assigned.");
                            Form30 form303 = new Form30(userId);
                            Form30 dashboardz3 = new Form30(userId);
                            dashboardz3.StartPosition = FormStartPosition.CenterScreen;
                            dashboardz3.Show();
                            this.Close();
                            return;
                        }
                    }

                    // Update user's accommodation ID
                    string updateQuery = "UPDATE `USER` SET AccommodationID = @AccID WHERE UserID = @UserID;";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@AccID", accommodationId);
                        updateCmd.Parameters.AddWithValue("@UserID", userId);

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Accommodation assigned successfully.");
                        else
                            MessageBox.Show("Failed to assign accommodation.");
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
    }
}
