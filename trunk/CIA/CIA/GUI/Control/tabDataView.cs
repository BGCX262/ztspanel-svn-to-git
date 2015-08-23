using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class tabDataView : UserControl
    {
        public tabDataView()
        {
            InitializeComponent();
        }

        private void tabDataView_Load(object sender, EventArgs e)
        {
            String rodi="rodiah";
            cmbSelectView.SelectedIndex = 0;
            GridData grid = new GridData();
            TabPage baru = new TabPage();
            variableViewCollection.TabPages.Add(baru);
            baru.Controls.Add(grid);
            baru.Text = rodi;
           
        }
    }
}
