using System;
using System.Windows.Forms;

namespace CCAD16_Assignment4_1_2
{
    public partial class Form1 : Form
    {
        private readonly ICalculator calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Math();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => calculator.Add(a, b));
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => calculator.Subtract(a, b));
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => calculator.Multiply(a, b));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                PerformOperation((a, b) => calculator.Divide(a, b));
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PerformOperation(Func<double, double, double> operation)
        {
            if (double.TryParse(txtInput1.Text, out double input1) && double.TryParse(txtInput2.Text, out double input2))
            {
                double result = operation(input1, input2);
                txtResult.Text = $"Result: {result}";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
