namespace WindowsFormsApplication1
{
    partial class CreateNewProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numMonthStart = new System.Windows.Forms.NumericUpDown();
            this.labelQuarter = new System.Windows.Forms.Label();
            this.timePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.numMonthEnd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lebelYear = new System.Windows.Forms.Label();
            this.numYearEnd = new System.Windows.Forms.NumericUpDown();
            this.labelFrequecy = new System.Windows.Forms.Label();
            this.groupDate = new System.Windows.Forms.GroupBox();
            this.timePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboFrequency = new System.Windows.Forms.ComboBox();
            this.labelObs = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numYearStart = new System.Windows.Forms.NumericUpDown();
            this.labelNama = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textFieldName = new WindowsFormsApplication1.GUI.NameTextBox();
            this.groupYear = new System.Windows.Forms.GroupBox();
            this.groupUndated = new System.Windows.Forms.GroupBox();
            this.numericTextBoxJmlObs = new WindowsFormsApplication1.GUI.NumericTextBox();
            this.labelObservation = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelJumlahObs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearEnd)).BeginInit();
            this.groupDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearStart)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupYear.SuspendLayout();
            this.groupUndated.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numMonthStart
            // 
            this.numMonthStart.Location = new System.Drawing.Point(173, 40);
            this.numMonthStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonthStart.Name = "numMonthStart";
            this.numMonthStart.Size = new System.Drawing.Size(47, 20);
            this.numMonthStart.TabIndex = 6;
            this.numMonthStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonthStart.ValueChanged += new System.EventHandler(this.numMonthStart_ValueChanged);
            // 
            // labelQuarter
            // 
            this.labelQuarter.AutoSize = true;
            this.labelQuarter.Location = new System.Drawing.Point(170, 24);
            this.labelQuarter.Name = "labelQuarter";
            this.labelQuarter.Size = new System.Drawing.Size(45, 13);
            this.labelQuarter.TabIndex = 5;
            this.labelQuarter.Text = "Quarter:";
            this.labelQuarter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timePickerStart
            // 
            this.timePickerStart.CustomFormat = "dd MMMM yyyy";
            this.timePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerStart.Location = new System.Drawing.Point(89, 25);
            this.timePickerStart.Name = "timePickerStart";
            this.timePickerStart.Size = new System.Drawing.Size(154, 20);
            this.timePickerStart.TabIndex = 7;
            this.timePickerStart.ValueChanged += new System.EventHandler(this.timePickerStart_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Date:";
            // 
            // numMonthEnd
            // 
            this.numMonthEnd.Location = new System.Drawing.Point(173, 66);
            this.numMonthEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonthEnd.Name = "numMonthEnd";
            this.numMonthEnd.Size = new System.Drawing.Size(47, 20);
            this.numMonthEnd.TabIndex = 7;
            this.numMonthEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonthEnd.ValueChanged += new System.EventHandler(this.numMonthEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "End Date:";
            // 
            // lebelYear
            // 
            this.lebelYear.AutoSize = true;
            this.lebelYear.Location = new System.Drawing.Point(70, 24);
            this.lebelYear.Name = "lebelYear";
            this.lebelYear.Size = new System.Drawing.Size(32, 13);
            this.lebelYear.TabIndex = 4;
            this.lebelYear.Text = "Year:";
            // 
            // numYearEnd
            // 
            this.numYearEnd.Location = new System.Drawing.Point(61, 66);
            this.numYearEnd.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numYearEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYearEnd.Name = "numYearEnd";
            this.numYearEnd.Size = new System.Drawing.Size(73, 20);
            this.numYearEnd.TabIndex = 3;
            this.numYearEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYearEnd.ValueChanged += new System.EventHandler(this.numYearEnd_ValueChanged);
            // 
            // labelFrequecy
            // 
            this.labelFrequecy.AutoSize = true;
            this.labelFrequecy.Location = new System.Drawing.Point(22, 33);
            this.labelFrequecy.Name = "labelFrequecy";
            this.labelFrequecy.Size = new System.Drawing.Size(60, 13);
            this.labelFrequecy.TabIndex = 9;
            this.labelFrequecy.Text = "Frequency:";
            // 
            // groupDate
            // 
            this.groupDate.Controls.Add(this.timePickerEnd);
            this.groupDate.Controls.Add(this.label2);
            this.groupDate.Controls.Add(this.timePickerStart);
            this.groupDate.Controls.Add(this.label1);
            this.groupDate.Location = new System.Drawing.Point(16, 72);
            this.groupDate.Name = "groupDate";
            this.groupDate.Size = new System.Drawing.Size(263, 97);
            this.groupDate.TabIndex = 23;
            this.groupDate.TabStop = false;
            this.groupDate.Text = "Data";
            // 
            // timePickerEnd
            // 
            this.timePickerEnd.CustomFormat = "dd MMMM yyyy";
            this.timePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerEnd.Location = new System.Drawing.Point(89, 54);
            this.timePickerEnd.Name = "timePickerEnd";
            this.timePickerEnd.Size = new System.Drawing.Size(154, 20);
            this.timePickerEnd.TabIndex = 9;
            this.timePickerEnd.ValueChanged += new System.EventHandler(this.timePickerEnd_ValueChanged);
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(7, 66);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(29, 13);
            this.labelEnd.TabIndex = 2;
            this.labelEnd.Text = "End:";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(8, 40);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(32, 13);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Start:";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(41, 308);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 25);
            this.buttonOk.TabIndex = 27;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // comboFrequency
            // 
            this.comboFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFrequency.FormattingEnabled = true;
            this.comboFrequency.Items.AddRange(new object[] {
            "Annual",
            "Semi Annual",
            "Quarterly",
            "Monthly",
            "Weekly",
            "Daily (7 days a week)",
            "Daily6 (6 days a week)",
            "Daily5 (5 days a week)",
            "Undated"});
            this.comboFrequency.Location = new System.Drawing.Point(105, 30);
            this.comboFrequency.Name = "comboFrequency";
            this.comboFrequency.Size = new System.Drawing.Size(151, 21);
            this.comboFrequency.TabIndex = 8;
            this.comboFrequency.SelectedIndexChanged += new System.EventHandler(this.comboFrequency_SelectedIndexChanged);
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(10, 21);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(72, 13);
            this.labelObs.TabIndex = 1;
            this.labelObs.Text = "Observations:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(174, 308);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 25);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // numYearStart
            // 
            this.numYearStart.Location = new System.Drawing.Point(61, 40);
            this.numYearStart.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numYearStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYearStart.Name = "numYearStart";
            this.numYearStart.Size = new System.Drawing.Size(73, 20);
            this.numYearStart.TabIndex = 0;
            this.numYearStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYearStart.ValueChanged += new System.EventHandler(this.numYearStart_ValueChanged);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(23, 26);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(38, 13);
            this.labelNama.TabIndex = 14;
            this.labelNama.Text = "Name:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.textFieldName);
            this.groupBox5.Controls.Add(this.labelNama);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 56);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Project Name";
            // 
            // textFieldName
            // 
            this.textFieldName.Location = new System.Drawing.Point(105, 20);
            this.textFieldName.Name = "textFieldName";
            this.textFieldName.Size = new System.Drawing.Size(151, 20);
            this.textFieldName.TabIndex = 15;
            // 
            // groupYear
            // 
            this.groupYear.BackColor = System.Drawing.Color.Transparent;
            this.groupYear.Controls.Add(this.numMonthEnd);
            this.groupYear.Controls.Add(this.numMonthStart);
            this.groupYear.Controls.Add(this.labelQuarter);
            this.groupYear.Controls.Add(this.lebelYear);
            this.groupYear.Controls.Add(this.numYearEnd);
            this.groupYear.Controls.Add(this.labelEnd);
            this.groupYear.Controls.Add(this.labelStart);
            this.groupYear.Controls.Add(this.numYearStart);
            this.groupYear.Location = new System.Drawing.Point(16, 72);
            this.groupYear.Name = "groupYear";
            this.groupYear.Size = new System.Drawing.Size(263, 97);
            this.groupYear.TabIndex = 24;
            this.groupYear.TabStop = false;
            this.groupYear.Text = "Data";
            // 
            // groupUndated
            // 
            this.groupUndated.Controls.Add(this.numericTextBoxJmlObs);
            this.groupUndated.Controls.Add(this.labelObs);
            this.groupUndated.Location = new System.Drawing.Point(15, 72);
            this.groupUndated.Name = "groupUndated";
            this.groupUndated.Size = new System.Drawing.Size(264, 97);
            this.groupUndated.TabIndex = 25;
            this.groupUndated.TabStop = false;
            this.groupUndated.Text = "Data";
            // 
            // numericTextBoxJmlObs
            // 
            this.numericTextBoxJmlObs.Location = new System.Drawing.Point(89, 19);
            this.numericTextBoxJmlObs.Name = "numericTextBoxJmlObs";
            this.numericTextBoxJmlObs.Size = new System.Drawing.Size(154, 20);
            this.numericTextBoxJmlObs.TabIndex = 2;
            this.numericTextBoxJmlObs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelObservation
            // 
            this.labelObservation.AutoSize = true;
            this.labelObservation.BackColor = System.Drawing.SystemColors.Control;
            this.labelObservation.Location = new System.Drawing.Point(24, 178);
            this.labelObservation.Name = "labelObservation";
            this.labelObservation.Size = new System.Drawing.Size(67, 13);
            this.labelObservation.TabIndex = 33;
            this.labelObservation.Text = "Observation:";
            this.labelObservation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelJumlahObs);
            this.groupBox3.Controls.Add(this.comboFrequency);
            this.groupBox3.Controls.Add(this.groupDate);
            this.groupBox3.Controls.Add(this.labelObservation);
            this.groupBox3.Controls.Add(this.labelFrequecy);
            this.groupBox3.Controls.Add(this.groupYear);
            this.groupBox3.Controls.Add(this.groupUndated);
            this.groupBox3.Location = new System.Drawing.Point(12, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 214);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Panel Specification";
            // 
            // labelJumlahObs
            // 
            this.labelJumlahObs.Location = new System.Drawing.Point(101, 178);
            this.labelJumlahObs.Name = "labelJumlahObs";
            this.labelJumlahObs.Size = new System.Drawing.Size(84, 19);
            this.labelJumlahObs.TabIndex = 34;
            this.labelJumlahObs.Text = "1";
            // 
            // CreateNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 349);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(322, 383);
            this.MinimumSize = new System.Drawing.Size(322, 383);
            this.Name = "CreateNewProject";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Project";
            this.Load += new System.EventHandler(this.CreateNewProject_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateNewProject_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numMonthStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearEnd)).EndInit();
            this.groupDate.ResumeLayout(false);
            this.groupDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearStart)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupYear.ResumeLayout(false);
            this.groupYear.PerformLayout();
            this.groupUndated.ResumeLayout(false);
            this.groupUndated.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numMonthStart;
        private System.Windows.Forms.Label labelQuarter;
        private System.Windows.Forms.DateTimePicker timePickerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMonthEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lebelYear;
        private System.Windows.Forms.NumericUpDown numYearEnd;
        private System.Windows.Forms.Label labelFrequecy;
        private System.Windows.Forms.GroupBox groupDate;
        private System.Windows.Forms.DateTimePicker timePickerEnd;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numYearStart;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupYear;
        private System.Windows.Forms.GroupBox groupUndated;
        private System.Windows.Forms.Label labelObservation;
        private System.Windows.Forms.GroupBox groupBox3;
        private WindowsFormsApplication1.GUI.NumericTextBox numericTextBoxJmlObs;
        internal System.Windows.Forms.Label labelJumlahObs;
        internal System.Windows.Forms.ComboBox comboFrequency;
        internal WindowsFormsApplication1.GUI.NameTextBox textFieldName;
    }
}