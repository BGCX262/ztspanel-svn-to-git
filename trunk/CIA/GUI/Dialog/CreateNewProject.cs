using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using zaftime.Data;

namespace WindowsFormsApplication1
{
    public partial class CreateNewProject : Form
    {
        private DateTime startDate = new DateTime();
        private DateTime endDate = new DateTime();
        private MDIForm mainForm;
        private SeriesData.SeriesFrequency frequency = new SeriesData.SeriesFrequency();
                
        public CreateNewProject(MDIForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.DialogResult = DialogResult.None;
            comboFrequency.SelectedIndex = 0;
        }

        public SeriesData.SeriesFrequency Frequency {
            get {
                return this.frequency;
            }
        }
        
        public DateTime StartDate
        {
            get { return this.startDate; }
        }

        public DateTime EndDate
        {
            get { return this.endDate; }
        }

        public string DataName
        {
            get { return this.textFieldName.Text; }
        }

        public int NumberObservations
        {
            get { return int.Parse(this.labelJumlahObs.Text); }
        }

        private void CreateNewProject_Load(object sender, EventArgs e)
        {            
            this.initializeDate();
            
        }

        private void initializeDate()
        {
            numYearStart.Value = DateTime.Now.Year;
            numYearEnd.Value = DateTime.Now.Year;
            numMonthStart.Value = 1;
            numMonthEnd.Value = 1;
            timePickerStart.Value = DateTime.Now;
            timePickerEnd.Value = DateTime.Now;
            labelJumlahObs.Text = "1";
        }

        private void comboFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.frequency = (SeriesData.SeriesFrequency)this.comboFrequency.SelectedIndex;
            this.viewSpecificationPane((SeriesData.SeriesFrequency)this.comboFrequency.SelectedIndex); 
        }

        private void viewSpecificationPane (SeriesData.SeriesFrequency frequency) {
            labelObservation.Show();
            labelJumlahObs.Show();
            switch (frequency) {
                case SeriesData.SeriesFrequency.Annual:
                    groupDate.Visible = false;
                    groupYear.Visible = true;
                    groupUndated.Visible = false;

                    labelQuarter.Text = "Month: ";
                    numMonthStart.Enabled = false;
                    numMonthEnd.Enabled = false;

                    this.calculateStartDate();
                    this.calculateEndDate();

                    break;
                case SeriesData.SeriesFrequency.SemiAnnual:
                    groupDate.Visible = false;
                    groupYear.Visible = true;
                    groupUndated.Visible = false;

                    labelQuarter.Text = "Half: ";
                    numMonthStart.Enabled = true;
                    numMonthEnd.Enabled = true;
                    numMonthStart.Maximum = 2;
                    numMonthEnd.Maximum = 2;

                    this.calculateStartDate();
                    this.calculateEndDate();

                    break;
                case SeriesData.SeriesFrequency.Quarterly:
                    groupDate.Visible = false;
                    groupYear.Visible = true;
                    groupUndated.Visible = false;

                    labelQuarter.Text = "Quarter: ";
                    numMonthStart.Enabled = true;
                    numMonthEnd.Enabled = true;
                    numMonthStart.Maximum = 4;
                    numMonthEnd.Maximum = 4;

                    this.calculateStartDate();
                    this.calculateEndDate();

                    break;
                case SeriesData.SeriesFrequency.Monthly:
                    groupDate.Visible = false;
                    groupYear.Visible = true;
                    groupUndated.Visible = false;

                    labelQuarter.Text = "Month: ";
                    numMonthStart.Enabled = true;
                    numMonthEnd.Enabled = true;
                    numMonthStart.Maximum = 12;
                    numMonthEnd.Maximum = 12;

                    this.calculateStartDate();
                    this.calculateEndDate();

                    break;
                case SeriesData.SeriesFrequency.Weekly:
                    groupDate.Visible = true;
                    groupYear.Visible = false;
                    groupUndated.Visible = false;

                    this.startDate = this.timePickerStart.Value;
                    this.endDate = this.timePickerEnd.Value;
                    this.displayNumberObservations();

                    break;
                case SeriesData.SeriesFrequency.Daily:
                    groupDate.Visible = true;
                    groupYear.Visible = false;
                    groupUndated.Visible = false;

                    this.startDate = this.timePickerStart.Value;
                    this.endDate = this.timePickerEnd.Value;
                    this.displayNumberObservations();

                    break;
                case SeriesData.SeriesFrequency.Daily6:
                    groupDate.Visible = true;
                    groupYear.Visible = false;
                    groupUndated.Visible = false;

                    this.startDate = this.timePickerStart.Value;
                    this.endDate = this.timePickerEnd.Value;
                    this.displayNumberObservations();

                    break;
                case SeriesData.SeriesFrequency.Daily5:
                    groupDate.Visible = true;
                    groupYear.Visible = false;
                    groupUndated.Visible = false;

                    this.startDate = this.timePickerStart.Value;
                    this.endDate = this.timePickerEnd.Value;
                    this.displayNumberObservations();

                    break;
                case SeriesData.SeriesFrequency.Undated:
                    groupDate.Visible = false;
                    groupYear.Visible = false;
                    groupUndated.Visible = true;
                    labelObservation.Hide();
                    labelJumlahObs.Hide();

                    try {
                        this.setNumberObservations(int.Parse(labelJumlahObs.Text));
                    } catch {
                        this.setNumberObservations(0);
                    }

                    break;
            }
        }

