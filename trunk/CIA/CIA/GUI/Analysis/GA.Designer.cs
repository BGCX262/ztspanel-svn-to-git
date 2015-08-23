namespace WindowsFormsApplication1.GA
{
    partial class GA
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
            this.maeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.validationSetLabel = new System.Windows.Forms.Label();
            this.validationSetLine = new System.Windows.Forms.Label();
            this.observationLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxChromosome = new System.Windows.Forms.TextBox();
            this.grupBoxParamGA = new System.Windows.Forms.GroupBox();
            this.txtBoxGenerasi = new System.Windows.Forms.TextBox();
            this.txtBoxMutasi = new System.Windows.Forms.TextBox();
            this.txtBoxCross = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iterationBox = new System.Windows.Forms.TextBox();
            this.rdBtn1Point = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.grupBoxJenisGA = new System.Windows.Forms.GroupBox();
            this.rdButtonParalel = new System.Windows.Forms.RadioButton();
            this.rdButtonSimple = new System.Windows.Forms.RadioButton();
            this.viewResultButton = new System.Windows.Forms.Button();
            this.rdBtnNPoint = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.rdBtnUniform = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxGmdh = new System.Windows.Forms.GroupBox();
            this.grupBoxCroosover = new System.Windows.Forms.GroupBox();
            this.mseBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.grupBoxParamGA.SuspendLayout();
            this.grupBoxJenisGA.SuspendLayout();
            this.groupBoxGmdh.SuspendLayout();
            this.grupBoxCroosover.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // maeBox
            // 
            this.maeBox.Location = new System.Drawing.Point(279, 13);
            this.maeBox.Name = "maeBox";
            this.maeBox.ReadOnly = true;
            this.maeBox.Size = new System.Drawing.Size(64, 20);
            this.maeBox.TabIndex = 6;
            this.maeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Error:";
            // 
            // errorBox
            // 
            this.errorBox.Location = new System.Drawing.Point(167, 13);
            this.errorBox.Name = "errorBox";
            this.errorBox.ReadOnly = true;
            this.errorBox.Size = new System.Drawing.Size(64, 20);
            this.errorBox.TabIndex = 4;
            this.errorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.validationSetLabel);
            this.groupBox3.Controls.Add(this.validationSetLine);
            this.groupBox3.Controls.Add(this.observationLabel);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(811, 315);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graph";
            // 
            // validationSetLabel
            // 
            this.validationSetLabel.AutoSize = true;
            this.validationSetLabel.Location = new System.Drawing.Point(371, 296);
            this.validationSetLabel.Name = "validationSetLabel";
            this.validationSetLabel.Size = new System.Drawing.Size(120, 13);
            this.validationSetLabel.TabIndex = 25;
            this.validationSetLabel.Text = "Predicted Validation Set";
            // 
            // validationSetLine
            // 
            this.validationSetLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.validationSetLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.validationSetLine.Location = new System.Drawing.Point(315, 300);
            this.validationSetLine.Name = "validationSetLine";
            this.validationSetLine.Size = new System.Drawing.Size(50, 2);
            this.validationSetLine.TabIndex = 24;
            // 
            // observationLabel
            // 
            this.observationLabel.Location = new System.Drawing.Point(559, 293);
            this.observationLabel.Name = "observationLabel";
            this.observationLabel.Size = new System.Drawing.Size(197, 16);
            this.observationLabel.TabIndex = 23;
            this.observationLabel.Text = "Observations: 100";
            this.observationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(210, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Predicted";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Red;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(154, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 2);
            this.label16.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Actual";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Blue;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(12, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 2);
            this.label13.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Iteration:";
            // 
            // txtBoxChromosome
            // 
            this.txtBoxChromosome.Location = new System.Drawing.Point(383, 24);
            this.txtBoxChromosome.Name = "txtBoxChromosome";
            this.txtBoxChromosome.Size = new System.Drawing.Size(67, 20);
            this.txtBoxChromosome.TabIndex = 6;
            // 
            // grupBoxParamGA
            // 
            this.grupBoxParamGA.Controls.Add(this.txtBoxGenerasi);
            this.grupBoxParamGA.Controls.Add(this.txtBoxChromosome);
            this.grupBoxParamGA.Controls.Add(this.txtBoxMutasi);
            this.grupBoxParamGA.Controls.Add(this.txtBoxCross);
            this.grupBoxParamGA.Controls.Add(this.label4);
            this.grupBoxParamGA.Controls.Add(this.label3);
            this.grupBoxParamGA.Controls.Add(this.label2);
            this.grupBoxParamGA.Controls.Add(this.label5);
            this.grupBoxParamGA.Location = new System.Drawing.Point(150, 19);
            this.grupBoxParamGA.Name = "grupBoxParamGA";
            this.grupBoxParamGA.Size = new System.Drawing.Size(472, 79);
            this.grupBoxParamGA.TabIndex = 28;
            this.grupBoxParamGA.TabStop = false;
            this.grupBoxParamGA.Text = "Parameter GA";
            // 
            // txtBoxGenerasi
            // 
            this.txtBoxGenerasi.Location = new System.Drawing.Point(383, 50);
            this.txtBoxGenerasi.Name = "txtBoxGenerasi";
            this.txtBoxGenerasi.Size = new System.Drawing.Size(67, 20);
            this.txtBoxGenerasi.TabIndex = 7;
            // 
            // txtBoxMutasi
            // 
            this.txtBoxMutasi.Location = new System.Drawing.Point(157, 53);
            this.txtBoxMutasi.Name = "txtBoxMutasi";
            this.txtBoxMutasi.Size = new System.Drawing.Size(67, 20);
            this.txtBoxMutasi.TabIndex = 5;
            // 
            // txtBoxCross
            // 
            this.txtBoxCross.Location = new System.Drawing.Point(157, 24);
            this.txtBoxCross.Name = "txtBoxCross";
            this.txtBoxCross.Size = new System.Drawing.Size(67, 20);
            this.txtBoxCross.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Generasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah Chromosome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Persentase Mutasi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Persentase Crossover";
            // 
            // iterationBox
            // 
            this.iterationBox.Location = new System.Drawing.Point(60, 13);
            this.iterationBox.Name = "iterationBox";
            this.iterationBox.ReadOnly = true;
            this.iterationBox.Size = new System.Drawing.Size(64, 20);
            this.iterationBox.TabIndex = 2;
            this.iterationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rdBtn1Point
            // 
            this.rdBtn1Point.AutoSize = true;
            this.rdBtn1Point.Checked = true;
            this.rdBtn1Point.Location = new System.Drawing.Point(18, 19);
            this.rdBtn1Point.Name = "rdBtn1Point";
            this.rdBtn1Point.Size = new System.Drawing.Size(57, 17);
            this.rdBtn1Point.TabIndex = 0;
            this.rdBtn1Point.TabStop = true;
            this.rdBtn1Point.Text = "1 point";
            this.rdBtn1Point.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "MSE:";
            // 
            // grupBoxJenisGA
            // 
            this.grupBoxJenisGA.Controls.Add(this.rdButtonParalel);
            this.grupBoxJenisGA.Controls.Add(this.rdButtonSimple);
            this.grupBoxJenisGA.Location = new System.Drawing.Point(25, 19);
            this.grupBoxJenisGA.Name = "grupBoxJenisGA";
            this.grupBoxJenisGA.Size = new System.Drawing.Size(109, 79);
            this.grupBoxJenisGA.TabIndex = 27;
            this.grupBoxJenisGA.TabStop = false;
            this.grupBoxJenisGA.Text = "Jenis GA";
            // 
            // rdButtonParalel
            // 
            this.rdButtonParalel.AutoSize = true;
            this.rdButtonParalel.Location = new System.Drawing.Point(19, 50);
            this.rdButtonParalel.Name = "rdButtonParalel";
            this.rdButtonParalel.Size = new System.Drawing.Size(75, 17);
            this.rdButtonParalel.TabIndex = 1;
            this.rdButtonParalel.Text = "Paralel GA";
            this.rdButtonParalel.UseVisualStyleBackColor = true;
            // 
            // rdButtonSimple
            // 
            this.rdButtonSimple.AutoSize = true;
            this.rdButtonSimple.Checked = true;
            this.rdButtonSimple.Location = new System.Drawing.Point(20, 24);
            this.rdButtonSimple.Name = "rdButtonSimple";
            this.rdButtonSimple.Size = new System.Drawing.Size(74, 17);
            this.rdButtonSimple.TabIndex = 0;
            this.rdButtonSimple.TabStop = true;
            this.rdButtonSimple.Text = "Simple GA";
            this.rdButtonSimple.UseVisualStyleBackColor = true;
            // 
            // viewResultButton
            // 
            this.viewResultButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.viewResultButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewResultButton.Location = new System.Drawing.Point(658, 512);
            this.viewResultButton.Name = "viewResultButton";
            this.viewResultButton.Size = new System.Drawing.Size(84, 34);
            this.viewResultButton.TabIndex = 31;
            this.viewResultButton.Text = "View Result";
            this.viewResultButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewResultButton.UseVisualStyleBackColor = true;
            // 
            // rdBtnNPoint
            // 
            this.rdBtnNPoint.AutoSize = true;
            this.rdBtnNPoint.Location = new System.Drawing.Point(18, 36);
            this.rdBtnNPoint.Name = "rdBtnNPoint";
            this.rdBtnNPoint.Size = new System.Drawing.Size(57, 17);
            this.rdBtnNPoint.TabIndex = 2;
            this.rdBtnNPoint.Text = "n point";
            this.rdBtnNPoint.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "MAE:";
            // 
            // rdBtnUniform
            // 
            this.rdBtnUniform.AutoSize = true;
            this.rdBtnUniform.Location = new System.Drawing.Point(18, 53);
            this.rdBtnUniform.Name = "rdBtnUniform";
            this.rdBtnUniform.Size = new System.Drawing.Size(61, 17);
            this.rdBtnUniform.TabIndex = 3;
            this.rdBtnUniform.Text = "Uniform";
            this.rdBtnUniform.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startButton.Location = new System.Drawing.Point(490, 512);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(78, 34);
            this.startButton.TabIndex = 29;
            this.startButton.Text = "Start";
            this.startButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(748, 512);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 34);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Genetic Algorithm Analysis";
            // 
            // groupBoxGmdh
            // 
            this.groupBoxGmdh.Controls.Add(this.grupBoxCroosover);
            this.groupBoxGmdh.Controls.Add(this.grupBoxParamGA);
            this.groupBoxGmdh.Controls.Add(this.grupBoxJenisGA);
            this.groupBoxGmdh.Location = new System.Drawing.Point(12, 44);
            this.groupBoxGmdh.Name = "groupBoxGmdh";
            this.groupBoxGmdh.Size = new System.Drawing.Size(811, 112);
            this.groupBoxGmdh.TabIndex = 26;
            this.groupBoxGmdh.TabStop = false;
            this.groupBoxGmdh.Text = "Genetic Algorithm Structure";
            // 
            // grupBoxCroosover
            // 
            this.grupBoxCroosover.Controls.Add(this.rdBtnUniform);
            this.grupBoxCroosover.Controls.Add(this.rdBtnNPoint);
            this.grupBoxCroosover.Controls.Add(this.rdBtn1Point);
            this.grupBoxCroosover.Location = new System.Drawing.Point(628, 19);
            this.grupBoxCroosover.Name = "grupBoxCroosover";
            this.grupBoxCroosover.Size = new System.Drawing.Size(164, 79);
            this.grupBoxCroosover.TabIndex = 29;
            this.grupBoxCroosover.TabStop = false;
            this.grupBoxCroosover.Text = "Jenis Crossover";
            // 
            // mseBox
            // 
            this.mseBox.Location = new System.Drawing.Point(390, 13);
            this.mseBox.Name = "mseBox";
            this.mseBox.ReadOnly = true;
            this.mseBox.Size = new System.Drawing.Size(64, 20);
            this.mseBox.TabIndex = 0;
            this.mseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(574, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 34);
            this.button1.TabIndex = 32;
            this.button1.Text = "Stop";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.maeBox);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.errorBox);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.iterationBox);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.mseBox);
            this.groupBox7.Location = new System.Drawing.Point(12, 507);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(472, 39);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Criterion";
            // 
            // GA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.viewResultButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxGmdh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox7);
            this.Name = "GA";
            this.Text = "GA";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grupBoxParamGA.ResumeLayout(false);
            this.grupBoxParamGA.PerformLayout();
            this.grupBoxJenisGA.ResumeLayout(false);
            this.grupBoxJenisGA.PerformLayout();
            this.groupBoxGmdh.ResumeLayout(false);
            this.grupBoxCroosover.ResumeLayout(false);
            this.grupBoxCroosover.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox errorBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label validationSetLabel;
        private System.Windows.Forms.Label validationSetLine;
        private System.Windows.Forms.Label observationLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxChromosome;
        private System.Windows.Forms.GroupBox grupBoxParamGA;
        private System.Windows.Forms.TextBox txtBoxGenerasi;
        private System.Windows.Forms.TextBox txtBoxMutasi;
        private System.Windows.Forms.TextBox txtBoxCross;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iterationBox;
        private System.Windows.Forms.RadioButton rdBtn1Point;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grupBoxJenisGA;
        private System.Windows.Forms.RadioButton rdButtonParalel;
        private System.Windows.Forms.RadioButton rdButtonSimple;
        private System.Windows.Forms.Button viewResultButton;
        private System.Windows.Forms.RadioButton rdBtnNPoint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdBtnUniform;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxGmdh;
        private System.Windows.Forms.GroupBox grupBoxCroosover;
        private System.Windows.Forms.TextBox mseBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}