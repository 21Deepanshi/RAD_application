namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.DisplayName = txtName.Text;
            DialogResult result = F2.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblResult.Text = "User Clicked OK !";
            }
            if (result == DialogResult.Cancel)
            {
                {
                    lblResult.Text = "User Clicked Cancel";
                }

            }
        }
    }
}
