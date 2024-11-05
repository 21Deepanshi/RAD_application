namespace Calculator
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
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnSix = new Button();
            btnOperator_Division = new Button();
            btnOperator_Subtraction = new Button();
            btnOperator_Addition = new Button();
            btnOperator_Multiplication = new Button();
            btnEqual = new Button();
            btnAllClear = new Button();
            btnZero = new Button();
            txtDisplay = new TextBox();
            SuspendLayout();
            // 
            // btnSeven
            // 
            btnSeven.ForeColor = SystemColors.ActiveCaptionText;
            btnSeven.Location = new Point(36, 189);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(51, 29);
            btnSeven.TabIndex = 0;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEight.ForeColor = SystemColors.ActiveCaptionText;
            btnEight.Location = new Point(118, 189);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(51, 29);
            btnEight.TabIndex = 1;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.ForeColor = SystemColors.ActiveCaptionText;
            btnNine.Location = new Point(207, 189);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(51, 29);
            btnNine.TabIndex = 2;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnFive
            // 
            btnFive.ForeColor = SystemColors.ActiveCaptionText;
            btnFive.Location = new Point(118, 247);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(51, 29);
            btnFive.TabIndex = 3;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.ForeColor = SystemColors.ActiveCaptionText;
            btnFour.Location = new Point(36, 247);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(51, 29);
            btnFour.TabIndex = 4;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnThree
            // 
            btnThree.ForeColor = SystemColors.ActiveCaptionText;
            btnThree.Location = new Point(207, 308);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(51, 29);
            btnThree.TabIndex = 5;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo
            // 
            btnTwo.ForeColor = SystemColors.ActiveCaptionText;
            btnTwo.Location = new Point(118, 308);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(51, 29);
            btnTwo.TabIndex = 6;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.ForeColor = SystemColors.ActiveCaptionText;
            btnOne.Location = new Point(36, 308);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(51, 29);
            btnOne.TabIndex = 7;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnSix
            // 
            btnSix.ForeColor = SystemColors.ActiveCaptionText;
            btnSix.Location = new Point(207, 247);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(51, 29);
            btnSix.TabIndex = 8;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnOperator_Division
            // 
            btnOperator_Division.ForeColor = SystemColors.ActiveCaptionText;
            btnOperator_Division.Location = new Point(285, 308);
            btnOperator_Division.Name = "btnOperator_Division";
            btnOperator_Division.Size = new Size(51, 29);
            btnOperator_Division.TabIndex = 9;
            btnOperator_Division.Text = "/";
            btnOperator_Division.UseVisualStyleBackColor = true;
            btnOperator_Division.Click += btnOperator_Division_Click;
            // 
            // btnOperator_Subtraction
            // 
            btnOperator_Subtraction.ForeColor = SystemColors.ActiveCaptionText;
            btnOperator_Subtraction.Location = new Point(285, 247);
            btnOperator_Subtraction.Name = "btnOperator_Subtraction";
            btnOperator_Subtraction.Size = new Size(51, 29);
            btnOperator_Subtraction.TabIndex = 10;
            btnOperator_Subtraction.Text = "-";
            btnOperator_Subtraction.UseVisualStyleBackColor = true;
            btnOperator_Subtraction.Click += btnOperator_Subtraction_Click;
            // 
            // btnOperator_Addition
            // 
            btnOperator_Addition.ForeColor = SystemColors.ActiveCaptionText;
            btnOperator_Addition.Location = new Point(285, 189);
            btnOperator_Addition.Name = "btnOperator_Addition";
            btnOperator_Addition.Size = new Size(51, 29);
            btnOperator_Addition.TabIndex = 11;
            btnOperator_Addition.Text = "+";
            btnOperator_Addition.UseVisualStyleBackColor = true;
            btnOperator_Addition.Click += btnOperator_Addition_Click;
            // 
            // btnOperator_Multiplication
            // 
            btnOperator_Multiplication.ForeColor = SystemColors.ActiveCaptionText;
            btnOperator_Multiplication.Location = new Point(285, 367);
            btnOperator_Multiplication.Name = "btnOperator_Multiplication";
            btnOperator_Multiplication.Size = new Size(51, 29);
            btnOperator_Multiplication.TabIndex = 12;
            btnOperator_Multiplication.Text = "*";
            btnOperator_Multiplication.UseVisualStyleBackColor = true;
            btnOperator_Multiplication.Click += btnOperator_Multiplication_Click;
            // 
            // btnEqual
            // 
            btnEqual.ForeColor = SystemColors.ActiveCaptionText;
            btnEqual.Location = new Point(207, 367);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(51, 29);
            btnEqual.TabIndex = 13;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnAllClear
            // 
            btnAllClear.ForeColor = SystemColors.ActiveCaptionText;
            btnAllClear.Location = new Point(118, 367);
            btnAllClear.Name = "btnAllClear";
            btnAllClear.Size = new Size(51, 29);
            btnAllClear.TabIndex = 14;
            btnAllClear.Text = "A/C";
            btnAllClear.UseVisualStyleBackColor = true;
            btnAllClear.Click += btnAllClear_Click;
            // 
            // btnZero
            // 
            btnZero.ForeColor = SystemColors.ActiveCaptionText;
            btnZero.Location = new Point(36, 367);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(51, 29);
            btnZero.TabIndex = 15;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(36, 112);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(300, 34);
            txtDisplay.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(389, 455);
            Controls.Add(txtDisplay);
            Controls.Add(btnZero);
            Controls.Add(btnAllClear);
            Controls.Add(btnEqual);
            Controls.Add(btnOperator_Multiplication);
            Controls.Add(btnOperator_Addition);
            Controls.Add(btnOperator_Subtraction);
            Controls.Add(btnOperator_Division);
            Controls.Add(btnSix);
            Controls.Add(btnOne);
            Controls.Add(btnTwo);
            Controls.Add(btnThree);
            Controls.Add(btnFour);
            Controls.Add(btnFive);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnFive;
        private Button btnFour;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnSix;
        private Button btnOperator_Division;
        private Button btnOperator_Subtraction;
        private Button btnOperator_Addition;
        private Button btnOperator_Multiplication;
        private Button btnEqual;
        private Button btnAllClear;
        private Button btnZero;
        private TextBox txtDisplay;
    }
}
