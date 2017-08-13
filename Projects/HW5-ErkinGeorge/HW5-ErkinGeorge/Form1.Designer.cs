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
            this.bagelMenuStrip.SuspendLayout();
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
            this.bagelListBox.FormattingEnabled = true;
            this.bagelListBox.Location = new System.Drawing.Point(55, 75);
            this.bagelListBox.Name = "bagelListBox";
            this.bagelListBox.Size = new System.Drawing.Size(120, 225);
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
            // bagelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 463);
            this.Controls.Add(this.bagelTextBox);
            this.Controls.Add(this.BagelLabel);
            this.Controls.Add(this.bagelListBox);
            this.Controls.Add(this.bagelMenuStrip);
            this.MainMenuStrip = this.bagelMenuStrip;
            this.Name = "bagelForm";
            this.Text = "Bagel Menu";
            this.bagelMenuStrip.ResumeLayout(false);
            this.bagelMenuStrip.PerformLayout();
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
    }
}

