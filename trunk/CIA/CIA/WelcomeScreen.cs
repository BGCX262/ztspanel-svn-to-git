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

        private void createNewPictureBox_Click(object sender, EventArgs e)
        {
            new CreateNewProject(mainForm).ShowDialog();
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {
            this.createNewPictureBox_Click(sender, e);
        }

    }
}