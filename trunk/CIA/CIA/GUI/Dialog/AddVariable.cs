using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.GUI.Dialog
{
    public partial class AddVariable : Form
    {
        public AddVariable()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length < 1)
            {
                if (MessageBox.Show("Type variable name") == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.None;
                }
            } else if (!(comboBoxPanel.SelectedIndex >= 0)) {
                if (MessageBox.Show("Choose the correct panel") == DialogResult.OK) {
                    this.DialogResult = DialogResult.None;
                }
            } else {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void AddVariable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                e.Cancel = true;
            }
        }
    }
}
