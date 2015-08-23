using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class MDIForm : Form
    {
        public int childFormNumber = 0;
        
        public MDIForm()
        {
            InitializeComponent();

            this.Show();
            new WelcomeScreen(this).ShowDialog();
            
        }
    
        private void menuNewFile_Click(object sender, EventArgs e)
        {
            CreateNewProject frm = new CreateNewProject(null);
            frm.ShowDialog();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void newToolStripButton1_Click(object sender, EventArgs e)
        {
            CreateNewProject frm = new CreateNewProject(this);
            frm.ShowDialog();
        }

        private void openIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
        }
         private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
        }

        private void saveIcon_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
        }
    }
}