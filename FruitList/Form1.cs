namespace FruitList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Going to add items, append the list
            //listFruit.Items.Add("peach"); only add one item in the list
            // string[] FruitList = { "Peaches", "Mango" }; //to add more items
            //listFruit.Items.AddRange(FruitList);

            //to avoid empty items to be added- use condition
            if (txtAddItems.Text != "")
            {
                listFruit.Items.Add(txtAddItems.Text);
                txtAddItems.Text = "";
            }
            else
            {
                MessageBox.Show("Please Enter the new Fruit in list");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the selected item
            if (listFruit.SelectedIndex != -1)
            {
                MessageBox.Show("Are you Want to delete the  selected item");
                //listFruit.Items.Remove(listFruit.SelectedItem); //for validation according to the SelectedItem we should use null
                //to remove the item with index
                listFruit.Items.RemoveAt(listFruit.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please Select a item");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAddItems_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                listFruit.Items.Add(txtAddItems.Text);
                txtAddItems.Text = "";
            }
        }
    }
}
