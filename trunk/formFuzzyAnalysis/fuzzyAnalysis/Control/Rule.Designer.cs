namespace fuzzyAnalysis.Control
{
    partial class Rule
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RulePan = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutRulePan = new System.Windows.Forms.FlowLayoutPanel();
            this.InRulePan = new System.Windows.Forms.FlowLayoutPanel();
            this.ClearRuleBtn = new System.Windows.Forms.Button();
            this.addRuleBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.VarTree = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // RulePan
            // 
            this.RulePan.AutoScroll = true;
            this.RulePan.ColumnCount = 1;
            this.RulePan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RulePan.Location = new System.Drawing.Point(0, 0);
            this.RulePan.Name = "RulePan";
            this.RulePan.RowCount = 1;
            this.RulePan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RulePan.Size = new System.Drawing.Size(200, 100);
            this.RulePan.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 218);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Rules";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 193);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.OutRulePan);
            this.groupBox2.Controls.Add(this.InRulePan);
            this.groupBox2.Controls.Add(this.ClearRuleBtn);
            this.groupBox2.Controls.Add(this.addRuleBtn);
            this.groupBox2.Location = new System.Drawing.Point(176, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 238);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Rule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Then";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IF";
            // 
            // OutRulePan
            // 
            this.OutRulePan.AutoScroll = true;
            this.OutRulePan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutRulePan.Location = new System.Drawing.Point(7, 124);
            this.OutRulePan.Name = "OutRulePan";
            this.OutRulePan.Size = new System.Drawing.Size(668, 76);
            this.OutRulePan.TabIndex = 3;
            // 
            // InRulePan
            // 
            this.InRulePan.AutoScroll = true;
            this.InRulePan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InRulePan.Location = new System.Drawing.Point(7, 36);
            this.InRulePan.Name = "InRulePan";
            this.InRulePan.Size = new System.Drawing.Size(668, 72);
            this.InRulePan.TabIndex = 2;
            // 
            // ClearRuleBtn
            // 
            this.ClearRuleBtn.Location = new System.Drawing.Point(619, 206);
            this.ClearRuleBtn.Name = "ClearRuleBtn";
            this.ClearRuleBtn.Size = new System.Drawing.Size(56, 23);
            this.ClearRuleBtn.TabIndex = 1;
            this.ClearRuleBtn.Text = "Clear";
            this.ClearRuleBtn.UseVisualStyleBackColor = true;
            // 
            // addRuleBtn
            // 
            this.addRuleBtn.Location = new System.Drawing.Point(538, 206);
            this.addRuleBtn.Name = "addRuleBtn";
            this.addRuleBtn.Size = new System.Drawing.Size(75, 23);
            this.addRuleBtn.TabIndex = 0;
            this.addRuleBtn.Text = "Add Rule";
            this.addRuleBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.VarTree);
            this.groupBox4.Location = new System.Drawing.Point(9, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 238);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Variables";
            // 
            // VarTree
            // 
            this.VarTree.HotTracking = true;
            this.VarTree.Location = new System.Drawing.Point(6, 20);
            this.VarTree.Name = "VarTree";
            this.VarTree.Size = new System.Drawing.Size(140, 209);
            this.VarTree.TabIndex = 0;
            // 
            // Rule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Rule";
            this.Size = new System.Drawing.Size(868, 481);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel RulePan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel OutRulePan;
        private System.Windows.Forms.FlowLayoutPanel InRulePan;
        private System.Windows.Forms.Button ClearRuleBtn;
        private System.Windows.Forms.Button addRuleBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TreeView VarTree;
    }
}
