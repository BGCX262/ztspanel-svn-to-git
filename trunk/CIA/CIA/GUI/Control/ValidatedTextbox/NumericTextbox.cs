using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.GUI
{
    public class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {
            this.TextAlign = HorizontalAlignment.Right;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.KeyChar = (char)Keys.None;
            base.OnKeyPress(e);
        }
    }
}
