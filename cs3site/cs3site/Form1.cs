using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs3site
{
    public partial class Form1 : Form
    {
        // 50.62.209.85
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=50.62.209.85;Initial Catalog='cs3data';username=dbaseuser;password=Castl3H1!!");

        MySqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM noah";
            connection.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(dt);
            dgvdata.DataSource = dt;
            connection.Close();
        }
    }
}
