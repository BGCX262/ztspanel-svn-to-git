namespace WindowsFormsApplication1
{
    partial class tabDataView
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelectView = new System.Windows.Forms.ComboBox();
            this.variableViewCollection = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Variabel View :";
            // 
            // cmbSelectView
            // 
            this.cmbSelectView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectView.FormattingEnabled = true;
            this.cmbSelectView.Items.AddRange(new object[] {
            "Spreadsheet",
            "Graphics",
            "Statistics"});
            this.cmbSelectView.Location = new System.Drawing.Point(90, 13);
            this.cmbSelectView.Name = "cmbSelectView";
            this.cmbSelectView.Size = new System.Drawing.Size(171, 21);
            this.cmbSelectView.TabIndex = 7;
            // 
            // variableViewCollection
            // 
            this.variableViewCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableViewCollection.Location = new System.Drawing.Point(3, 50);
            this.variableViewCollection.Name = "variableViewCollection";
            this.variableViewCollection.SelectedIndex = 0;
            this.variableViewCollection.Size = new System.Drawing.Size(776, 456);
            this.variableViewCollection.TabIndex = 11;
            // 
            // tabDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.variableViewCollection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelectView);
            this.Name = "tabDataView";
            this.Padding = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.Size = new System.Drawing.Size(782, 509);
            this.Load += new System.EventHandler(this.tabDataView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelectView;
        public System.Windows.Forms.TabControl variableViewCollection;


    }
}
