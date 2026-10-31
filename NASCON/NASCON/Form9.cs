using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Formats.Asn1.AsnWriter;

namespace NASCON
{
    public partial class Form9 : Form
    {
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form9()
        {
            InitializeComponent();
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=NASCON;uid=root;pwd=Moiz2004;";
            string query = "SELECT u.UserID, u.Name, u.Email, ev.EventID, e.Name AS EventName, ev.TeamID, ev.EventRound, ev.Score FROM USER u LEFT JOIN JUDGE_EVALUATION je ON u.UserID = je.JudgeID LEFT JOIN EVALUATION ev ON je.EvaluationID = ev.EvaluationID LEFT JOIN EVENT e ON ev.EventID = e.EventID WHERE u.Role = 'Judge';";

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
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
