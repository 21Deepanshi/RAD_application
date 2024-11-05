namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double number1;
        double number2;
        string options;
        double result;
        string operation;


        private void number_operators(object sender, EventArgs e)
        {
            Button button = (Button)sender;  // Get the button that was clicked (e.g., "+", "-", "*", "/")
            operation = button.Text;         // Set the operation to the button's text (e.g., "+")

            number1 = double.Parse(txtDisplay.Text);  // Store the first number
            txtDisplay.Clear();                    // Clear the display to prepare for the second number
        }

        private void btn_number(object sender, EventArgs e)
        {
            Button button = (Button)sender; // Get the button that was clicked
            txtDisplay.Text = txtDisplay.Text + button.Text; // Append the button's text (number) to the display
        }

        private void equal_function(object sender, EventArgs e)
        {
            number2 = double.Parse(txtDisplay.Text);  // Get the second number

            // Perform the operation based on the stored operator
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("Invalid operation.");
                    return;
            }

            txtDisplay.Text = result.ToString();  // Display the result
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            result = (0);
            number1 = (0);
            number2 = (0);
        }
    }
}
