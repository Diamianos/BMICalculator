using System;
using System.Windows.Forms;

namespace Ch14Lab3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
        
            // Getting height value
            double height;
            if (!Double.TryParse(txtHeight.Text, out height)) 
            {
                lblResult.Text = "Invalid height. Please enter a positive numeric value for height.";
                txtHeight.SelectAll();
                txtHeight.Focus();
                return;
            }

            // Getting weight value
            double weight;
            if (!Double.TryParse(txtWeight.Text, out weight))
            {
                lblResult.Text = "Invalid weight. Please enter a positive numeric value for weight.";
                txtWeight.SelectAll();
                txtWeight.Focus();
                return;
            }

            // Performing calculation based on measurement selection
            double BMI;
            if (rbnImperial.Checked == true)
            {
                BMI = weight * 703 / (Math.Pow(height, 2));
            }

            else 
            {
                BMI = (weight / height / height) * 10000;
            }
                

            // Determinning if user is underweight, optimal, or overweight
            string result = "";

            if (BMI < 18.5)
            {
                result = "You are underweight";
            }

            else if (BMI >= 18.5 && BMI <= 25)
            {
                result = "Your weight is optimal";
            }

            else
            {
                result = "You are overweight";
            }
                

            // Displaying the results
            lblResult.Text = $"Based on height of {txtHeight.Text}{lblHeightValue.Text} and a weight of {txtWeight.Text}{lblWeightValue.Text}" +
                $", your BMI is {Math.Round(BMI, 1)}. {result}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rbnImperial.Checked = true;
            txtHeight.Clear();
            txtHeight.Focus();
            txtWeight.Clear();
            lblResult.Text = "";        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnMetric.Checked == true) {

                lblHeightValue.Text = "cm";
                lblWeightValue.Text = "kg";
            }
        }

        private void rbnImperial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnImperial.Checked == true) {

                lblHeightValue.Text = "in";
                lblWeightValue.Text = "lbs";

            }
        }
    }
}
