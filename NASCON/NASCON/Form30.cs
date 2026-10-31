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
    public partial class Form30 : Form
    {
        private int userId;
        public Form30(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string countEventsQuery = "SELECT COUNT(DISTINCT EventID) FROM TEAM_PARTICIPATION WHERE UserID = @UserID;";
                using (MySqlCommand countCmd = new MySqlCommand(countEventsQuery, connection))
                {
                    countCmd.Parameters.AddWithValue("@UserID", userId);
                    object result = countCmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int eventCount))
                    {
                        textBox9.Text = eventCount.ToString(); // Assuming this TextBox exists
                    }
                    else
                    {
                        textBox9.Text = "0";
                    }
                }


                string countTeamQuery = "SELECT COUNT(DISTINCT TeamID) FROM TEAM_PARTICIPATION WHERE UserID = @UserID;";
                using (MySqlCommand countCmd = new MySqlCommand(countTeamQuery, connection))
                {
                    countCmd.Parameters.AddWithValue("@UserID", userId);
                    object result = countCmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int eventCount))
                    {
                        textBox10.Text = eventCount.ToString(); // Assuming this TextBox exists
                    }
                    else
                    {
                        textBox10.Text = "0";
                    }
                }

                string countAccQuery = @"
                SELECT A.Location 
                FROM ACCOMMODATION A 
                JOIN `USER` U ON A.AccommodationID = U.AccommodationID 
                WHERE U.UserID = @UserID;
                ";

                using (MySqlCommand countCmd = new MySqlCommand(countAccQuery, connection))
                {
                    countCmd.Parameters.AddWithValue("@UserID", userId);
                    object result = countCmd.ExecuteScalar();
                    if (result != null)
                    {
                        textBox12.Text = result.ToString(); // Assuming this TextBox exists
                    }
                    else
                    {
                        textBox12.Text = "No Accommodation";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form31 form31 = new Form31(userId);
            Form31 dashboard = new Form31(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form32 form31 = new Form32(userId);
            Form32 dashboard = new Form32(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form33 form33 = new Form33(userId);
            Form33 dashboard = new Form33(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form34 form34 = new Form34(userId);
            Form34 dashboard = new Form34(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form35 form35 = new Form35(userId);
            Form35 dashboard = new Form35(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form36 form36 = new Form36(userId);
            Form36 dashboard = new Form36(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form47 form36 = new Form47();
            Form47 dashboard = new Form47();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }
    }
}
