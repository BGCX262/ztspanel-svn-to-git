namespace Fuzzy.Control
{
    partial class Variable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaveMF = new System.Windows.Forms.Button();
            this.btnAddMF = new System.Windows.Forms.Button();
            this.groupBoxCurrentMF = new System.Windows.Forms.GroupBox();
            this.textBoxParams = new System.Windows.Forms.TextBox();
            this.lblParam = new System.Windows.Forms.Label();
            this.comboBoxTypeMF = new System.Windows.Forms.ComboBox();
            this.lblTypeMF = new System.Windows.Forms.Label();
            this.textBoxNameMF = new System.Windows.Forms.TextBox();
            this.lblNameMF = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblListMF = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.textBoxVarName = new System.Windows.Forms.TextBox();
            this.lblvarName = new System.Windows.Forms.Label();
            this.btnRemoveMF = new System.Windows.Forms.Button();
            this.groupBoxCurrentMF.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveMF
            // 
            this.btnSaveMF.Location = new System.Drawing.Point(476, 352);
            this.btnSaveMF.Name = "btnSaveMF";
            this.btnSaveMF.Size = new System.Drawing.Size(121, 25);
            this.btnSaveMF.TabIndex = 17;
            this.btnSaveMF.Text = "Save Membership";
            this.btnSaveMF.UseVisualStyleBackColor = true;
            // 
            // btnAddMF
            // 
            this.btnAddMF.Location = new System.Drawing.Point(476, 385);
            this.btnAddMF.Name = "btnAddMF";
            this.btnAddMF.Size = new System.Drawing.Size(121, 25);
            this.btnAddMF.TabIndex = 22;
            this.btnAddMF.Text = "Add Membership";
            this.btnAddMF.UseVisualStyleBackColor = true;
            // 
            // groupBoxCurrentMF
            // 
            this.groupBoxCurrentMF.Controls.Add(this.textBoxParams);
            this.groupBoxCurrentMF.Controls.Add(this.lblParam);
            this.groupBoxCurrentMF.Controls.Add(this.comboBoxTypeMF);
            this.groupBoxCurrentMF.Controls.Add(this.lblTypeMF);
            this.groupBoxCurrentMF.Controls.Add(this.textBoxNameMF);
            this.groupBoxCurrentMF.Controls.Add(this.lblNameMF);
            this.groupBoxCurrentMF.Location = new System.Drawing.Point(159, 289);
            this.groupBoxCurrentMF.Name = "groupBoxCurrentMF";
            this.groupBoxCurrentMF.Size = new System.Drawing.Size(311, 156);
            this.groupBoxCurrentMF.TabIndex = 21;
            this.groupBoxCurrentMF.TabStop = false;
            this.groupBoxCurrentMF.Text = "Current Membership Function";
            // 
            // textBoxParams
            // 
            this.textBoxParams.Location = new System.Drawing.Point(94, 95);
            this.textBoxParams.Name = "textBoxParams";
            this.textBoxParams.Size = new System.Drawing.Size(125, 20);
            this.textBoxParams.TabIndex = 5;
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(14, 98);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(66, 13);
            this.lblParam.TabIndex = 4;
            this.lblParam.Text = "Parameters :";
            // 
            // comboBoxTypeMF
            // 
            this.comboBoxTypeMF.FormattingEnabled = true;
            this.comboBoxTypeMF.Items.AddRange(new object[] {
            "Triangel Membership Function",
            "Trapezoidal Membership Function",
            "S-Membership Function"});
            this.comboBoxTypeMF.Location = new System.Drawing.Point(94, 59);
            this.comboBoxTypeMF.Name = "comboBoxTypeMF";
            this.comboBoxTypeMF.Size = new System.Drawing.Size(125, 21);
            this.comboBoxTypeMF.TabIndex = 3;
            // 
            // lblTypeMF
            // 
            this.lblTypeMF.AutoSize = true;
            this.lblTypeMF.Location = new System.Drawing.Point(14, 62);
            this.lblTypeMF.Name = "lblTypeMF";
            this.lblTypeMF.Size = new System.Drawing.Size(37, 13);
            this.lblTypeMF.TabIndex = 2;
            this.lblTypeMF.Text = "Type :";
            // 
            // textBoxNameMF
            // 
            this.textBoxNameMF.Location = new System.Drawing.Point(94, 24);
            this.textBoxNameMF.Name = "textBoxNameMF";
            this.textBoxNameMF.Size = new System.Drawing.Size(198, 20);
            this.textBoxNameMF.TabIndex = 1;
            // 
            // lblNameMF
            // 
            this.lblNameMF.AutoSize = true;
            this.lblNameMF.Location = new System.Drawing.Point(14, 27);
            this.lblNameMF.Name = "lblNameMF";
            this.lblNameMF.Size = new System.Drawing.Size(41, 13);
            this.lblNameMF.TabIndex = 0;
            this.lblNameMF.Text = "Name :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 311);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(130, 134);
            this.listBox1.TabIndex = 20;
            // 
            // lblListMF
            // 
            this.lblListMF.AutoSize = true;
            this.lblListMF.Location = new System.Drawing.Point(20, 289);
            this.lblListMF.Name = "lblListMF";
            this.lblListMF.Size = new System.Drawing.Size(133, 13);
            this.lblListMF.TabIndex = 19;
            this.lblListMF.Text = "List Membership Function :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(6, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 237);
            this.panel1.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(502, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(452, 6);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 14;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(251, 6);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(39, 13);
            this.lblRange.TabIndex = 13;
            this.lblRange.Text = "Range";
            // 
            // textBoxVarName
            // 
            this.textBoxVarName.Location = new System.Drawing.Point(76, 3);
            this.textBoxVarName.Name = "textBoxVarName";
            this.textBoxVarName.Size = new System.Drawing.Size(138, 20);
            this.textBoxVarName.TabIndex = 12;
            // 
            // lblvarName
            // 
            this.lblvarName.AutoSize = true;
            this.lblvarName.Location = new System.Drawing.Point(0, 6);
            this.lblvarName.Name = "lblvarName";
            this.lblvarName.Size = new System.Drawing.Size(70, 13);
            this.lblvarName.TabIndex = 11;
            this.lblvarName.Text = "Variale Name";
            // 
            // btnRemoveMF
            // 
            this.btnRemoveMF.Location = new System.Drawing.Point(476, 422);
            this.btnRemoveMF.Name = "btnRemoveMF";
            this.btnRemoveMF.Size = new System.Drawing.Size(121, 23);
            this.btnRemoveMF.TabIndex = 23;
            this.btnRemoveMF.Text = "Remove Membership";
            this.btnRemoveMF.UseVisualStyleBackColor = true;
            // 
            // Variable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveMF);
            this.Controls.Add(this.btnSaveMF);
            this.Controls.Add(this.btnAddMF);
            this.Controls.Add(this.groupBoxCurrentMF);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblListMF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.textBoxVarName);
            this.Controls.Add(this.lblvarName);
            this.Name = "Variable";
            this.Size = new System.Drawing.Size(659, 455);
            this.groupBoxCurrentMF.ResumeLayout(false);
            this.groupBoxCurrentMF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveMF;
        private System.Windows.Forms.Button btnAddMF;
        private System.Windows.Forms.GroupBox groupBoxCurrentMF;
        private System.Windows.Forms.TextBox textBoxParams;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.ComboBox comboBoxTypeMF;
        private System.Windows.Forms.Label lblTypeMF;
        private System.Windows.Forms.TextBox textBoxNameMF;
        private System.Windows.Forms.Label lblNameMF;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblListMF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.TextBox textBoxVarName;
        private System.Windows.Forms.Label lblvarName;
        private System.Windows.Forms.Button btnRemoveMF;


    }
}
