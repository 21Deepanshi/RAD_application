namespace pizzaOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string Order = "Your Order details: ";
            int TotalPrice = 10;
            Order += "\n Size: ";
            if (radioSmall.Checked)
            {
                Order += "Small";
                TotalPrice += 5;
            }
            else if (radioMedium.Checked)
            {
                Order += "Medium";
                TotalPrice += 10;
            }
            else if (radioLarze.Checked)
            {
                Order += "Larze";
                TotalPrice += 15;
            }

            Order += "\n Delivery Mode:";
            if (radioPickUp.Checked)
            {
                Order += "Pick Up:";
                TotalPrice += 0;
            }
            else if (radioDelivery.Checked)
            {
                Order += "Delivery";
                TotalPrice += 5;
            }
            else
            {
                MessageBox.Show("Please select one method");
                return;
            }
            Order += "\n Topping: ";
            if (checkBox_Bacon.Checked)
            {
                Order += "Bacon";
                TotalPrice += 5;
            }

            if (checkBox_BBQchicken.Checked)
            {
                Order += "BBQ Chicken";
                TotalPrice += 6;
            }
            if (checkBox_cheese.Checked)
            {
                Order += "Cheese";
                TotalPrice += 2;
            }

            if (checkBox_Veggies.Checked)
            {
                Order += "Veggies";
                TotalPrice += 4;
            }

            Order += $"\n Total Price: ${TotalPrice}";
            MessageBox.Show(Order);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
