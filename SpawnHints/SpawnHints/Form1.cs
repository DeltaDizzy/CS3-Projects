using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpawnHints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// up, down, left, right
        /// </summary>
        (bool, bool, bool, bool) moveState = (false, false, false, false);
        int speed = 5;
        List<PictureBox> spuds = new List<PictureBox>();
        List<PictureBox> boxes = new List<PictureBox>();
        Random r = new Random();
        MySqlConnection connection = new MySqlConnection("Server=50.62.209.85;Initial Catalog='cs3data';Username=dbaseuser;Password=Castl3H1!!;");
        MySqlCommand cmd = new MySqlCommand();
        int total = 0;
        Dictionary<PictureBox, float> spudDistances = new Dictionary<PictureBox, float>();
        Dictionary<PictureBox, float> boxDistances = new Dictionary<PictureBox, float>();
        int ticks = 0;
        private int iter;
        string dirName = "";

        private void SpawnProj()
        {
            PictureBox box = new PictureBox();
            box.Width = 50/5;
            box.Height = 50/5;
            box.BackColor = Color.Brown;
            //box.Location = new Point(r.Next(0, ClientSize.Width - box.Width), r.Next(0, ClientSize.Height - box.Height));
            Point leftSpud = new Point(jeff.Location.X, jeff.Location.Y + jeff.Height / 2);
            Point rightSpud = new Point(jeff.Location.X + jeff.Width, jeff.Location.Y + jeff.Height / 2);
            Point upSpud = new Point(jeff.Location.X + jeff.Width / 2, jeff.Location.Y);
            Point downSpud = new Point(jeff.Location.X + jeff.Width / 2, jeff.Location.Y + jeff.Height);
            switch (dirName)
            {
                case "up":
                    box.Location = upSpud;
                    break;
                case "down":
                    box.Location = downSpud;
                    break;
                case "left":
                    box.Location = leftSpud;
                    break;
                case "right":
                    box.Location = rightSpud;
                    break;
                default:
                    break;
            }
            spuds.Add(box);
            Controls.Add(box);
        }

        private void SpawnBox()
        {
            PictureBox box = new PictureBox();
            box.Width = 50;
            box.Height = 50;
            box.BackColor = Color.Brown;
            box.Location = new Point(r.Next(box.Width+15, ClientSize.Width - box.Width), r.Next(0, ClientSize.Height - box.Height));
            boxes.Add(box);
            Controls.Add(box);
        }


        private void ThrowSpud()
        {
            switch (dirName)
            {
                case "up":
                    for (int i = 0; i < spuds.Count; i++)
                    {
                        spuds[i].Top -= speed;
                    }
                    break;
                case "down":
                    for (int i = 0; i < spuds.Count; i++)
                    {
                        spuds[i].Top += speed;
                    }
                    break;
                case "left":
                    for (int i = 0; i < spuds.Count; i++)
                    {
                        spuds[i].Left -= speed;
                    }
                    break;
                case "right":
                    for (int i = 0; i < spuds.Count; i++)
                    {
                        spuds[i].Left += speed;
                    }
                    break;
                default:
                    break;
            }
            
            CollisionCheck();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W: // up
                    moveState.Item1 = true; ;
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
                case Keys.Space:
                    SpawnProj();
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
                jeff.Top -= speed;
            }
            if (moveState.Item2 == true)
            {
                jeff.Top += speed;
            }
            if (moveState.Item3 == true)
            {
                jeff.Left -= speed;
            }
            if (moveState.Item4 == true)
            {
                jeff.Left += speed;
            }
            lblScore.Text = total.ToString();
            ThrowSpud();
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
            if (ticks % 20 == 0)
            {          
                if (iter >= 4) iter = 1;
                if (dirName == "")
                {
                    //dirName = "down";
                    return;
                }
                jeff.Image = (Image)Properties.Resources.ResourceManager.GetObject(dirName + iter);
                iter++;
            }
            ticks++;
            
        }

        private void CollisionCheck()
        {
            PictureBox target;
            if (spuds.Count > 0 && boxes.Count > 0)
            {
                for (int i = 0; i < boxes.Count; i++)
                {
                    for (int j = 0; j < spuds.Count; j++)
                    {
                        if (i < boxes.Count)
                        {
                            if (boxes[i].Bounds.IntersectsWith(spuds[j].Bounds))
                            {
                                target = boxes[i];
                                Controls.Remove(target);
                                boxes.RemoveAt(i);
                                target.Dispose();
                                target = spuds[j];
                                Controls.Remove(target);
                                spuds.RemoveAt(j);
                                target.Dispose();
                                total++;
                            }
                        }
                    }
                }
            }
        }

        private void tmrBox_Tick(object sender, EventArgs e)
        {
            SpawnBox();
        }

        private void jeff_Move(object sender, EventArgs e)
        {
            if (spuds.Count == 0)
            {
                return;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private void RefreshTable()
        {
            string query = "SELECT * FROM elijah";
            // import
            connection.Open();
            //MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            //dt.Clear();
            //dgvData.DataSource = null;
            //adapter.Fill(dt);
            //dgvData.DataSource = dt;
            connection.Close();
        }

        private void UpdateTable()
        {
            string query = $"UPDATE elijah SET quantity = {total} WHERE Id = 1";
            // $"UPDATE elijah SET quantity = {total} WHERE Id = 1";
            connection.Open();
            cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateTable();
        }
    }
}
