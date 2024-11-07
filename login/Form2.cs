using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string DisplayName = "";

        private void Form2_Load(object sender, EventArgs e)
        {
            lblName.Text = "Hello, " + DisplayName;
            //lblName.Text += DisplayName;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            //DisplayName = txtName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
