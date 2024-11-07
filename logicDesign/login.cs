using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logicDesign
{
    public partial class login : UserControl
    {
        public event EventHandler LoginButtonClick;
        public login()
        {
            InitializeComponent();
        }
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LoginButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
