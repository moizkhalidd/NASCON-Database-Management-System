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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NASCON
{
    public partial class Form41 : Form
    {
        public Form41()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form41_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form20 form19 = new Form20();
            Form20 dashboard = new Form20();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();
            string password = textBox5.Text.Trim();
            string role = comboBox1.SelectedItem?.ToString();
            string accommodationText = textBox9.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all the required fields.");
                Form1 form22 = new Form1();
                Form1 dashboard2 = new Form1();
                dashboard2.StartPosition = FormStartPosition.CenterScreen;
                dashboard2.Show();
                this.Close();
                return;
            }

            int accommodationId = 0;
            bool hasAccommodation = int.TryParse(accommodationText, out accommodationId);

            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if user already exists
                    string checkQuery = "SELECT COUNT(*) FROM USER WHERE Email = @Email";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());


                    if (count > 0)
                    {
                        MessageBox.Show("A user with this email already exists.");
                        Form1 form22 = new Form1();
                        Form1 dashboard2 = new Form1();
                        dashboard2.StartPosition = FormStartPosition.CenterScreen;
                        dashboard2.Show();
                        this.Close();
                        return;
                    }
                    string insertQuery;

                    insertQuery = "INSERT INTO USER (Name, Email, Password, Role, AccommodationID) " +
                                        "VALUES (@Name, @Email, @Password, @Role, @AccommodationID)";


                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@Name", name);
                    insertCmd.Parameters.AddWithValue("@Email", email);
                    insertCmd.Parameters.AddWithValue("@Password", password);
                    insertCmd.Parameters.AddWithValue("@Role", role);
                    if (role == "PARTICIPANT")
                    {
                        if (hasAccommodation)
                            insertCmd.Parameters.AddWithValue("@AccommodationID", accommodationId);
                        else
                            insertCmd.Parameters.AddWithValue("@AccommodationID", DBNull.Value);
                    }
                    else
                        insertCmd.Parameters.AddWithValue("@AccommodationID", DBNull.Value);

                    insertCmd.ExecuteNonQuery();
                    long newUserID = insertCmd.LastInsertedId;

                    MessageBox.Show("Registered!.");

                    if (role == "SPONSOR")
                    {
                        Form39 form39 = new Form39(((int)newUserID), email, 1);
                        Form39 dashboard2 = new Form39(((int)newUserID), email, 1);
                        dashboard2.StartPosition = FormStartPosition.CenterScreen;
                        dashboard2.Show();
                        this.Close();
                    }
                    else if (role == "ORGANIZER")
                    {
                        Form40 form40 = new Form40(((int)newUserID), email, 1);
                        Form40 dashboard2 = new Form40(((int)newUserID), email, 1);
                        dashboard2.StartPosition = FormStartPosition.CenterScreen;
                        dashboard2.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (role != "SPONSOR" && role != "ORGANIZER")
            {
                this.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
