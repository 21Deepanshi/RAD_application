using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customButton
{
    public class button : Button
    {
        public button()
        {
            this.MouseEnter += this.CustomerButton_MouseEnter;
            this.MouseLeave += this.CustomerButton_MouseLeave;
        }

        private void CustomerButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
        }

        private void CustomerButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }
    }
}
