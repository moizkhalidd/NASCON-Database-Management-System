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
    public partial class Form39 : Form
    {
        private int userId;
        private string email;
        private int pg;
        public Form39(int userId, string email, int pg)
        {
            InitializeComponent();
            this.userId = userId;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.email = email;
            this.pg = pg;
        }

        private void Form39_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            Form17 dashboard = new Form17();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
        }

        private void deleteSponsor()
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
            string category = comboBox1.Text.Trim();
            string eventIdText = textBox3.Text.Trim();
            string fundsText = textBox5.Text.Trim();

            if (!int.TryParse(eventIdText, out int eventId))
            {
                MessageBox.Show("Invalid Event ID.");
                deleteSponsor();
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

            if (!int.TryParse(fundsText, out int funds))
            {
                MessageBox.Show("Invalid funds amount.");
                deleteSponsor();
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

            // Check constraints
            if ((category == "Title Sponsor" && funds <= 100000) ||
                (category == "Gold Sponsor" && funds <= 50000) ||
                (category == "Silver Sponsor" && funds <= 25000) ||
                (category == "Media Partner" && funds <= 15000))
            {
                string insertQuery = "INSERT INTO SPONSOR (Category, UserID, EventID, Funds) " +
                                     "VALUES (@Category, @UserID, @EventID, @Funds)";

                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=NASCON;uid=root;pwd=Moiz2004;"))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Category", category);
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            cmd.Parameters.AddWithValue("@EventID", eventId);
                            cmd.Parameters.AddWithValue("@Funds", funds);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                                MessageBox.Show("Sponsor added successfully.");
                            else
                            {
                                MessageBox.Show("Failed to add sponsor.");
                                deleteSponsor();
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Message.Contains("Duplicate entry"))
                            MessageBox.Show("This user is already registered as a sponsor.");
                        else
                            MessageBox.Show("Database error: " + ex.Message);
                        deleteSponsor();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid funds amount for selected category.");
                deleteSponsor();
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
