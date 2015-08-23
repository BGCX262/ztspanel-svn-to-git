namespace WindowsFormsApplication1
{
    partial class MDIForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuzzy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGmdh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAnfis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newIcon = new System.Windows.Forms.ToolStripButton();
            this.openIcon = new System.Windows.Forms.ToolStripButton();
            this.saveIcon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.cutIcon = new System.Windows.Forms.ToolStripButton();
            this.copyIcon = new System.Windows.Forms.ToolStripButton();
            this.pasteIcon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.helpIcon = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuAnalysis,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(526, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewFile,
            this.menuOpen,
            this.toolStripSeparator10,
            this.menuSave,
            this.menuSaveAs,
            this.toolStripSeparator12,
            this.menuExit});
            this.menuFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(35, 20);
            this.menuFile.Text = "File";
            // 
            // menuNewFile
            // 
            this.menuNewFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuNewFile.Name = "menuNewFile";
            this.menuNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNewFile.Size = new System.Drawing.Size(164, 22);
            this.menuNewFile.Text = "&New File";
            this.menuNewFile.Click += new System.EventHandler(this.menuNewFile_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(164, 22);
            this.menuOpen.Text = "&Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(161, 6);
            // 
            // menuSave
            // 
            this.menuSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(164, 22);
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(164, 22);
            this.menuSaveAs.Text = "Save &As";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(161, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(164, 22);
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCut,
            this.menuCopy,
            this.menuPaste,
            this.menuDel,
            this.toolStripSeparator14,
            this.menuSelAll});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(37, 20);
            this.menuEdit.Text = "&Edit";
            // 
            // menuCut
            // 
            this.menuCut.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuCut.Name = "menuCut";
            this.menuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuCut.Size = new System.Drawing.Size(167, 22);
            this.menuCut.Text = "Cu&t";
            // 
            // menuCopy
            // 
            this.menuCopy.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCopy.Size = new System.Drawing.Size(167, 22);
            this.menuCopy.Text = "&Copy";
            // 
            // menuPaste
            // 
            this.menuPaste.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuPaste.Size = new System.Drawing.Size(167, 22);
            this.menuPaste.Text = "&Paste";
            // 
            // menuDel
            // 
            this.menuDel.Name = "menuDel";
            this.menuDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuDel.Size = new System.Drawing.Size(167, 22);
            this.menuDel.Text = "Delete";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(164, 6);
            // 
            // menuSelAll
            // 
            this.menuSelAll.Name = "menuSelAll";
            this.menuSelAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuSelAll.Size = new System.Drawing.Size(167, 22);
            this.menuSelAll.Text = "Select &All";
            // 
            // menuAnalysis
            // 
            this.menuAnalysis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFuzzy,
            this.menuGA,
            this.menuGmdh,
            this.toolStripMenuItem2,
            this.menuAnfis});
            this.menuAnalysis.Name = "menuAnalysis";
            this.menuAnalysis.Size = new System.Drawing.Size(58, 20);
            this.menuAnalysis.Text = "&Analysis";
            // 
            // menuFuzzy
            // 
            this.menuFuzzy.Name = "menuFuzzy";
            this.menuFuzzy.Size = new System.Drawing.Size(169, 22);
            this.menuFuzzy.Text = "Fuzzy";
            // 
            // menuGA
            // 
            this.menuGA.Name = "menuGA";
            this.menuGA.Size = new System.Drawing.Size(169, 22);
            this.menuGA.Text = "Genetic Algorithm";
            // 
            // menuGmdh
            // 
            this.menuGmdh.Name = "menuGmdh";
            this.menuGmdh.Size = new System.Drawing.Size(169, 22);
            this.menuGmdh.Text = "GMDH";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(166, 6);
            // 
            // menuAnfis
            // 
            this.menuAnfis.Name = "menuAnfis";
            this.menuAnfis.Size = new System.Drawing.Size(169, 22);
            this.menuAnfis.Text = "ANFIS";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuContent,
            this.menuIndex,
            this.menuSearch,
            this.toolStripSeparator15,
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(40, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuContent
            // 
            this.menuContent.Name = "menuContent";
            this.menuContent.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.menuContent.Size = new System.Drawing.Size(173, 22);
            this.menuContent.Text = "&Contents";
            // 
            // menuIndex
            // 
            this.menuIndex.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuIndex.Name = "menuIndex";
            this.menuIndex.Size = new System.Drawing.Size(173, 22);
            this.menuIndex.Text = "&Index";
            // 
            // menuSearch
            // 
            this.menuSearch.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.Size = new System.Drawing.Size(173, 22);
            this.menuSearch.Text = "&Search";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(170, 6);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(173, 22);
            this.menuAbout.Text = "&About ...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newIcon,
            this.openIcon,
            this.saveIcon,
            this.toolStripSeparator16,
            this.cutIcon,
            this.copyIcon,
            this.pasteIcon,
            this.toolStripSeparator17,
            this.helpIcon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(526, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newIcon
            // 
            this.newIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newIcon.Image = ((System.Drawing.Image)(resources.GetObject("newIcon.Image")));
            this.newIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newIcon.Name = "newIcon";
            this.newIcon.Size = new System.Drawing.Size(23, 22);
            this.newIcon.Text = "&New";
            this.newIcon.ToolTipText = "New File";
            this.newIcon.Click += new System.EventHandler(this.newToolStripButton1_Click);
            // 
            // openIcon
            // 
            this.openIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openIcon.Image = ((System.Drawing.Image)(resources.GetObject("openIcon.Image")));
            this.openIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openIcon.Name = "openIcon";
            this.openIcon.Size = new System.Drawing.Size(23, 22);
            this.openIcon.Text = "&Open";
            this.openIcon.ToolTipText = "Open Learned NN";
            this.openIcon.Click += new System.EventHandler(this.openIcon_Click);
            // 
            // saveIcon
            // 
            this.saveIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveIcon.Image = ((System.Drawing.Image)(resources.GetObject("saveIcon.Image")));
            this.saveIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveIcon.Name = "saveIcon";
            this.saveIcon.Size = new System.Drawing.Size(23, 22);
            this.saveIcon.Text = "&Save";
            this.saveIcon.ToolTipText = "Save Learned NN";
            this.saveIcon.Click += new System.EventHandler(this.saveIcon_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // cutIcon
            // 
            this.cutIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutIcon.Image = ((System.Drawing.Image)(resources.GetObject("cutIcon.Image")));
            this.cutIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutIcon.Name = "cutIcon";
            this.cutIcon.Size = new System.Drawing.Size(23, 22);
            this.cutIcon.Text = "C&ut";
            // 
            // copyIcon
            // 
            this.copyIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyIcon.Image = ((System.Drawing.Image)(resources.GetObject("copyIcon.Image")));
            this.copyIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyIcon.Name = "copyIcon";
            this.copyIcon.Size = new System.Drawing.Size(23, 22);
            this.copyIcon.Text = "&Copy";
            // 
            // pasteIcon
            // 
            this.pasteIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteIcon.Image = ((System.Drawing.Image)(resources.GetObject("pasteIcon.Image")));
            this.pasteIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteIcon.Name = "pasteIcon";
            this.pasteIcon.Size = new System.Drawing.Size(23, 22);
            this.pasteIcon.Text = "&Paste";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // helpIcon
            // 
            this.helpIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpIcon.Image = ((System.Drawing.Image)(resources.GetObject("helpIcon.Image")));
            this.helpIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpIcon.Name = "helpIcon";
            this.helpIcon.Size = new System.Drawing.Size(23, 22);
            this.helpIcon.Text = "He&lp";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 361);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(526, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "Name: ";
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 383);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIForm";
            this.Text = "Forecasting Analysis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNewFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ToolStripMenuItem menuDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem menuSelAll;
        private System.Windows.Forms.ToolStripMenuItem menuAnalysis;
        private System.Windows.Forms.ToolStripMenuItem menuFuzzy;
        private System.Windows.Forms.ToolStripMenuItem menuGA;
        private System.Windows.Forms.ToolStripMenuItem menuGmdh;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuContent;
        private System.Windows.Forms.ToolStripMenuItem menuIndex;
        private System.Windows.Forms.ToolStripMenuItem menuSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newIcon;
        private System.Windows.Forms.ToolStripButton openIcon;
        private System.Windows.Forms.ToolStripButton saveIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripButton cutIcon;
        private System.Windows.Forms.ToolStripButton copyIcon;
        private System.Windows.Forms.ToolStripButton pasteIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripButton helpIcon;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuAnfis;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

