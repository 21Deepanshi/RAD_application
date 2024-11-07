namespace STOPWATCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime start;
        DateTime stop;
        TimeSpan elapsedTime;

        private void btnStart_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            textBox1.Text = start.ToLongTimeString();
            //to restart
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = DateTime.Now;
            textBox2.Text = stop.ToLongTimeString();
            elapsedTime = stop - start;
            textBox3.Text = elapsedTime.Seconds.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
