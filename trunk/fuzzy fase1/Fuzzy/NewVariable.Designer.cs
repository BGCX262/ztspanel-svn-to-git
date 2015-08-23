namespace Fuzzy
{
    partial class NewVariable
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
            this.button2 = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.RangeTxT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTxT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(167, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 24);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(94, 156);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(63, 24);
            this.OKBtn.TabIndex = 22;
            this.OKBtn.Text = "Ok";
            this.OKBtn.UseVisualStyleBackColor = true;
            // 
            // RangeTxT
            // 
            this.RangeTxT.Location = new System.Drawing.Point(95, 103);
            this.RangeTxT.Name = "RangeTxT";
            this.RangeTxT.Size = new System.Drawing.Size(100, 20);
            this.RangeTxT.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Range";
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Items.AddRange(new object[] {
            "Input",
            "Output"});
            this.TypeCombo.Location = new System.Drawing.Point(95, 56);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(121, 21);
            this.TypeCombo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Variable Type";
            // 
            // NameTxT
            // 
            this.NameTxT.Location = new System.Drawing.Point(94, 12);
            this.NameTxT.Name = "NameTxT";
            this.NameTxT.Size = new System.Drawing.Size(136, 20);
            this.NameTxT.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Variable Name";
            // 
            // NewVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 200);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.RangeTxT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TypeCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTxT);
            this.Controls.Add(this.label1);
            this.Name = "NewVariable";
            this.Text = "NewVariable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.TextBox RangeTxT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTxT;
        private System.Windows.Forms.Label label1;
    }
}