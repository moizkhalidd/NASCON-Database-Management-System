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
    public partial class Form16 : Form
    {
        private int userId;
        public Form16(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
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
            Form18 form18 = new Form18();
            Form18 dashboard = new Form18();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            Form19 dashboard = new Form19();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form20 form19 = new Form20();
            Form20 dashboard = new Form20();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string type = comboBox1.SelectedItem?.ToString();
            string idText = textBox2.Text;

            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(idText))
            {
                MessageBox.Show("Please select a type and enter an ID.");
                Form11 form11z = new Form11(userId);
                Form11 dashboardz = new Form11(userId);
                dashboardz.StartPosition = FormStartPosition.CenterScreen;
                dashboardz.Show();
                this.Close();
                return;
            }

            if (!int.TryParse(idText, out int idValue))
            {
                MessageBox.Show("ID must be a valid integer.");
                Form11 form11z2 = new Form11(userId);
                Form11 dashboardz2 = new Form11(userId);
                dashboardz2.StartPosition = FormStartPosition.CenterScreen;
                dashboardz2.Show();
                this.Close();
                return;
            }

            string columnName = "";
            switch (type)
            {
                case "EVENT":
                    columnName = "EventID";
                    break;
                case "SPONSOR":
                    columnName = "SponsorID";
                    break;
                case "ACCOMMODATION":
                    columnName = "AccommodationID";
                    break;
                case "VENUE":
                    columnName = "VenueID";
                    break;
                default:
                    MessageBox.Show("Invalid type selected.");
                    Form11 form11y = new Form11(userId);
                    Form11 dashboardy = new Form11(userId);
                    dashboardy.StartPosition = FormStartPosition.CenterScreen;
                    dashboardy.Show();
                    this.Close();
                    return;
            }

            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the selected column is already set
                    string checkQuery = $"SELECT {columnName} FROM ORGANIZER WHERE UserID = @userId";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@userId", userId); // Ensure you have this variable set in the class

                    object result = checkCmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        MessageBox.Show($"{type} is already assigned to you!.");
                        Form11 formx = new Form11(userId);
                        Form11 dashboardx = new Form11(userId);
                        dashboardx.StartPosition = FormStartPosition.CenterScreen;
                        dashboardx.Show();
                        this.Close();
                        return;
                    }

                    // Update the organizer's column
                    string updateQuery = $"UPDATE ORGANIZER SET {columnName} = @idValue WHERE UserID = @userId";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                    updateCmd.Parameters.AddWithValue("@idValue", idValue);
                    updateCmd.Parameters.AddWithValue("@userId", userId); // Use the same userId here

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show($"{type} assigned successfully.");
                    else
                        MessageBox.Show("Update failed. Please check the user ID.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }



            }

            Form11 form11 = new Form11(userId);
            Form11 dashboard = new Form11(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }
    }
}
