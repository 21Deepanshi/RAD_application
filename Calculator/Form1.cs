
namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //string CalTotal;
        int number1;
        int number2;
        string options;
        int result;
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnOperator_Addition_Click(object sender, EventArgs e)
        {
            options = "+";
            number1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnOperator_Subtraction_Click(object sender, EventArgs e)
        {
            options = "-";
            number1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnOperator_Multiplication_Click(object sender, EventArgs e)
        {
            options = "*";
            number1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnOperator_Division_Click(object sender, EventArgs e)
        {
            options = "/";
            number1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2 = int.Parse(txtDisplay.Text);

            if (options.Equals("+"))
                result = number1 + number2;

            if (options.Equals("-"))
                result = number1 - number2;

            if (options.Equals("*"))
                result = number1 * number2;

            if (options.Equals("/"))
                result = number1 / number2;

            txtDisplay.Text = result + "";
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
