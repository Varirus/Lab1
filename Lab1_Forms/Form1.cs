using Lab1;
using System.Diagnostics;
using System.Drawing;

namespace Lab1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color errorColor = Color.Red;
            Color normalColor = Color.White;
            int seed = 0;
            int n = 0;
            int capacity = 0;
            bool errorOccurred = false;
            try
            {
                seed = Convert.ToInt32(seedTextBox.Text);
                seedTextBox.BackColor = normalColor;
            }
            catch (Exception)
            {
                seedTextBox.BackColor = errorColor;
                errorOccurred = true;
            }

            try
            {
                n = Convert.ToInt32(numberOfItemsTextBox.Text);
                numberOfItemsTextBox.BackColor = normalColor;
                if (n < 0)
                {
                    numberOfItemsTextBox.BackColor = errorColor;
                    errorOccurred = true;
                }
            }
            catch (Exception)
            {
                numberOfItemsTextBox.BackColor = errorColor;
                errorOccurred = true;
            }

            try
            {
                capacity = Convert.ToInt32(capacityTextBox.Text);
                capacityTextBox.BackColor = normalColor;
                if (capacity < 0)
                {
                    capacityTextBox.BackColor = errorColor;
                    errorOccurred = true;
                }
            }
            catch (Exception)
            {
                capacityTextBox.BackColor = errorColor;
                errorOccurred = true;
            }
            if (errorOccurred)
            {
                Debug.WriteLine("Error Occurred");
                return;
            }


            Problem problem = new Problem(n, seed);
            instanceTextBox.Text = problem.ToString().Replace("\n", Environment.NewLine);
            Result result = problem.Solve(capacity);
            resultTextBox.Text = result.ToString().Replace("\n", Environment.NewLine);
            Debug.WriteLine("Success");
        }
    }
}
