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
    public partial class Form11 : Form
    {
        private int userId;
        public Form11(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            LoadDetails();
        }

        private void LoadDetails()
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT E.Name " +
                                   "FROM ORGANIZER O " +
                                   "JOIN EVENT E ON O.EventID = E.EventID " +
                                   "WHERE O.UserID = @userId";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userId", userId); // Ensure `userId` is defined in your form

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        textBox9.Text = result.ToString();
                    }
                    else
                    {
                        textBox9.Text = "No Event Assigned";
                    }


                    query = "SELECT V.Name " +
               "FROM ORGANIZER O " +
               "JOIN VENUE V ON O.VenueID = V.VenueID " +
               "WHERE O.UserID = @userId";

                     cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userId", userId); // Make sure userId is set properly

                    result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        textBox10.Text = result.ToString();
                    }
                    else
                    {
                        textBox10.Text = "No Venue Assigned";
                    }

                    query = "SELECT U.Name " +
               "FROM ORGANIZER O " +
               "JOIN SPONSOR S ON O.SponsorID = S.SponsorID " +
               "JOIN USER U ON S.UserID = U.UserID " +
               "WHERE O.UserID = @userId";

                     cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userId", userId); // Ensure userId is valid

                    result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        textBox12.Text = result.ToString();
                    }
                    else
                    {
                        textBox12.Text = "No Sponsor Assigned";
                    }

                     query = "SELECT A.Location " +
               "FROM ORGANIZER O " +
               "JOIN ACCOMMODATION A ON O.AccommodationID = A.AccommodationID " +
               "WHERE O.UserID = @userId";

                     cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@userId", userId); // Ensure userId is defined and valid

                    result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        textBox14.Text = result.ToString();
                    }
                    else
                    {
                        textBox14.Text = "No Accommodation Assigned";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12(userId);
            Form12 dashboard = new Form12(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15(userId);
            Form15 dashboard = new Form15(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14(userId);
            Form14 dashboard = new Form14(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13(userId);
            Form13 dashboard = new Form13(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16(userId);
            Form16 dashboard = new Form16(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
