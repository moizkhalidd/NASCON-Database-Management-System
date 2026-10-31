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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NASCON
{
    public partial class Form40 : Form
    {
        private int userId;
        private string email;
        private int pg;
        public Form40(int userId, string email, int pg)
        {
            InitializeComponent();
            this.userId = userId;
            this.email = email;
            this.pg = pg;
        }

        private void Form40_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            Form17 dashboard = new Form17();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            Form18 dashboard = new Form18();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            Form19 dashboard = new Form19();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form20 form19 = new Form20();
            Form20 dashboard = new Form20();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void deleteOrg()
        {
            string deleteQuery = "DELETE FROM USER WHERE UserID = @UserID AND Email = @Email";

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=NASCON;uid=root;pwd=Moiz2004;"))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            string type = textBox2.Text.Trim();
            string eventIdText = textBox3.Text.Trim();
            string VenueIdText = textBox5.Text.Trim();
            string AccIdText = textBox8.Text.Trim();
            string SponsorIdText = textBox9.Text.Trim();

            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please fill all the required fields.");
                if (pg == 2)
                {
                    Form2 form22 = new Form2(userId);
                    Form2 dashboard2 = new Form2(userId);
                    dashboard2.StartPosition = FormStartPosition.CenterScreen;
                    dashboard2.Show();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
                return;
            }


            if(!int.TryParse(eventIdText, out int eventId))
             eventId = 0;  // Optional

            if (!int.TryParse(VenueIdText, out int venueId))
                venueId = 0;

            if (!int.TryParse(AccIdText, out int accId))
                accId = 0;

            if (!int.TryParse(SponsorIdText, out int spId))
                spId = 0;

            // Check constraints

            string insertQuery = "INSERT INTO ORGANIZER (Type, UserID, SponsorID, EventID, VenueID, AccommodationID) " +
                     "VALUES (@Type, @UserID, @SponsorID, @EventID, @VenueID, @AccommodationID)";

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=NASCON;uid=root;pwd=Moiz2004;"))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@SponsorID", spId > 0 ? (object)spId : DBNull.Value);
                        cmd.Parameters.AddWithValue("@EventID", eventId > 0 ? (object)eventId : DBNull.Value);
                        cmd.Parameters.AddWithValue("@VenueID", venueId > 0 ? (object)venueId : DBNull.Value);
                        cmd.Parameters.AddWithValue("@AccommodationID", accId > 0 ? (object)accId : DBNull.Value);

                        cmd.ExecuteNonQuery();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Organizer added successfully.");
                        else
                        {
                            MessageBox.Show("Failed to add Organizer.");
                            deleteOrg();
                        }
                    }
                 }
                    catch (MySqlException ex)
                    {
                        if (ex.Message.Contains("Duplicate entry"))
                            MessageBox.Show("This user is already registered as an Organizer.");
                        else
                            MessageBox.Show("Database error: " + ex.Message);
                        deleteOrg();
                    }
                }


            if (pg == 2)
            {
                Form2 form22 = new Form2(userId);
                Form2 dashboard2 = new Form2(userId);
                dashboard2.StartPosition = FormStartPosition.CenterScreen;
                dashboard2.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
