using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.GUI
{
    public class ValidatedNameTextBoxEditingControl : DataGridViewTextBoxEditingControl
    {
        public ValidatedNameTextBoxEditingControl()
            : base()
        {
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.KeyChar = (char)Keys.None;
            base.OnKeyPress(e);
        }

    }
}
