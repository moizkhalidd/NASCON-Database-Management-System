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
    public partial class Form33 : Form
    {
        private int userId;
        public Form33(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form33_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string method = comboBox1.SelectedItem?.ToString();
            string paymentFor = comboBox2.SelectedItem?.ToString(); // "EVENT" or "ACCOMMODATION"
            string amountText = textBox2.Text.Trim();
            string eventIdText = textBox5.Text.Trim();

            if (string.IsNullOrEmpty(method) || string.IsNullOrEmpty(paymentFor) || string.IsNullOrEmpty(amountText) ||
                (paymentFor == "EVENT" && string.IsNullOrEmpty(eventIdText)))
            {
                MessageBox.Show("Please fill all required fields.");
                Form30 dashboard12 = new Form30(userId);
                dashboard12.StartPosition = FormStartPosition.CenterScreen;
                dashboard12.Show();
                this.Close();
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount))
            {
                MessageBox.Show("Invalid amount.");
                Form30 dashboard12 = new Form30(userId);
                dashboard12.StartPosition = FormStartPosition.CenterScreen;
                dashboard12.Show();
                this.Close();
                return;
            }

            int? eventId = null;
            int? accommodationId = null;

            if (paymentFor == "EVENT")
            {
                if (!int.TryParse(eventIdText, out int parsedEventId))
                {
                    MessageBox.Show("Invalid Event ID.");
                    Form30 dashboard12 = new Form30(userId);
                    dashboard12.StartPosition = FormStartPosition.CenterScreen;
                    dashboard12.Show();
                    this.Close();
                    return;
                }
                eventId = parsedEventId;
            }

            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (paymentFor == "EVENT")
                    {
                        // ✅ Check if user is participating in the event
                        string participationQuery = "SELECT COUNT(*) FROM TEAM_PARTICIPATION WHERE UserID = @UserID AND EventID = @EventID;";
                        using (MySqlCommand cmd = new MySqlCommand(participationQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            cmd.Parameters.AddWithValue("@EventID", eventId.Value);
                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count == 0)
                            {
                                MessageBox.Show("You are not participating in this event.");
                                Form30 dashboard12 = new Form30(userId);
                                dashboard12.StartPosition = FormStartPosition.CenterScreen;
                                dashboard12.Show();
                                this.Close();
                                return;
                            }
                        }

                        // 🔍 Check if amount matches Event.RegistrationFee
                        string feeQuery = "SELECT RegistrationFee FROM EVENT WHERE EventID = @EventID;";
                        using (MySqlCommand cmd = new MySqlCommand(feeQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@EventID", eventId.Value);
                            object feeResult = cmd.ExecuteScalar();

                            if (feeResult != null && Convert.ToDecimal(feeResult) != amount)
                            {
                                MessageBox.Show("Entered amount does not match the registration fee for this event.");
                                Form30 dashboard12 = new Form30(userId);
                                dashboard12.StartPosition = FormStartPosition.CenterScreen;
                                dashboard12.Show();
                                this.Close();
                                return;
                            }
                        }
                    }
                    else if (paymentFor == "ACCOMMODATION")
                    {
                        // ✅ Get AccommodationID
                        string accQuery = "SELECT A.AccommodationID, A.Rate FROM ACCOMMODATION A JOIN `USER` U ON A.AccommodationID = U.AccommodationID WHERE UserID = @UserID LIMIT 1;";
                        using (MySqlCommand cmd = new MySqlCommand(accQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    accommodationId = reader.GetInt32("AccommodationID");
                                    decimal rate = reader.GetDecimal("Rate");

                                    // 🔍 Check if amount matches Rate
                                    if (rate != amount)
                                    {
                                        MessageBox.Show("Entered amount does not match the accommodation rate.");
                                        Form30 dashboard12 = new Form30(userId);
                                        dashboard12.StartPosition = FormStartPosition.CenterScreen;
                                        dashboard12.Show();
                                        this.Close();
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No accommodation found for user.");
                                    Form30 dashboard12 = new Form30(userId);
                                    dashboard12.StartPosition = FormStartPosition.CenterScreen;
                                    dashboard12.Show();
                                    this.Close();
                                    return;
                                }
                            }
                        }
                    }

                    // ✅ Check if payment already exists
                    string checkQuery = "SELECT COUNT(*) FROM PAYMENT WHERE UserID = @UserID AND " +
                                        (paymentFor == "EVENT" ? "EventID = @EID" : "AccommodationID = @AID");

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@UserID", userId);
                        if (paymentFor == "EVENT")
                            checkCmd.Parameters.AddWithValue("@EID", eventId);
                        else
                            checkCmd.Parameters.AddWithValue("@AID", accommodationId);

                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (exists > 0)
                        {
                            MessageBox.Show("Payment already exists for this.");
                            Form30 dashboard12 = new Form30(userId);
                            dashboard12.StartPosition = FormStartPosition.CenterScreen;
                            dashboard12.Show();
                            this.Close();
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO PAYMENT (Amount, Method, UserID, EventID, AccommodationID) " +
                                         "VALUES (@Amount, @Method, @UserID, @EventID, @AccommodationID);";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@Amount", amount);
                        insertCmd.Parameters.AddWithValue("@Method", method);
                        insertCmd.Parameters.AddWithValue("@UserID", userId);
                        insertCmd.Parameters.AddWithValue("@EventID", eventId.HasValue ? (object)eventId.Value : DBNull.Value);
                        insertCmd.Parameters.AddWithValue("@AccommodationID", accommodationId.HasValue ? (object)accommodationId.Value : DBNull.Value);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Payment recorded successfully.");
                        else
                            MessageBox.Show("Failed to record payment.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            Form30 dashboard1 = new Form30(userId);
            dashboard1.StartPosition = FormStartPosition.CenterScreen;
            dashboard1.Show();
            this.Close();

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
