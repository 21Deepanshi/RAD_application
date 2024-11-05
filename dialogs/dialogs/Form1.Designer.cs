namespace dialogs
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
            btnOpenFile = new Button();
            txtFileContent = new TextBox();
            btnSaveFile = new Button();
            btnFont = new Button();
            rtxFileContent = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            Color = new Button();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(356, 135);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(94, 29);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Open";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(63, 135);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.ScrollBars = ScrollBars.Vertical;
            txtFileContent.Size = new Size(207, 144);
            txtFileContent.TabIndex = 1;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(356, 208);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(94, 29);
            btnSaveFile.TabIndex = 2;
            btnSaveFile.Text = "Save";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnFont
            // 
            btnFont.BackColor = SystemColors.InactiveCaption;
            btnFont.Location = new Point(340, 313);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(144, 29);
            btnFont.TabIndex = 3;
            btnFont.Text = "Change Font";
            btnFont.UseVisualStyleBackColor = false;
            btnFont.Click += btnFont_Click;
            // 
            // rtxFileContent
            // 
            rtxFileContent.Location = new Point(63, 351);
            rtxFileContent.Name = "rtxFileContent";
            rtxFileContent.Size = new Size(198, 120);
            rtxFileContent.TabIndex = 4;
            rtxFileContent.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 100);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 5;
            label1.Text = "Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 313);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 6;
            label2.Text = "RTX";
            // 
            // Color
            // 
            Color.Location = new Point(340, 413);
            Color.Name = "Color";
            Color.Size = new Size(144, 70);
            Color.TabIndex = 7;
            Color.Text = "Change Color";
            Color.UseVisualStyleBackColor = true;
            Color.Click += Color_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 495);
            Controls.Add(Color);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtxFileContent);
            Controls.Add(btnFont);
            Controls.Add(btnSaveFile);
            Controls.Add(txtFileContent);
            Controls.Add(btnOpenFile);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFile;
        private TextBox txtFileContent;
        private Button btnSaveFile;
        private Button btnFont;
        private RichTextBox rtxFileContent;
        private Label label1;
        private Label label2;
        private Button Color;
    }
}
