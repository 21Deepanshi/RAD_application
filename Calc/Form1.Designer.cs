namespace Calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btnAdd = new Button();
            btnSubtraction = new Button();
            btnMultiplication = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn10 = new Button();
            btn11 = new Button();
            btn12 = new Button();
            btn13 = new Button();
            btnEqual = new Button();
            btnAllClear = new Button();
            btnDivision = new Button();
            txtDisplay = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn1.Location = new Point(27, 166);
            btn1.Name = "btn1";
            btn1.Size = new Size(62, 66);
            btn1.TabIndex = 0;
            btn1.Text = "9";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_number;
            // 
            // btn2
            // 
            btn2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn2.Location = new Point(104, 166);
            btn2.Name = "btn2";
            btn2.Size = new Size(62, 66);
            btn2.TabIndex = 1;
            btn2.Text = "8";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_number;
            // 
            // btn3
            // 
            btn3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn3.Location = new Point(182, 166);
            btn3.Name = "btn3";
            btn3.Size = new Size(62, 66);
            btn3.TabIndex = 2;
            btn3.Text = "7";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_number;
            // 
            // btn4
            // 
            btn4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn4.Location = new Point(27, 258);
            btn4.Name = "btn4";
            btn4.Size = new Size(62, 66);
            btn4.TabIndex = 3;
            btn4.Text = "6";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_number;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(270, 166);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(62, 66);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += number_operators;
            // 
            // btnSubtraction
            // 
            btnSubtraction.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnSubtraction.Location = new Point(270, 258);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(62, 66);
            btnSubtraction.TabIndex = 5;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = true;
            btnSubtraction.Click += number_operators;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnMultiplication.Location = new Point(270, 349);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(62, 66);
            btnMultiplication.TabIndex = 6;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += number_operators;
            // 
            // btn8
            // 
            btn8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn8.Location = new Point(183, 349);
            btn8.Name = "btn8";
            btn8.Size = new Size(62, 66);
            btn8.TabIndex = 7;
            btn8.Text = "1";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_number;
            // 
            // btn9
            // 
            btn9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn9.Location = new Point(104, 349);
            btn9.Name = "btn9";
            btn9.Size = new Size(62, 66);
            btn9.TabIndex = 8;
            btn9.Text = "2";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn_number;
            // 
            // btn10
            // 
            btn10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn10.Location = new Point(27, 349);
            btn10.Name = "btn10";
            btn10.Size = new Size(62, 66);
            btn10.TabIndex = 9;
            btn10.Text = "3";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn_number;
            // 
            // btn11
            // 
            btn11.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn11.Location = new Point(27, 432);
            btn11.Name = "btn11";
            btn11.Size = new Size(62, 66);
            btn11.TabIndex = 10;
            btn11.Text = "0";
            btn11.UseVisualStyleBackColor = true;
            btn11.Click += btn_number;
            // 
            // btn12
            // 
            btn12.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn12.Location = new Point(183, 258);
            btn12.Name = "btn12";
            btn12.Size = new Size(62, 66);
            btn12.TabIndex = 11;
            btn12.Text = "4";
            btn12.UseVisualStyleBackColor = true;
            btn12.Click += btn_number;
            // 
            // btn13
            // 
            btn13.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btn13.Location = new Point(104, 258);
            btn13.Name = "btn13";
            btn13.Size = new Size(62, 66);
            btn13.TabIndex = 12;
            btn13.Text = "5";
            btn13.UseVisualStyleBackColor = true;
            btn13.Click += btn_number;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnEqual.Location = new Point(104, 432);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(62, 66);
            btnEqual.TabIndex = 13;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += equal_function;
            // 
            // btnAllClear
            // 
            btnAllClear.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnAllClear.Location = new Point(183, 432);
            btnAllClear.Name = "btnAllClear";
            btnAllClear.Size = new Size(62, 66);
            btnAllClear.TabIndex = 14;
            btnAllClear.Text = "A/C";
            btnAllClear.UseVisualStyleBackColor = true;
            btnAllClear.Click += btnAllClear_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnDivision.Location = new Point(270, 432);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(62, 66);
            btnDivision.TabIndex = 15;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += number_operators;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(27, 74);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(305, 60);
            txtDisplay.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(380, 531);
            Controls.Add(txtDisplay);
            Controls.Add(btnDivision);
            Controls.Add(btnAllClear);
            Controls.Add(btnEqual);
            Controls.Add(btn13);
            Controls.Add(btn12);
            Controls.Add(btn11);
            Controls.Add(btn10);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btnMultiplication);
            Controls.Add(btnSubtraction);
            Controls.Add(btnAdd);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btnAdd;
        private Button btnSubtraction;
        private Button btnMultiplication;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private Button btn11;
        private Button btn12;
        private Button btn13;
        private Button btnEqual;
        private Button btnAllClear;
        private Button btnDivision;
        private TextBox txtDisplay;
    }
}
