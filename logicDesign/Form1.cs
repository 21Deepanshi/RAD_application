namespace logicDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            login.LoginButtonClick  += new EventHandler(login_LoginButtonClick);
        }
        private void login_LoginButtonClick(object sender, EventArgs e)
        {
            string username = login.Username;
            string password = login.Password;
            MessageBox.Show($"Username: {username} \nPassword: {password}");
        }
    }
}
