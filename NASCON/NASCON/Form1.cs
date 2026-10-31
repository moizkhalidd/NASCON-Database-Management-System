using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
namespace NASCON
{
    public partial class Form1 : Form
    {
        private readonly string credentialsFile = "user_credentials.txt";
        public Form1()
        {
            InitializeComponent();
            LoadCredentials();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox10.Text;
            string password = textBox9.Text;
            int userId = -1;
            string role = "";

            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to get UserID and Role
                    string getUserQuery = "SELECT UserID, Role FROM USER WHERE Email = @username AND Password = @password";
                    MySqlCommand cmd = new MySqlCommand(getUserQuery, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userId = reader.GetInt32("UserID");
                            role = reader.GetString("Role");
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password.");
                            return;
                        }
                    }

                    // Save or clear credentials
                    if (checkBox1.Checked)
                        SaveCredentials(username, password);
                    else
                        ClearCredentials();

                    // Redirect based on role
                    if (role == "Admin" || role == "ADMIN")
                    {
                        Form2 dashboard = new Form2(userId);
                        dashboard.StartPosition = FormStartPosition.CenterScreen;
                        dashboard.Show();
                        this.Hide();
                    }
                    else if (role == "Organizer" || role == "ORGANIZER")
                    {
                        Form11 dashboard = new Form11(userId);
                        dashboard.StartPosition = FormStartPosition.CenterScreen;
                        dashboard.Show();
                        this.Hide();
                    }
                    else if (role == "Sponsor" || role == "SPONSOR")
                    {
                        Form21 dashboard = new Form21(userId);
                        dashboard.StartPosition = FormStartPosition.CenterScreen;
                        dashboard.Show();
                        this.Hide();
                    }
                    else if (role == "Judge" || role == "JUDGE")
                    {
                        Form25 dashboard = new Form25(userId);
                        dashboard.StartPosition = FormStartPosition.CenterScreen;
                        dashboard.Show();
                        this.Hide();
                    }
                    else if (role == "Participant" || role == "PARTICIPANT")
                    {
                        Form30 dashboard = new Form30(userId);
                        dashboard.StartPosition = FormStartPosition.CenterScreen;
                        dashboard.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoadCredentials()
        {
            if (File.Exists(credentialsFile))
            {
                string[] credentials = File.ReadAllLines(credentialsFile);
                if (credentials.Length == 2)
                {
                    textBox10.Text = credentials[0]; // Load saved username
                    textBox9.Text = credentials[1]; // Load saved password
                    checkBox1.Checked = true;  // Check the "Remember Me" box
                }
            }
        }

        private void ClearCredentials()
        {
            if (File.Exists(credentialsFile))
            {
                File.Delete(credentialsFile);
            }
        }

        private void SaveCredentials(string username, string password)
        {
            File.WriteAllText(credentialsFile, $"{username}\n{password}");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form41 dashboard = new Form41();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = textBox10.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            string query = "SELECT Password FROM USER WHERE Email = @username OR Name = @username";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string password = result.ToString();

                            string masked = "";

                            for (int i = 0; i < password.Length; i++)
                            {
                                if (i % 2 == 0)
                                    masked += password[i];
                                else
                                    masked += '*';
                            }

                            MessageBox.Show($"Password hint: {masked}");
                        }
                        else
                        {
                            MessageBox.Show("No user found with this username.");
                        }
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
