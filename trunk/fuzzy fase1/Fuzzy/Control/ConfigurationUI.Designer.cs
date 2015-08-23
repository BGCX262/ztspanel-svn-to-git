namespace Fuzzy.Control
{
    partial class ConfigurationUI
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
            this.fisMethodCmbo = new System.Windows.Forms.ComboBox();
            this.MamdaniGroupBox = new System.Windows.Forms.GroupBox();
            this.DefuzCombo = new System.Windows.Forms.ComboBox();
            this.ImplCombo = new System.Windows.Forms.ComboBox();
            this.AndCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SugenoGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFISMethod = new System.Windows.Forms.Label();
            this.MamdaniGroupBox.SuspendLayout();
            this.SugenoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fisMethodCmbo
            // 
            this.fisMethodCmbo.FormattingEnabled = true;
            this.fisMethodCmbo.Items.AddRange(new object[] {
            "Tagaki Sugeno",
            "Mamdani"});
            this.fisMethodCmbo.Location = new System.Drawing.Point(157, 14);
            this.fisMethodCmbo.Name = "fisMethodCmbo";
            this.fisMethodCmbo.Size = new System.Drawing.Size(168, 21);
            this.fisMethodCmbo.TabIndex = 28;
            // 
            // MamdaniGroupBox
            // 
            this.MamdaniGroupBox.Controls.Add(this.DefuzCombo);
            this.MamdaniGroupBox.Controls.Add(this.ImplCombo);
            this.MamdaniGroupBox.Controls.Add(this.AndCombo);
            this.MamdaniGroupBox.Controls.Add(this.label4);
            this.MamdaniGroupBox.Controls.Add(this.label3);
            this.MamdaniGroupBox.Controls.Add(this.label2);
            this.MamdaniGroupBox.Location = new System.Drawing.Point(8, 46);
            this.MamdaniGroupBox.Name = "MamdaniGroupBox";
            this.MamdaniGroupBox.Size = new System.Drawing.Size(346, 141);
            this.MamdaniGroupBox.TabIndex = 29;
            this.MamdaniGroupBox.TabStop = false;
            this.MamdaniGroupBox.Text = "Parameters";
            // 
            // DefuzCombo
            // 
            this.DefuzCombo.FormattingEnabled = true;
            this.DefuzCombo.Items.AddRange(new object[] {
            "Modified Heigh Defuzzification",
            "Centroid"});
            this.DefuzCombo.Location = new System.Drawing.Point(146, 92);
            this.DefuzCombo.Name = "DefuzCombo";
            this.DefuzCombo.Size = new System.Drawing.Size(169, 21);
            this.DefuzCombo.TabIndex = 11;
            // 
            // ImplCombo
            // 
            this.ImplCombo.FormattingEnabled = true;
            this.ImplCombo.Items.AddRange(new object[] {
            "Min",
            "Prod"});
            this.ImplCombo.Location = new System.Drawing.Point(146, 55);
            this.ImplCombo.Name = "ImplCombo";
            this.ImplCombo.Size = new System.Drawing.Size(80, 21);
            this.ImplCombo.TabIndex = 10;
            // 
            // AndCombo
            // 
            this.AndCombo.FormattingEnabled = true;
            this.AndCombo.Items.AddRange(new object[] {
            "Min",
            "Prod"});
            this.AndCombo.Location = new System.Drawing.Point(146, 16);
            this.AndCombo.Name = "AndCombo";
            this.AndCombo.Size = new System.Drawing.Size(80, 21);
            this.AndCombo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Defuzzification Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Implication Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "And Method";
            // 
            // SugenoGroupBox
            // 
            this.SugenoGroupBox.Controls.Add(this.comboBox2);
            this.SugenoGroupBox.Controls.Add(this.comboBox1);
            this.SugenoGroupBox.Controls.Add(this.comboBox3);
            this.SugenoGroupBox.Controls.Add(this.label1);
            this.SugenoGroupBox.Controls.Add(this.label5);
            this.SugenoGroupBox.Controls.Add(this.label6);
            this.SugenoGroupBox.Location = new System.Drawing.Point(8, 46);
            this.SugenoGroupBox.Name = "SugenoGroupBox";
            this.SugenoGroupBox.Size = new System.Drawing.Size(346, 141);
            this.SugenoGroupBox.TabIndex = 27;
            this.SugenoGroupBox.TabStop = false;
            this.SugenoGroupBox.Text = "Parameters";
            this.SugenoGroupBox.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "WeightAverage"});
            this.comboBox1.Location = new System.Drawing.Point(147, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Min",
            "Prod"});
            this.comboBox2.Location = new System.Drawing.Point(146, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Min",
            "Prod"});
            this.comboBox3.Location = new System.Drawing.Point(147, 16);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(80, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Defuzzification Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Implication Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "And Method";
            // 
            // lblFISMethod
            // 
            this.lblFISMethod.AutoSize = true;
            this.lblFISMethod.Location = new System.Drawing.Point(21, 17);
            this.lblFISMethod.Name = "lblFISMethod";
            this.lblFISMethod.Size = new System.Drawing.Size(124, 13);
            this.lblFISMethod.TabIndex = 27;
            this.lblFISMethod.Text = "Fuzzy Inference Method ";
            // 
            // ConfigurationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fisMethodCmbo);
            this.Controls.Add(this.MamdaniGroupBox);
            this.Controls.Add(this.lblFISMethod);
            this.Controls.Add(this.SugenoGroupBox);
            this.Name = "ConfigurationUI";
            this.Size = new System.Drawing.Size(364, 205);
            this.Load += new System.EventHandler(this.ConfigurationUI_Load);
            this.MamdaniGroupBox.ResumeLayout(false);
            this.MamdaniGroupBox.PerformLayout();
            this.SugenoGroupBox.ResumeLayout(false);
            this.SugenoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fisMethodCmbo;
        private System.Windows.Forms.GroupBox MamdaniGroupBox;
        private System.Windows.Forms.ComboBox DefuzCombo;
        private System.Windows.Forms.ComboBox ImplCombo;
        private System.Windows.Forms.ComboBox AndCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SugenoGroupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFISMethod;
    }
}
