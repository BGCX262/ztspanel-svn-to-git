using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class WelcomeScreen : Form
    {
        private MDIForm mainForm;
        
        public WelcomeScreen(MDIForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCreateNew_Click(object sender, EventArgs e)
        {
            if (new CreateNewProject(mainForm).ShowDialog() == DialogResult.OK) {
                this.Close();
            }
        }

        private void pictureBoxCreateNew_Click(object sender, EventArgs e)
        {
            labelCreateNew_Click(sender, e);
        }
    }
}