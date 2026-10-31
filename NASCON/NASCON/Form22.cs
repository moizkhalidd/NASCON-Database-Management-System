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

namespace NASCON
{
    public partial class Form22 : Form
    {
        private int userId;
        public Form22(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            string query = "SELECT " +
                "E.*, V.Name AS VenueName, V.Location AS VenueLocation, V.Type AS VenueType " +
                "FROM `USER` U " +
                "JOIN SPONSOR S ON U.UserID = S.UserID " +
                "JOIN EVENT E ON S.EventID = E.EventID " +
                "LEFT JOIN VENUE V ON E.VenueID = V.VenueID " +
                "WHERE U.UserID = @userId;";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataTable transposedTable = new DataTable();
                    transposedTable.Columns.Add("Field");
                    transposedTable.Columns.Add("Value");

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0]; // You can loop if you expect multiple rows
                        foreach (DataColumn col in dt.Columns)
                        {
                            transposedTable.Rows.Add(col.ColumnName, row[col]);
                        }
                    }

                    dataGridView1.DataSource = transposedTable;
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
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
