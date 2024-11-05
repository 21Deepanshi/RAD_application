namespace FruitList
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
            listFruit = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            txtAddItems = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // listFruit
            // 
            listFruit.FormattingEnabled = true;
            listFruit.Items.AddRange(new object[] { "Apple", "Banana", "Grapes", "Orange" });
            listFruit.Location = new Point(48, 61);
            listFruit.Name = "listFruit";
            listFruit.Size = new Size(161, 124);
            listFruit.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(381, 261);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(381, 95);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtAddItems
            // 
            txtAddItems.Location = new Point(48, 263);
            txtAddItems.Name = "txtAddItems";
            txtAddItems.Size = new Size(219, 27);
            txtAddItems.TabIndex = 3;
            txtAddItems.KeyDown += txtAddItems_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 233);
            label1.Name = "label1";
            label1.Size = new Size(104, 27);
            label1.TabIndex = 4;
            label1.Text = "Add Items:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 25);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 5;
            label2.Text = "Fruit:";
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlDark;
            btnExit.Location = new Point(496, 95);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 340);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddItems);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(listFruit);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fruit List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listFruit;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtAddItems;
        private Label label1;
        private Label label2;
        private Button btnExit;
    }
}
