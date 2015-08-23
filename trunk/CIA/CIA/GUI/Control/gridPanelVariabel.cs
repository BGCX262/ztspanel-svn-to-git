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
    public partial class gridPanelVariabel : UserControl
    {
        public gridPanelVariabel()
        {
            InitializeComponent();
            //gridPanelVariabel = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGridViewCell cell = new WindowsFormsApplication1.GUI.ValidatedNameTextBoxCell();

            clmName.CellTemplate = cell;
            clmDescription.CellTemplate = cell;
        }
    }
}
