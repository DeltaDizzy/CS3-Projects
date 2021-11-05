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

namespace SQLStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlConnectionStringBuilder sqsb = new SqlConnectionStringBuilder();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            sqsb.DataSource = "50.62.160.79";
            sqsb.InitialCatalog = "cs3data";
            sqsb.UserID = "dbaseuser";
            sqsb.Password = "Castl3H1!!";
            con.ConnectionString = sqsb.ConnectionString;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            con.Open();
                cmd = new SqlCommand("SELECT * FROM elijah");
                cmd.Connection = con;
                da = new SqlDataAdapter()
                {
                    SelectCommand = cmd
                };
                da.Fill(dt);
                dgvTable.DataSource = dt;
            con.Close();
        }
    }
}