        private void calculateStartDate () {
            int year = (int)this.numYearStart.Value;
            int month = 1;
            switch (this.frequency) {
                case SeriesData.SeriesFrequency.Annual:
                    month = 1;
                    break;
                case SeriesData.SeriesFrequency.SemiAnnual:
                    month = (int)this.numMonthStart.Value * 6;
                    break;
                case SeriesData.SeriesFrequency.Quarterly:
                    month = (int)this.numMonthStart.Value * 3;
                    break;
                case SeriesData.SeriesFrequency.Monthly:
                    month = (int)this.numMonthStart.Value;
                    break;
            }

            DateTime tmp = new DateTime(year, month, 1);
            this.startDate = tmp;

            this.displayNumberObservations();
        }

        private void calculateEndDate () {
            int year = (int)this.numYearEnd.Value;
            int month = 1;
            switch (this.frequency) {
                case SeriesData.SeriesFrequency.Annual:
                    month = 1;
                    break;
                case SeriesData.SeriesFrequency.SemiAnnual:
                    month = (int)this.numMonthEnd.Value * 6;
                    break;
                case SeriesData.SeriesFrequency.Quarterly:
                    month = (int)this.numMonthEnd.Value * 3;
                    break;
                case SeriesData.SeriesFrequency.Monthly:
                    month = (int)this.numMonthEnd.Value;
                    break;
            }

            DateTime tmp = new DateTime(year, month, 1);
            this.endDate = tmp;

            this.displayNumberObservations();
        }

        private void displayNumberObservations () {
            int count = SeriesData.NumberObservation(this.startDate, this.endDate, this.frequency);
            this.setNumberObservations(count);
        }

        private void setNumberObservations (int value) {
            labelJumlahObs.Text = value.ToString();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (textFieldName.Text.Length < 1)
            {
                if(MessageBox.Show(this, "Type project name", "Create New Project", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.None;
                }
            } 
            else if (this.frequency != SeriesData.SeriesFrequency.Undated && this.startDate >= this.endDate) 
            {
                if (MessageBox.Show("Set the correct time", "Create New Project", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else if (this.frequency == SeriesData.SeriesFrequency.Undated)
            {
                if (numericTextBoxJmlObs.Text.Trim().Length == 0)
                    numericTextBoxJmlObs.Text = "1";
                if (Int32.Parse(numericTextBoxJmlObs.Text) == 0)
                {
                    if (MessageBox.Show("Number of observation must be greater than 0", "Create New Project", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.None;
                    }
                }
            }
            else
            {
                // Create a new instance of the child form.
                DataForm childForm = new DataForm(mainForm);
                // Make it a child of this MDI form before showing it.
                childForm.MdiParent = mainForm;
                mainForm.childFormNumber++;
                childForm.CreateNewData(this);
                childForm.Show();
                childForm.WindowState = FormWindowState.Maximized;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void timePickerEnd_ValueChanged (object sender, EventArgs e) {
            this.endDate = this.timePickerEnd.Value;
            this.displayNumberObservations();
        }

        private void timePickerStart_ValueChanged (object sender, EventArgs e) {
            this.startDate = this.timePickerStart.Value;
            this.displayNumberObservations();
        }

        private void numYearStart_ValueChanged (object sender, EventArgs e) {
            this.calculateStartDate();
        }

        private void numMonthStart_ValueChanged (object sender, EventArgs e) {
            this.calculateStartDate();
        }

        private void numYearEnd_ValueChanged (object sender, EventArgs e) {
            this.calculateEndDate();
        }

        private void numMonthEnd_ValueChanged (object sender, EventArgs e) {
            this.calculateEndDate();
        }

        private void buttonCancel_Click (object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CreateNewProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                e.Cancel = true;
            }
        }
    }
}
