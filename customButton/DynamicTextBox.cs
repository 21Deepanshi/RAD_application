using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customButton
{
    public class DynamicTextBox : TextBox
    {
        public DynamicTextBox()
        {
            this.TextChanged += DynamicTextBox_TextChanged;
        }

        private void DynamicTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length >= 10)
            {
                this.BackColor = Color.Red;
                this.ForeColor = Color.Yellow;
            }
            else if (this.Text.Length >= 5)
            {
                this.BackColor = Color.Green;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = Color.DeepPink;
            }
        }
    }
    
}
