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
    public partial class Form2 : Form
    {
        private int userId;
        private System.Windows.Forms.TextBox[] textBoxes;
        public Form2(int userId)
        {
            InitializeComponent();
            textBoxes = new System.Windows.Forms.TextBox[] { textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16 };
            this.userId = userId;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string connetionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            MySqlConnection cnn = new MySqlConnection(connetionString);

            try
            {
                cnn.Open();
                string query = "SELECT COUNT(*) FROM EVENT";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                int Count = Convert.ToInt32(cmd.ExecuteScalar());
                textBox9.Text = "Total Events: " + Count.ToString();

                query = "SELECT COUNT(*) FROM VENUE";
                cmd = new MySqlCommand(query, cnn);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                textBox10.Text = "Total Venues: " + Count.ToString();

                query = "SELECT COUNT(*) FROM USER WHERE ROLE = 'PARTICIPANT'";
                cmd = new MySqlCommand(query, cnn);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                textBox11.Text = "Total Participants: " + Count.ToString();

                query = "SELECT COUNT(*) FROM SPONSOR";
                cmd = new MySqlCommand(query, cnn);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                textBox12.Text = "Total Sponsors: " + Count.ToString();

                query = "SELECT COUNT(*) FROM ORGANIZER";
                cmd = new MySqlCommand(query, cnn);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                textBox13.Text = "Total Organizers: " + Count.ToString();

                query = "SELECT COUNT(*) FROM ACCOMMODATION";
                cmd = new MySqlCommand(query, cnn);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                textBox14.Text = "Total Accommodations: " + Count.ToString();

                query = "SELECT COUNT(*) FROM USER WHERE ROLE = 'JUDGE' ";
                cmd = new MySqlCommand(query, cnn);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                textBox15.Text = "Total Judges: " + Count.ToString();

                query = "SELECT COUNT(*) FROM TEAM";
                cmd = new MySqlCommand(query, cnn);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                textBox16.Text = "Total Teams: " + Count.ToString();


                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            Form3 dashboard = new Form3();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            Form5 dashboard = new Form5();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            Form4 dashboard = new Form4();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the minimum average score:", "Average Score", "80");

            // Check if the user entered a valid number
            if (decimal.TryParse(input, out decimal averageScore))
            {
                // Pass the value to another form
                Form8 form8 = new Form8(averageScore); // Passing the value to the constructor of Form2
                Form8 dashboard = new Form8(averageScore);
                dashboard.StartPosition = FormStartPosition.CenterScreen;
                dashboard.Show();
            }
            else
            {
                // If input is invalid, show an error message
                MessageBox.Show("Please enter a valid numeric value for the average score.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            Form6 dashboard = new Form6();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            Form7 dashboard = new Form7();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            Form9 dashboard = new Form9();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            Form10 dashboard = new Form10();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Event ID:", "Event ID");

            // Check if the user entered a valid number
            if (decimal.TryParse(input, out decimal eventID))
            {
                Form37 form37 = new Form37(eventID);
                Form37 dashboard = new Form37(eventID);
                dashboard.StartPosition = FormStartPosition.CenterScreen;
                dashboard.Show();
            }
            else
            {
                // If input is invalid, show an error message
                MessageBox.Show("Please enter a valid numeric value for the average score.");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form38 form38 = new Form38(userId);
            Form38 dashboard = new Form38(userId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form42 form42 = new Form42();
            Form42 dashboard = new Form42();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form43 form43 = new Form43();
            Form43 dashboard = new Form43();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form44 form44 = new Form44();
            Form44 dashboard = new Form44();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form45 form45 = new Form45();
            Form45 dashboard = new Form45();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form46 form46 = new Form46();
            Form46 dashboard = new Form46();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form48 form48 = new Form48();
            Form48 dashboard = new Form48();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }
    }
}
