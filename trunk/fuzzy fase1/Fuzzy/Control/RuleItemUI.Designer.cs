namespace Fuzzy.Control
{
    partial class RuleItemUI
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
            this.MFCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VarText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MFCombo
            // 
            this.MFCombo.FormattingEnabled = true;
            this.MFCombo.Location = new System.Drawing.Point(108, 12);
            this.MFCombo.Name = "MFCombo";
            this.MFCombo.Size = new System.Drawing.Size(105, 21);
            this.MFCombo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Is";
            // 
            // VarText
            // 
            this.VarText.AutoSize = true;
            this.VarText.Location = new System.Drawing.Point(10, 15);
            this.VarText.Name = "VarText";
            this.VarText.Size = new System.Drawing.Size(35, 13);
            this.VarText.TabIndex = 6;
            this.VarText.Text = "label1";
            // 
            // RuleItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MFCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VarText);
            this.Name = "RuleItemUI";
            this.Size = new System.Drawing.Size(230, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MFCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VarText;
    }
}
