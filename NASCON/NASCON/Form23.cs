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
    public partial class Form23 : Form
    {
        private int userId;
        public Form23(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form23_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            Form17 dashboard = new Form17();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string method = comboBox1.SelectedItem?.ToString();
            string amountText = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(method) || string.IsNullOrEmpty(amountText))
            {
                MessageBox.Show("Please fill all fields.");
                Form21 form211 = new Form21(userId);
                Form21 dashboard1 = new Form21(userId);
                dashboard1.StartPosition = FormStartPosition.CenterScreen;
                dashboard1.Show();
                this.Close();
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount))
            {
                MessageBox.Show("Invalid amount.");
                Form21 form212 = new Form21(userId);
                Form21 dashboard2 = new Form21(userId);
                dashboard2.StartPosition = FormStartPosition.CenterScreen;
                dashboard2.Show();
                this.Close();
                return;
            }



            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Get Funds and EventID for the sponsor
                    string sponsorQuery = "SELECT Funds, EventID FROM SPONSOR WHERE UserID = @UserID;";
                    MySqlCommand sponsorCmd = new MySqlCommand(sponsorQuery, connection);
                    sponsorCmd.Parameters.AddWithValue("@UserID", userId);

                    using (MySqlDataReader reader = sponsorCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal requiredFunds = reader.GetDecimal("Funds");
                            int eventId = reader.GetInt32("EventID");

                            if (amount != requiredFunds)
                            {
                                MessageBox.Show("Entered amount does not match sponsor's required funds.");
                                Form21 form215 = new Form21(userId);
                                Form21 dashboard5 = new Form21(userId);
                                dashboard5.StartPosition = FormStartPosition.CenterScreen;
                                dashboard5.Show();
                                this.Close();
                                return;
                            }

                            reader.Close();

                            // Insert payment
                            string insertQuery = "INSERT INTO PAYMENT (Amount, Method, UserID, EventID) " +
                                                 "VALUES (@Amount, @Method, @UserID, @EventID);";

                            MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                            insertCmd.Parameters.AddWithValue("@Amount", amount);
                            insertCmd.Parameters.AddWithValue("@Method", comboBox1.SelectedItem?.ToString());
                            insertCmd.Parameters.AddWithValue("@UserID", userId);
                            insertCmd.Parameters.AddWithValue("@EventID", eventId);

                            int rowsAffected = insertCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Payment recorded successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to record payment.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sponsor data not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            Form21 form21 = new Form21(userId);
            Form21 dashboard = new Form21(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
