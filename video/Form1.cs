using AxWMPLib;

namespace video
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                c.URL = ofd.FileName;
                c.Ctlcontrols.play();
            }

        }
    }
}
