namespace GraphicDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            //this.Width = 500;
            //this.Height = 500;
            MessageBox.Show(this.Width.ToString());
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private float x = 0;
        private System.Windows.Forms.Timer timer= new System.Windows.Forms.Timer();
        Rectangle updateReactangle = new Rectangle(0,275,800,50);
        private void Timer_Tick(object sender, EventArgs e)
        {
            x += 10;
            if(x > this.Width)
            {
                x = 0;
            }
            this.Invalidate(updateReactangle);
        }
        protected override void OnPaint(PaintEventArgs e) { 
            Graphics g = e.Graphics;


            Pen hotpinkpen = new Pen(Color.HotPink, 5);
            g.DrawLine(hotpinkpen, 10,20, 200,20); //Hortizontal

            g.DrawLine(hotpinkpen, 10, 20, 10, 200); //Vertical

            //reactangle
            g.DrawRectangle(hotpinkpen, 50, 50, 100, 50);
            g.FillEllipse(Brushes.Green, 200, 50, 100, 50);
            Pen redPen = new Pen(Color.Red, 5);
            g.DrawEllipse(redPen, 200, 50, 100, 50);


            ////////////////////////////////////////////////////////////////////
            Font font = new Font("Arial", 16);
            g.DrawString("Hello", font, Brushes.Black, new PointF(20, 20));

            Font italicFont = new Font("Arial", 24, FontStyle.Italic);
            g.DrawString("Italic", italicFont, Brushes.Red, 10, 200);


            //Animation
            g.FillEllipse(Brushes.Blue, x, 300, 100, 50);


            base.OnPaint(e);
        }
    }
}
