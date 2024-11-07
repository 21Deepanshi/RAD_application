using System.Media;
using System.Windows.Forms;

namespace image
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayer;
        private bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show(ofd.FileName);
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // pictureBox1.ImageLocation = "https://images.unsplash.com/photo-1555606396-79625d075363?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";
            pictureBox1.ImageLocation = @"C:\Users\deepanshi\OneDrive - Bow Valley College\Desktop\RapidApplication\image\resources\Screenshot 2024-09-24 133248.png";
            _soundPlayer = new SoundPlayer(Properties.Resources.play) ;
            //_soundPlayer = new SoundPlayer(@"C:\Users\deepanshi\OneDrive - Bow Valley College\Desktop\RapidApplication\image\resources\play.wav");
           // _soundPlayer = new SoundPlayer("play.wav");
        }

        private void chkPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPlay.Checked)
            {
                _soundPlayer.Play();
                chkPlay.Text = "Stop";
            }
            else
            {
                _soundPlayer.Stop();
                chkPlay.Text = "Play";
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(flag == false)
            {
                _soundPlayer.Play();
                btnPlay.Text = "Stop";
                flag = true;
            }
            else
            {
                _soundPlayer.Stop();
                btnPlay.Text = "Play";
                flag = false;
            }
        }
    }
}
