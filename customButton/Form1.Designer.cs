namespace customButton
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
            btnDefault = new Button();
            btnCustomButton = new button();
            txtDefault = new TextBox();
            dynamicTextBox1 = new DynamicTextBox();
            SuspendLayout();
            // 
            // btnDefault
            // 
            btnDefault.Location = new Point(52, 60);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(94, 29);
            btnDefault.TabIndex = 0;
            btnDefault.Text = "Default";
            btnDefault.UseVisualStyleBackColor = true;
            btnDefault.MouseEnter += btnDefault_MouseEnter;
            btnDefault.MouseLeave += btnDefault_MouseLeave;
            btnDefault.MouseHover += btnDefault_MouserHover;
            // 
            // btnCustomButton
            // 
            btnCustomButton.Location = new Point(227, 60);
            btnCustomButton.Name = "btnCustomButton";
            btnCustomButton.Size = new Size(196, 29);
            btnCustomButton.TabIndex = 1;
            btnCustomButton.Text = "customButton";
            btnCustomButton.UseVisualStyleBackColor = true;
            // 
            // txtDefault
            // 
            txtDefault.CharacterCasing = CharacterCasing.Upper;
            txtDefault.Location = new Point(52, 311);
            txtDefault.MaxLength = 10;
            txtDefault.Name = "txtDefault";
            txtDefault.PlaceholderText = "Please Input";
            txtDefault.Size = new Size(203, 27);
            txtDefault.TabIndex = 2;
            txtDefault.TextChanged += txtDefault_TextChange;
            // 
            // dynamicTextBox1
            // 
            dynamicTextBox1.BackColor = SystemColors.Control;
            dynamicTextBox1.CharacterCasing = CharacterCasing.Upper;
            dynamicTextBox1.ForeColor = Color.DeepPink;
            dynamicTextBox1.Location = new Point(416, 312);
            dynamicTextBox1.MaxLength = 10;
            dynamicTextBox1.Name = "dynamicTextBox1";
            dynamicTextBox1.Size = new Size(229, 27);
            dynamicTextBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dynamicTextBox1);
            Controls.Add(txtDefault);
            Controls.Add(btnCustomButton);
            Controls.Add(btnDefault);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDefault;
        private button btnCustomButton;
        private TextBox txtDefault;
        private DynamicTextBox dynamicTextBox1;
    }
}
