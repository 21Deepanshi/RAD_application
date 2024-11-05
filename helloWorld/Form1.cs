namespace helloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
            //btnHello.Text = "Clicked!"; // rename the name after click
        }

        private void clickedHello_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World");
            btnHello.Text = "Clicked!"; // rename the name after click
        }
    }
}
