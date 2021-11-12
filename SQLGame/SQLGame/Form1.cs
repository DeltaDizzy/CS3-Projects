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

namespace SQLGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int iter = 1;
        /// <summary>
        /// up, down, left, right
        /// </summary>
        (bool, bool, bool, bool) moveState = (false, false, false, false);
        int charSpeed = 7;
        string oldstring = "";
        MySqlConnection connection = new MySqlConnection("Server=50.62.209.85;Initial Catalog=cs3data;Username=dbaseuser;Password=Castl3H1!!;");
        MySqlCommand command;
        DataTable dt = new DataTable();
        int rocksCount = 0;
        List<PictureBox> rocks = new List<PictureBox>();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W: // up
                    moveState.Item1 = true;
                    break;
                case Keys.A: // left
                    moveState.Item3 = true;
                    break;
                case Keys.S: // down
                    moveState.Item2 = true;
                    break;
                case Keys.D: //right
                    moveState.Item4 = true;
                    break;
                default:
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W: // up
                    moveState.Item1 = false;
                    break;
                case Keys.A: // left
                    moveState.Item3 = false;
                    break;
                case Keys.S: // down
                    moveState.Item2 = false;
                    break;
                case Keys.D: //right
                    moveState.Item4 = false;
                    break;
                default:
                    break;
            }
        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            if (moveState.Item1 == true)
            {
                pbGuy.Top -= charSpeed;
            }
            if(moveState.Item2 == true)
            {
                pbGuy.Top += charSpeed;
            }
            if (moveState.Item3 == true)
            {
                pbGuy.Left -= charSpeed;
            }
            if (moveState.Item4 == true)
            {
                pbGuy.Left += charSpeed;
            }
        }

        private void tmrAnimate_Tick(object sender, EventArgs e)
        {
            
            string dirName = "";
            // get direction
            int dir = Convert.ToInt32(moveState.Item1) * 8 + Convert.ToInt32(moveState.Item2) * 4
                + Convert.ToInt32(moveState.Item3) * 2 + Convert.ToInt32(moveState.Item4) * 1;
            switch (dir)
            {
                case 8:
                    dirName = "up";
                    break;
                case 4: 
                    dirName = "down";
                    break;
                case 2:
                    dirName = "left";
                    break;
                case 1:
                    dirName = "right";
                    break;
                default:
                    break;
            }

            if (iter >= 4) iter = 1;
            if (dirName == "")
            {
                //dirName = "down";
                return;
            }
            pbGuy.Image = (Image)Properties.Resources.ResourceManager.GetObject(dirName + iter);
            iter++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateShow_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            string query = "SELECT * FROM elijah";
            // import
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            dt.Clear();
            dgvData.DataSource = null;
            adapter.Fill(dt);
            dgvData.DataSource = dt;
            connection.Close();
        }

        private void pbGuy_Move(object sender, EventArgs e)
        {

        }
    }
}
