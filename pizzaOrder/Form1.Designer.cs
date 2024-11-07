namespace pizzaOrder
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
            label1 = new Label();
            radioSmall = new RadioButton();
            radioMedium = new RadioButton();
            radioLarze = new RadioButton();
            radioPickUp = new RadioButton();
            radioDelivery = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            checkBox_Bacon = new CheckBox();
            checkBox_BBQchicken = new CheckBox();
            checkBox_cheese = new CheckBox();
            checkBox_Veggies = new CheckBox();
            btn_ok = new Button();
            btn_Exit = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 16);
            label1.Name = "label1";
            label1.Size = new Size(367, 34);
            label1.TabIndex = 0;
            label1.Text = "Base Pizza Price: $10";
            // 
            // radioSmall
            // 
            radioSmall.AutoSize = true;
            radioSmall.Location = new Point(6, 26);
            radioSmall.Name = "radioSmall";
            radioSmall.Size = new Size(100, 24);
            radioSmall.TabIndex = 1;
            radioSmall.Text = "Small $5";
            radioSmall.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            radioMedium.AutoSize = true;
            radioMedium.Location = new Point(6, 56);
            radioMedium.Name = "radioMedium";
            radioMedium.Size = new Size(129, 24);
            radioMedium.TabIndex = 2;
            radioMedium.Text = "Medium $10";
            radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioLarze
            // 
            radioLarze.AutoSize = true;
            radioLarze.Location = new Point(6, 95);
            radioLarze.Name = "radioLarze";
            radioLarze.Size = new Size(110, 24);
            radioLarze.TabIndex = 3;
            radioLarze.Text = "Larze $15";
            radioLarze.UseVisualStyleBackColor = true;
            // 
            // radioPickUp
            // 
            radioPickUp.AutoSize = true;
            radioPickUp.Location = new Point(6, 35);
            radioPickUp.Name = "radioPickUp";
            radioPickUp.Size = new Size(94, 24);
            radioPickUp.TabIndex = 4;
            radioPickUp.Text = "Pick Up";
            radioPickUp.UseVisualStyleBackColor = true;
            // 
            // radioDelivery
            // 
            radioDelivery.AutoSize = true;
            radioDelivery.Location = new Point(6, 85);
            radioDelivery.Name = "radioDelivery";
            radioDelivery.Size = new Size(122, 24);
            radioDelivery.TabIndex = 5;
            radioDelivery.Text = "Delivery $5";
            radioDelivery.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioSmall);
            groupBox1.Controls.Add(radioMedium);
            groupBox1.Controls.Add(radioLarze);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(28, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pizza Size";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioPickUp);
            groupBox2.Controls.Add(radioDelivery);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(28, 284);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delivery Mode";
            // 
            // checkBox_Bacon
            // 
            checkBox_Bacon.AutoSize = true;
            checkBox_Bacon.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_Bacon.ForeColor = SystemColors.ButtonHighlight;
            checkBox_Bacon.Location = new Point(6, 26);
            checkBox_Bacon.Name = "checkBox_Bacon";
            checkBox_Bacon.Size = new Size(107, 24);
            checkBox_Bacon.TabIndex = 8;
            checkBox_Bacon.Text = "Bacon $5";
            checkBox_Bacon.UseVisualStyleBackColor = true;
            // 
            // checkBox_BBQchicken
            // 
            checkBox_BBQchicken.AutoSize = true;
            checkBox_BBQchicken.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_BBQchicken.Location = new Point(6, 59);
            checkBox_BBQchicken.Name = "checkBox_BBQchicken";
            checkBox_BBQchicken.Size = new Size(168, 24);
            checkBox_BBQchicken.TabIndex = 9;
            checkBox_BBQchicken.Text = "BBQ Chicken $ 6";
            checkBox_BBQchicken.UseVisualStyleBackColor = true;
            // 
            // checkBox_cheese
            // 
            checkBox_cheese.AutoSize = true;
            checkBox_cheese.Location = new Point(6, 85);
            checkBox_cheese.Name = "checkBox_cheese";
            checkBox_cheese.Size = new Size(117, 24);
            checkBox_cheese.TabIndex = 10;
            checkBox_cheese.Text = "Cheese $2";
            checkBox_cheese.UseVisualStyleBackColor = true;
            // 
            // checkBox_Veggies
            // 
            checkBox_Veggies.AutoSize = true;
            checkBox_Veggies.Location = new Point(6, 116);
            checkBox_Veggies.Name = "checkBox_Veggies";
            checkBox_Veggies.Size = new Size(123, 24);
            checkBox_Veggies.TabIndex = 11;
            checkBox_Veggies.Text = "Veggies $4";
            checkBox_Veggies.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(434, 319);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(94, 29);
            btn_ok.TabIndex = 12;
            btn_ok.Text = "OK!";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(585, 319);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 13;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox_Bacon);
            groupBox3.Controls.Add(checkBox_BBQchicken);
            groupBox3.Controls.Add(checkBox_cheese);
            groupBox3.Controls.Add(checkBox_Veggies);
            groupBox3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(434, 81);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(192, 178);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Toppings";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(btn_Exit);
            Controls.Add(btn_ok);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PIZZA ORDER";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioSmall;
        private RadioButton radioMedium;
        private RadioButton radioLarze;
        private RadioButton radioPickUp;
        private RadioButton radioDelivery;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox checkBox_Bacon;
        private CheckBox checkBox_BBQchicken;
        private CheckBox checkBox_cheese;
        private CheckBox checkBox_Veggies;
        private Button btn_ok;
        private Button btn_Exit;
        private GroupBox groupBox3;
    }
}
