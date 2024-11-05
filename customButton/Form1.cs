namespace customButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDefault_MouseEnter(object sender, EventArgs e)
        {

            btnDefault.BackColor = Color.LightBlue;
        }

        private void btnDefault_MouseLeave(object sender, EventArgs e)
        {
            btnDefault.BackColor = SystemColors.Control;
        }

        private void btnDefault_MouserHover(object sender, EventArgs e)
        {
            btnDefault.BackColor = Color.HotPink;
        }

        private void txtDefault_TextChange(object sender, EventArgs e)
        {
            if(txtDefault.Text.Length >= 10)
            {
                txtDefault.BackColor = Color.Red;
                txtDefault.ForeColor = Color.Yellow;
            }
            else if(txtDefault.Text.Length >= 5)
            {
                txtDefault.BackColor = Color.Green;
                txtDefault.ForeColor = Color.White;
            }
            else
            {
                txtDefault.BackColor = SystemColors.Control;
                txtDefault.ForeColor= Color.DeepPink;
            }
        }
    }
}
