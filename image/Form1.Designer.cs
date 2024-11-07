namespace image
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImage = new Button();
            pictureBox1 = new PictureBox();
            chkPlay = new CheckBox();
            btnPlay = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnImage
            // 
            btnImage.Location = new Point(23, 30);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(94, 29);
            btnImage.TabIndex = 0;
            btnImage.Text = "Image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(34, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 373);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // chkPlay
            // 
            chkPlay.Appearance = Appearance.Button;
            chkPlay.Location = new Point(371, 107);
            chkPlay.Name = "chkPlay";
            chkPlay.Size = new Size(151, 80);
            chkPlay.TabIndex = 2;
            chkPlay.Text = "play";
            chkPlay.TextAlign = ContentAlignment.MiddleCenter;
            chkPlay.UseVisualStyleBackColor = true;
            chkPlay.CheckedChanged += chkPlay_CheckedChanged;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(371, 283);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(144, 66);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 492);
            Controls.Add(btnPlay);
            Controls.Add(chkPlay);
            Controls.Add(pictureBox1);
            Controls.Add(btnImage);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImage;
        private PictureBox pictureBox1;
        private CheckBox chkPlay;
        private Button btnPlay;
    }
}
