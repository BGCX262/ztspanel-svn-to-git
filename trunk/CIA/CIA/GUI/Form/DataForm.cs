using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using zaftime.Data;
using WindowsFormsApplication1.GUI.Dialog;
using WindowsFormsApplication1.GUI.Control;

namespace WindowsFormsApplication1
{
    public partial class DataForm : Form
    {
        private MDIForm mainForm;
        private SeriesData data;

        public DataForm(MDIForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
        
        public void CreateNewData(CreateNewProject createNewProjDialog)
        {
            if (createNewProjDialog.Frequency != SeriesData.SeriesFrequency.Undated)
                data = new SeriesData(createNewProjDialog.DataName, createNewProjDialog.Frequency, createNewProjDialog.StartDate, createNewProjDialog.EndDate);
            else                
                data = new SeriesData(createNewProjDialog.DataName, createNewProjDialog.NumberObservations);
           this.Text = createNewProjDialog.DataName + " : \"Unsaved\"";
        }

        private void DataForm_FormClosed (object sender, FormClosedEventArgs e) {
            mainForm.childFormNumber--;
        }

        private void buttonAddPanel_Click(object sender, EventArgs e)
        {
            AddPanel addPanel = new AddPanel();
            if (addPanel.ShowDialog() == DialogResult.OK) {
                string panelName = addPanel.nameTxtBox.Text;
                bool nameUnique = true;
                foreach (DataGridViewRow row in panelTable.Rows)
                {
                    if(row.Cells[0].Value.ToString().Equals(panelName))
                    {
                        nameUnique = false;
                        Console.WriteLine("sama");
                        break;
                    }
                }
                if (nameUnique)
                {
                    panelTable.Rows.Add(new Object [ ] {panelName, addPanel.descriptionTxtField.Text});
                    TabPage tab = new TabPage(panelName);
                    if (tabControlData.TabCount == 0) 
                    {
                        tabControlData.TabPages.Add(tab);
                    } 
                    else if (tabControlData.TabCount == 1)
                    {
                        tabControlData.TabPages.Add("Y");
                        tabControlData.TabPages.Insert(tabControlData.TabCount - 1, tab);
                    } 
                    else 
                    {
                        tabControlData.TabPages.Insert(tabControlData.TabCount - 1, tab);
                    }
                }
                else
                {
                    MessageBox.Show("Name of panel has already exist");
                    buttonAddPanel_Click(sender, e);
                }
            }
        }

        private void buttonEditPanel_Click (object sender, EventArgs e) {
            AddPanel addPanel = new AddPanel();
            addPanel.Text = "Edit";
            string panelName = panelTable.SelectedRows [ 0 ].Cells [0].Value.ToString();
            addPanel.nameTxtBox.Text = panelName;
            addPanel.descriptionTxtField.Text = panelTable.SelectedRows [ 0 ].Cells [1].Value.ToString();
            if (addPanel.ShowDialog() == DialogResult.OK) {
                panelTable.SelectedRows [ 0 ].Cells [ 0 ].Value = addPanel.nameTxtBox.Text;
                panelTable.SelectedRows [ 0 ].Cells [ 1 ].Value = addPanel.descriptionTxtField.Text;
                for (int i = 0; i < tabControlData.TabPages.Count; i++)
                {
                    if (tabControlData.TabPages[i].Text == panelName)
                    {
                        tabControlData.TabPages[i].Text = addPanel.nameTxtBox.Text;
                    }
                }
            }
        }

        private void buttonDeletePanel_Click (object sender, EventArgs e) {
            bool hasVariable = false;
            string panelName = panelTable.SelectedRows [ 0 ].Cells [ 0 ].Value.ToString();
            foreach (DataGridViewRow row in dataGridViewVar.Rows) {
                if (row.Cells [ 2 ].Value.ToString().Equals(panelName)) {
                    hasVariable = true;
                    break;
                }
            }
            if (hasVariable) {
                if (MessageBox.Show("This panel contains of some variables. \nDeleting of this panel will make the variables deleted. \nAre you sure?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                    foreach (DataGridViewRow row in dataGridViewVar.Rows) {
                        if (row.Cells [ 2 ].Value.ToString().Equals(panelName)) {
                            dataGridViewVar.Rows.Remove(row);
                        }
                    }
                    panelTable.Rows.Remove(panelTable.SelectedRows [ 0 ]);
                    for (int i = 0; i < tabControlData.TabPages.Count; i++)
                    {
                        if (tabControlData.TabPages[i].Text == panelName)
                        {
                            tabControlData.TabPages.Remove(tabControlData.TabPages[i]);
                            break;
                        }
                    }
                    if (tabControlData.TabCount == 2) {
                        tabControlData.TabPages.RemoveAt(1);
                    }
                }
            } else {
                panelTable.Rows.Remove(panelTable.SelectedRows [ 0 ]);
                for (int i = 0; i < tabControlData.TabPages.Count; i++)
                {
                    if (tabControlData.TabPages[i].Text == panelName)
                    {
                        tabControlData.TabPages.Remove(tabControlData.TabPages[i]);
                    }
                }
                //tabControlData.TabPages.RemoveByKey(panelName);
            }

        }

        private void buttonDuplicatePanel_Click (object sender, EventArgs e) {
            panelTable.Rows.Add(new object [ ] {"copy of " + panelTable.SelectedRows[0].Cells[0].Value.ToString(), 
                panelTable.SelectedRows[0].Cells[1].Value.ToString() });
        }

        private void buttonAddVar_Click(object sender, EventArgs e)
        {
            AddVariable addvariable = new AddVariable();
            for (int i = 0; i < panelTable.Rows.Count; i++)
            {
                addvariable.comboBoxPanel.Items.Add(panelTable.Rows[i].Cells[0].Value.ToString());
            }
            if (addvariable.ShowDialog() == DialogResult.OK)
            {
                string variableName = addvariable.nameTextBox.Text;
                bool nameUnique = true;
                foreach (DataGridViewRow row in dataGridViewVar.Rows) {
                    if (row.Cells [ 0 ].Value.ToString().Equals(variableName)) {
                        nameUnique = false;
                        break;
                    }
                }
                if (nameUnique) {
                    dataGridViewVar.Rows.Add(new Object [ ] { variableName, addvariable.txtDescription.Text, addvariable.comboBoxPanel.SelectedItem });
                } else {
                    MessageBox.Show("Name of variable has already exist");
                    buttonAddVar_Click(sender, e);
                }
                
            }
        }

        private void buttonEditVar_Click(object sender, EventArgs e)
        {
            AddVariable addVariable = new AddVariable();
            addVariable.Text = "Edit";
            addVariable.nameTextBox.Text = dataGridViewVar.SelectedRows[0].Cells[0].Value.ToString();
            addVariable.txtDescription.Text = dataGridViewVar.SelectedRows[0].Cells[1].Value.ToString();
            for (int i = 0; i < panelTable.Rows.Count; i++)
            {
                addVariable.comboBoxPanel.Items.Add(panelTable.Rows[i].Cells[0].Value.ToString());
            }
            addVariable.comboBoxPanel.SelectedItem = dataGridViewVar.SelectedRows[0].Cells[2].Value.ToString();
            if (addVariable.ShowDialog() == DialogResult.OK)
            {
                dataGridViewVar.SelectedRows[0].Cells[0].Value = addVariable.nameTextBox.Text;
                dataGridViewVar.SelectedRows[0].Cells[1].Value = addVariable.txtDescription.Text;
                dataGridViewVar.SelectedRows[0].Cells[2].Value = addVariable.comboBoxPanel.SelectedItem;
            }
        }

        private void buttonDuplicateVar_Click(object sender, EventArgs e)
        {
            dataGridViewVar.Rows.Add(new object[] {"copy of " + dataGridViewVar.SelectedRows[0].Cells[0].Value.ToString(), 
                dataGridViewVar.SelectedRows[0].Cells[1].Value.ToString(), dataGridViewVar.SelectedRows[0].Cells[2].Value.ToString() });
        }

        private void buttonDeleteVar_Click(object sender, EventArgs e)
        {
            dataGridViewVar.Rows.Remove(dataGridViewVar.SelectedRows[0]);
        }

        private void button1_Click (object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                TabPage tab = new TabPage("Panel2");
                DataEntryPanel dataEntry = new DataEntryPanel();
                dataEntry.dataGridView1.Columns.Add("var1", "Variabel 1");
                dataEntry.dataGridView1.Columns.Add("var2", "Variabel 2");
                dataEntry.Dock = System.Windows.Forms.DockStyle.Fill;
                tab.Controls.Add(dataEntry);
                tabControlData.TabPages.Add(tab);
            }
        }
    }
}