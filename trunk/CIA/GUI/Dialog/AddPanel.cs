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
    public partial class AddPanel : Form
    {
        
        public AddPanel()
        {
            InitializeComponent();
        }

        private void cmdOK_Click (object sender, EventArgs e) {
            if (nameTxtBox.Text.Length < 1) {
                if (MessageBox.Show("Type panel name") == DialogResult.OK) {
                    this.DialogResult = DialogResult.None;
                }
            } else {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cmdCancel_Click (object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddPanel_FormClosing (object sender, FormClosingEventArgs e) {
            if (this.DialogResult == DialogResult.None) {
                e.Cancel = true;
            }
        }
    }
}
