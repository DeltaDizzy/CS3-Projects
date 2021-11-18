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
    public partial class frmMain : Form
    {
        LinkedList<KeyValuePair<double, double>> minPaymentLookup = new LinkedList<KeyValuePair<double, double>>();
        Point lastLocation = new Point();
        bool mouseDown = false;
        int payMonths = 0;
        double totalPaid = 0, interestPaid = 0, debtRemaining = 0;
        // debt remaining, interest rate
        Func<(double, double, int)> calculate;
        private Task<(double, double, int)> resultsTask;
        (double, double, int) results;
        //TODO: CALCULATION AS TASK

        public frmMain()
        {
            InitializeComponent();
            minPaymentLookup.AddLast(new KeyValuePair<double, double>(10000, 0.02));
            minPaymentLookup.AddLast(new KeyValuePair<double, double>(5000, 0.03));
            minPaymentLookup.AddLast(new KeyValuePair<double, double>(2500, 0.04));
            minPaymentLookup.AddLast(new KeyValuePair<double, double>(1000, 0.05));
            minPaymentLookup.AddLast(new KeyValuePair<double, double>(500, 0.06));
            minPaymentLookup.AddLast(new KeyValuePair<double, double>(25, 1));
            minPaymentLookup.AddLast(new KeyValuePair<double, double>(0, 1));


            calculate = () =>
            {
                double debtRemaining = double.Parse(txtInitialDebt.Text);
                double interestRate = double.Parse(txtInterestRate.Text) / 100;

                while (debtRemaining > 0)
                {
                    double minPayRate = minPayPercentEval(debtRemaining);
                    double principalPaid = debtRemaining * minPayRate;
                    debtRemaining -= principalPaid;
                    totalPaid += debtRemaining * (1 + (interestRate / 100 / 12));
                    payMonths++;
                }

                return (interestPaid, totalPaid, payMonths);
            };

            resultsTask = new Task<(double, double, int)>(calculate);
        }

        private double minPayPercentEval(double debtRemaining)
        {
            double minPayPercent = minPaymentLookup
                .Where(item => debtRemaining >= item.Key)
                .Select(item => item)
                .FirstOrDefault()
                .Value;
            return minPayPercent;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;
            calculateAsync();
            btnCalculate.Enabled = true;
            txtInterestPaidResult.Text = string.Format("${0:C2}", results.Item1.ToString());
            txtTotalPaidResult.Text = string.Format("${0:C2}", results.Item2.ToString());
            txtTimeToPayResult.Text = $"{results.Item3} months";
        }

        private async void calculateAsync()
        {
            results = await Task.Run(calculate);
            ResetVars();
        }

        private void ResetVars()
        {
            totalPaid = 0;
            payMonths = 0;
            interestPaid = 0;
        }

        private void chtInterest_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void chtInterest_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);


                this.Update();
            }
        }

        private void chtInterest_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlInput_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlInput_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);


                this.Update();
            }
        }

        private void pnlInput_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void bunifuPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void bunifuPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);


                this.Update();
            }
        }

        private void bunifuPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
