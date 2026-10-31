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
    public partial class Form5 : Form
    {
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            string query = "SELECT S.SponsorID, U.Name AS SponsorName, S.Category, S.Funds, S.UserID, S.EventID, E.Name AS EventName, " +
                "CASE " +
                "WHEN P.PaymentID IS NOT NULL THEN 'Paid' " +
                "ELSE 'Unpaid' " +
                "END AS PaymentStatus " +
                "FROM SPONSOR S " +
                "LEFT JOIN `USER` U ON S.UserID = U.UserID " +
                "LEFT JOIN EVENT E ON S.EventID = E.EventID " +
                "LEFT JOIN PAYMENT P ON S.UserID = P.UserID;";
            string query2 = "SELECT SUM(Funds) FROM SPONSOR";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    adapter = new MySqlDataAdapter(query, cnn);

                    // Auto-generate INSERT, UPDATE, DELETE commands
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                    dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open connection
                    cnn.Open();

                    // Execute the query to get the total funds
                    MySqlCommand cmd = new MySqlCommand(query2, cnn);
                    object result = cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

                    // Check if the result is null
                    if (result != DBNull.Value)
                    {
                        // Convert the result to decimal and update the TextBox
                        decimal totalFunds = Convert.ToDecimal(result);
                        textBox9.Text = "Total Funds: " + totalFunds.ToString() + " PKR"; // C2 format for currency
                    }
                    else
                    {
                        textBox9.Text = "Total Funds: 0.00 PKR";
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }




        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
