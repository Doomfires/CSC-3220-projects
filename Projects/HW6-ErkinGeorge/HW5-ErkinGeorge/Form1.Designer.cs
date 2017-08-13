namespace HW5_ErkinGeorge
{
    partial class bagelForm
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
            this.bagelMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAndLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAndAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBagelTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBagelTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.countBagelTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAndLoad = new System.Windows.Forms.OpenFileDialog();
            this.bagelListBox = new System.Windows.Forms.ListBox();
            this.BagelLabel = new System.Windows.Forms.Label();
            this.bagelTextBox = new System.Windows.Forms.TextBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.bagelToolStrip = new System.Windows.Forms.ToolStrip();
            this.openLoadStripButton = new System.Windows.Forms.ToolStripButton();
            this.openAddStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.addBagelButton = new System.Windows.Forms.ToolStripButton();
            this.removeBagelButton = new System.Windows.Forms.ToolStripButton();
            this.countBagelButton = new System.Windows.Forms.ToolStripButton();
            this.clearListButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutButton = new System.Windows.Forms.ToolStripButton();
            this.contextBagelMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.listFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bagelStatusStrip = new System.Windows.Forms.StatusStrip();
            this.recentFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.spacingThing = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentDataName = new System.Windows.Forms.ToolStripStatusLabel();
            this.bagelColorDialogue = new System.Windows.Forms.ColorDialog();
            this.bagelFontDialogue = new System.Windows.Forms.FontDialog();
            this.bagelMenuStrip.SuspendLayout();
            this.bagelToolStrip.SuspendLayout();
            this.contextBagelMenu.SuspendLayout();
            this.bagelStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bagelMenuStrip
            // 
            this.bagelMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.manageListToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.bagelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.bagelMenuStrip.Name = "bagelMenuStrip";
            this.bagelMenuStrip.Size = new System.Drawing.Size(722, 24);
            this.bagelMenuStrip.TabIndex = 0;
            this.bagelMenuStrip.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAndLoadToolStripMenuItem,
            this.openAndAddToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // openAndLoadToolStripMenuItem
            // 
            this.openAndLoadToolStripMenuItem.Name = "openAndLoadToolStripMenuItem";
            this.openAndLoadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openAndLoadToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openAndLoadToolStripMenuItem.Text = "Open and Load";
            this.openAndLoadToolStripMenuItem.Click += new System.EventHandler(this.openAndLoadToolStripMenuItem_Click);
            // 
            // openAndAddToolStripMenuItem
            // 
            this.openAndAddToolStripMenuItem.Name = "openAndAddToolStripMenuItem";
            this.openAndAddToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.openAndAddToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openAndAddToolStripMenuItem.Text = "Open and Add";
            this.openAndAddToolStripMenuItem.Click += new System.EventHandler(this.openAndAddToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageListToolStripMenuItem
            // 
            this.manageListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBagelTypeToolStripMenuItem,
            this.removeBagelTypeToolStripMenuItem,
            this.toolStripSeparator2,
            this.countBagelTypesToolStripMenuItem,
            this.toolStripSeparator3,
            this.clearListToolStripMenuItem});
            this.manageListToolStripMenuItem.Name = "manageListToolStripMenuItem";
            this.manageListToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.manageListToolStripMenuItem.Text = "Manage List";
            // 
            // addBagelTypeToolStripMenuItem
            // 
            this.addBagelTypeToolStripMenuItem.Name = "addBagelTypeToolStripMenuItem";
            this.addBagelTypeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addBagelTypeToolStripMenuItem.Text = "Add Bagel Type";
            this.addBagelTypeToolStripMenuItem.Click += new System.EventHandler(this.addBagelTypeToolStripMenuItem_Click);
            // 
            // removeBagelTypeToolStripMenuItem
            // 
            this.removeBagelTypeToolStripMenuItem.Name = "removeBagelTypeToolStripMenuItem";
            this.removeBagelTypeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.removeBagelTypeToolStripMenuItem.Text = "Remove Bagel Type";
            this.removeBagelTypeToolStripMenuItem.Click += new System.EventHandler(this.removeBagelTypeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // countBagelTypesToolStripMenuItem
            // 
            this.countBagelTypesToolStripMenuItem.Name = "countBagelTypesToolStripMenuItem";
            this.countBagelTypesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.countBagelTypesToolStripMenuItem.Text = "Count Bagel Types";
            this.countBagelTypesToolStripMenuItem.Click += new System.EventHandler(this.countBagelTypesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(174, 6);
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clearListToolStripMenuItem.Text = "Clear List";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openAndLoad
            // 
            this.openAndLoad.FileName = "openFileDialog1";
            // 
            // bagelListBox
            // 
            this.bagelListBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelListBox.FormattingEnabled = true;
            this.bagelListBox.ItemHeight = 21;
            this.bagelListBox.Location = new System.Drawing.Point(55, 75);
            this.bagelListBox.Name = "bagelListBox";
            this.bagelListBox.Size = new System.Drawing.Size(120, 214);
            this.bagelListBox.Sorted = true;
            this.bagelListBox.TabIndex = 1;
            // 
            // BagelLabel
            // 
            this.BagelLabel.AutoSize = true;
            this.BagelLabel.Location = new System.Drawing.Point(230, 322);
            this.BagelLabel.Name = "BagelLabel";
            this.BagelLabel.Size = new System.Drawing.Size(56, 13);
            this.BagelLabel.TabIndex = 2;
            this.BagelLabel.Text = "Add Bagel";
            // 
            // bagelTextBox
            // 
            this.bagelTextBox.Location = new System.Drawing.Point(311, 319);
            this.bagelTextBox.Name = "bagelTextBox";
            this.bagelTextBox.Size = new System.Drawing.Size(100, 20);
            this.bagelTextBox.TabIndex = 3;
            // 
            // bagelToolStrip
            // 
            this.bagelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLoadStripButton,
            this.openAddStripButton,
            this.saveFileButton,
            this.toolStripSeparator4,
            this.addBagelButton,
            this.removeBagelButton,
            this.countBagelButton,
            this.clearListButton,
            this.toolStripSeparator6,
            this.aboutButton});
            this.bagelToolStrip.Location = new System.Drawing.Point(0, 24);
            this.bagelToolStrip.Name = "bagelToolStrip";
            this.bagelToolStrip.Size = new System.Drawing.Size(722, 25);
            this.bagelToolStrip.TabIndex = 4;
            this.bagelToolStrip.Text = "bagelStrip";
            // 
            // openLoadStripButton
            // 
            this.openLoadStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openLoadStripButton.Image = global::HW6_ErkinGeorge.Properties.Resources.laptop;
            this.openLoadStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openLoadStripButton.Name = "openLoadStripButton";
            this.openLoadStripButton.Size = new System.Drawing.Size(23, 22);
            this.openLoadStripButton.Text = "toolStripButton1";
            this.openLoadStripButton.ToolTipText = "Open and Load";
            this.openLoadStripButton.Click += new System.EventHandler(this.openLoadStripButton_Click);
            // 
            // openAddStripButton
            // 
            this.openAddStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openAddStripButton.Image = global::HW6_ErkinGeorge.Properties.Resources.laptop__1_;
            this.openAddStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openAddStripButton.Name = "openAddStripButton";
            this.openAddStripButton.Size = new System.Drawing.Size(23, 22);
            this.openAddStripButton.Text = "toolStripButton2";
            this.openAddStripButton.ToolTipText = "Open and Add";
            this.openAddStripButton.Click += new System.EventHandler(this.openAddStripButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveFileButton.Image = global::HW6_ErkinGeorge.Properties.Resources.visualization_of_data;
            this.saveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(23, 22);
            this.saveFileButton.Text = "toolStripButton3";
            this.saveFileButton.ToolTipText = "Save File";
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // addBagelButton
            // 
            this.addBagelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addBagelButton.Image = global::HW6_ErkinGeorge.Properties.Resources.icon;
            this.addBagelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBagelButton.Name = "addBagelButton";
            this.addBagelButton.Size = new System.Drawing.Size(23, 22);
            this.addBagelButton.Text = "toolStripButton4";
            this.addBagelButton.ToolTipText = "Add Bagel";
            this.addBagelButton.Click += new System.EventHandler(this.addBagelButton_Click);
            // 
            // removeBagelButton
            // 
            this.removeBagelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeBagelButton.Image = global::HW6_ErkinGeorge.Properties.Resources.two_macarons;
            this.removeBagelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeBagelButton.Name = "removeBagelButton";
            this.removeBagelButton.Size = new System.Drawing.Size(23, 22);
            this.removeBagelButton.Text = "toolStripButton5";
            this.removeBagelButton.ToolTipText = "Remove Bagel";
            this.removeBagelButton.Click += new System.EventHandler(this.removeBagelButton_Click);
            // 
            // countBagelButton
            // 
            this.countBagelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countBagelButton.Image = global::HW6_ErkinGeorge.Properties.Resources.dollars_money_bills_paper_with_wings;
            this.countBagelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.countBagelButton.Name = "countBagelButton";
            this.countBagelButton.Size = new System.Drawing.Size(23, 22);
            this.countBagelButton.Text = "toolStripButton6";
            this.countBagelButton.ToolTipText = "Count Bagels";
            this.countBagelButton.Click += new System.EventHandler(this.countBagelButton_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearListButton.Image = global::HW6_ErkinGeorge.Properties.Resources.counterclockwise_rotating_arrow_around_a_clock;
            this.clearListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(23, 22);
            this.clearListButton.Text = "toolStripButton7";
            this.clearListButton.ToolTipText = "Clear List of Bagels";
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // aboutButton
            // 
            this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutButton.Image = global::HW6_ErkinGeorge.Properties.Resources.mechanical_gears_;
            this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(23, 22);
            this.aboutButton.Text = "toolStripButton8";
            this.aboutButton.ToolTipText = "About";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // contextBagelMenu
            // 
            this.contextBagelMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formBackgroundColorToolStripMenuItem,
            this.toolStripSeparator5,
            this.listFontToolStripMenuItem,
            this.listBackgroundColorToolStripMenuItem,
            this.listTextColorToolStripMenuItem});
            this.contextBagelMenu.Name = "contextBagelMenu";
            this.contextBagelMenu.Size = new System.Drawing.Size(202, 98);
            // 
            // formBackgroundColorToolStripMenuItem
            // 
            this.formBackgroundColorToolStripMenuItem.Name = "formBackgroundColorToolStripMenuItem";
            this.formBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.formBackgroundColorToolStripMenuItem.Text = "Form Background Color";
            this.formBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.formBackgroundColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(198, 6);
            // 
            // listFontToolStripMenuItem
            // 
            this.listFontToolStripMenuItem.Name = "listFontToolStripMenuItem";
            this.listFontToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listFontToolStripMenuItem.Text = "List Font";
            this.listFontToolStripMenuItem.Click += new System.EventHandler(this.listFontToolStripMenuItem_Click);
            // 
            // listBackgroundColorToolStripMenuItem
            // 
            this.listBackgroundColorToolStripMenuItem.Name = "listBackgroundColorToolStripMenuItem";
            this.listBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listBackgroundColorToolStripMenuItem.Text = "List Background Color";
            this.listBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.listBackgroundColorToolStripMenuItem_Click);
            // 
            // listTextColorToolStripMenuItem
            // 
            this.listTextColorToolStripMenuItem.Name = "listTextColorToolStripMenuItem";
            this.listTextColorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listTextColorToolStripMenuItem.Text = "List Text Color";
            this.listTextColorToolStripMenuItem.Click += new System.EventHandler(this.listTextColorToolStripMenuItem_Click);
            // 
            // bagelStatusStrip
            // 
            this.bagelStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentFileName,
            this.spacingThing,
            this.currentDataName});
            this.bagelStatusStrip.Location = new System.Drawing.Point(0, 441);
            this.bagelStatusStrip.Name = "bagelStatusStrip";
            this.bagelStatusStrip.Size = new System.Drawing.Size(722, 22);
            this.bagelStatusStrip.TabIndex = 6;
            this.bagelStatusStrip.Text = "string.empty";
            // 
            // recentFileName
            // 
            this.recentFileName.Name = "recentFileName";
            this.recentFileName.Size = new System.Drawing.Size(0, 17);
            // 
            // spacingThing
            // 
            this.spacingThing.Name = "spacingThing";
            this.spacingThing.Size = new System.Drawing.Size(707, 17);
            this.spacingThing.Spring = true;
            // 
            // currentDataName
            // 
            this.currentDataName.Name = "currentDataName";
            this.currentDataName.Size = new System.Drawing.Size(0, 17);
            // 
            // bagelFontDialogue
            // 
            this.bagelFontDialogue.ShowApply = true;
            this.bagelFontDialogue.Apply += new System.EventHandler(this.bagelFontDialogue_Apply);
            // 
            // bagelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 463);
            this.ContextMenuStrip = this.contextBagelMenu;
            this.Controls.Add(this.bagelStatusStrip);
            this.Controls.Add(this.bagelToolStrip);
            this.Controls.Add(this.bagelTextBox);
            this.Controls.Add(this.BagelLabel);
            this.Controls.Add(this.bagelListBox);
            this.Controls.Add(this.bagelMenuStrip);
            this.MainMenuStrip = this.bagelMenuStrip;
            this.Name = "bagelForm";
            this.Text = "Bagel Menu";
            this.bagelMenuStrip.ResumeLayout(false);
            this.bagelMenuStrip.PerformLayout();
            this.bagelToolStrip.ResumeLayout(false);
            this.bagelToolStrip.PerformLayout();
            this.contextBagelMenu.ResumeLayout(false);
            this.bagelStatusStrip.ResumeLayout(false);
            this.bagelStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip bagelMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAndLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAndAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBagelTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBagelTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem countBagelTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openAndLoad;
        private System.Windows.Forms.ListBox bagelListBox;
        private System.Windows.Forms.Label BagelLabel;
        private System.Windows.Forms.TextBox bagelTextBox;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStrip bagelToolStrip;
        private System.Windows.Forms.ToolStripButton openLoadStripButton;
        private System.Windows.Forms.ToolStripButton openAddStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton saveFileButton;
        private System.Windows.Forms.ToolStripButton addBagelButton;
        private System.Windows.Forms.ToolStripButton removeBagelButton;
        private System.Windows.Forms.ToolStripButton countBagelButton;
        private System.Windows.Forms.ContextMenuStrip contextBagelMenu;
        private System.Windows.Forms.ToolStripMenuItem formBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem listFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listTextColorToolStripMenuItem;
        private System.Windows.Forms.StatusStrip bagelStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel recentFileName;
        private System.Windows.Forms.ColorDialog bagelColorDialogue;
        private System.Windows.Forms.FontDialog bagelFontDialogue;
        private System.Windows.Forms.ToolStripButton clearListButton;
        private System.Windows.Forms.ToolStripButton aboutButton;
        private System.Windows.Forms.ToolStripStatusLabel spacingThing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripStatusLabel currentDataName;
    }
}

