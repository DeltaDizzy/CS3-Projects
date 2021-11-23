using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance
{
    public partial class frmSchedule : Form
    {
        public static DataTable dt = new DataTable();
        Point lastLocation = new Point();
        private bool mouseDown = false;
        public frmSchedule()
        {
            InitializeComponent();
            this.bunifuGradientPanel1.MouseDown += new MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            this.bunifuGradientPanel1.MouseUp += new MouseEventHandler(this.bunifuGradientPanel1_MouseUp);
            dt.Columns.Add("Month");
            dt.Columns.Add("Minimum Payment");
            dt.Columns.Add("Interest Paid");
            dt.Columns.Add("Principal Paid");
            dt.Columns.Add("Debt Remaining");
            dgvdata.DataSource = dt;

        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);


                this.Update();
            }
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
           
        }

        public void AddData(int month, double minPayAmount, double interestpaid, double principalpaid, double debtremaining)
        {
            DataRow dr = dt.NewRow();
            dr.SetField("Month", month);
            dr.SetField("Minimum Payment", minPayAmount.ToString("$0.00"));
            dr.SetField("Interest Paid", interestpaid.ToString("$0.00"));
            dr.SetField("Principal Paid", principalpaid.ToString("$0.00"));
            dr.SetField("Debt Remaining", debtremaining.ToString("$0.00"));
            dt.Rows.Add(dr);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
