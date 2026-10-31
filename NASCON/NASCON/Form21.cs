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
    public partial class Form21 : Form
    {
        private int userId;
        public Form21(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            loadDetails();
        }
        private void loadDetails()
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT E.Name " +
                                   "FROM SPONSOR S " +
                                   "JOIN EVENT E ON S.EventID = E.EventID " +
                                   "WHERE S.UserID = @userId";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userId", userId); // Replace `userId` with actual sponsor's UserID

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        textBox9.Text = result.ToString();
                    }
                    else
                    {
                        textBox9.Text = "No Event Assigned";
                    }


                    query = "SELECT Category " +
                                   "FROM SPONSOR " +
                                   "WHERE UserID = @userId";

                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userId", userId); // Replace `userId` with actual sponsor's UserID

                    result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        textBox10.Text = result.ToString();
                    }
                    else
                    {
                        textBox10.Text = "No Event Assigned";
                    }

                    query = "SELECT Funds " +
                                   "FROM SPONSOR " +
                                   "WHERE UserID = @userId";

                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userId", userId); // Replace `userId` with actual sponsor's UserID

                    result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        textBox12.Text = result.ToString();
                    }
                    else
                    {
                        textBox12.Text = "No Event Assigned";
                    }

                    query = "SELECT P.Status " +
                      "FROM PAYMENT P " +
                      "JOIN SPONSOR S ON P.UserID = S.UserID " +
                      "WHERE S.UserID = @userId";

                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userId", userId); // Sponsor's UserID

                    result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        textBox14.Text = result.ToString();
                    }
                    else
                    {
                        textBox14.Text = "No Payment Found";
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form22 form21 = new Form22(userId);
            Form22 dashboard = new Form22(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form23 form23 = new Form23(userId);
            Form23 dashboard = new Form23(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 form24 = new Form24(userId);
            Form24 dashboard = new Form24(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();
        }
    }
}
