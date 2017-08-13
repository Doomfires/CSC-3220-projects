namespace exploringMenus_EG_JL
{
    partial class Form1
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
            this.android = new System.Windows.Forms.PictureBox();
            this.blackberry = new System.Windows.Forms.PictureBox();
            this.windows = new System.Windows.Forms.PictureBox();
            this.apple = new System.Windows.Forms.PictureBox();
            this.osLabel = new System.Windows.Forms.Label();
            this.menuSystem = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.restToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.androidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackberryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowdsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platformNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.android)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackberry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            this.menuSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // android
            // 
            this.android.Image = global::exploringMenus_EG_JL.Properties.Resources.Android_logo;
            this.android.Location = new System.Drawing.Point(299, 157);
            this.android.Name = "android";
            this.android.Size = new System.Drawing.Size(129, 166);
            this.android.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.android.TabIndex = 0;
            this.android.TabStop = false;
            this.android.Visible = false;
            // 
            // blackberry
            // 
            this.blackberry.Image = global::exploringMenus_EG_JL.Properties.Resources.blackberry_logo;
            this.blackberry.Location = new System.Drawing.Point(300, 150);
            this.blackberry.Name = "blackberry";
            this.blackberry.Size = new System.Drawing.Size(122, 166);
            this.blackberry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blackberry.TabIndex = 1;
            this.blackberry.TabStop = false;
            this.blackberry.Visible = false;
            // 
            // windows
            // 
            this.windows.Image = global::exploringMenus_EG_JL.Properties.Resources.Windows_10_Mobile_Logo;
            this.windows.Location = new System.Drawing.Point(306, 150);
            this.windows.Name = "windows";
            this.windows.Size = new System.Drawing.Size(122, 166);
            this.windows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.windows.TabIndex = 2;
            this.windows.TabStop = false;
            this.windows.Visible = false;
            // 
            // apple
            // 
            this.apple.Image = global::exploringMenus_EG_JL.Properties.Resources.ios_logo;
            this.apple.Location = new System.Drawing.Point(299, 150);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(117, 173);
            this.apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.apple.TabIndex = 3;
            this.apple.TabStop = false;
            this.apple.Visible = false;
            // 
            // osLabel
            // 
            this.osLabel.Location = new System.Drawing.Point(291, 335);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(131, 23);
            this.osLabel.TabIndex = 4;
            this.osLabel.Text = "label1";
            // 
            // menuSystem
            // 
            this.menuSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.altFToolStripMenuItem,
            this.platformNameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuSystem.Location = new System.Drawing.Point(0, 0);
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(824, 24);
            this.menuSystem.TabIndex = 5;
            this.menuSystem.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // restToolStripMenuItem
            // 
            this.restToolStripMenuItem.Name = "restToolStripMenuItem";
            this.restToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.restToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restToolStripMenuItem.Text = "&Reset";
            // 
            // altFToolStripMenuItem
            // 
            this.altFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.androidToolStripMenuItem,
            this.blackberryToolStripMenuItem,
            this.iOSToolStripMenuItem,
            this.windowdsToolStripMenuItem});
            this.altFToolStripMenuItem.Name = "altFToolStripMenuItem";
            this.altFToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.altFToolStripMenuItem.Text = "&Platform";
            // 
            // androidToolStripMenuItem
            // 
            this.androidToolStripMenuItem.Name = "androidToolStripMenuItem";
            this.androidToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.androidToolStripMenuItem.Text = "&Android";
            // 
            // blackberryToolStripMenuItem
            // 
            this.blackberryToolStripMenuItem.Name = "blackberryToolStripMenuItem";
            this.blackberryToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.blackberryToolStripMenuItem.Text = "&Blackberry";
            // 
            // iOSToolStripMenuItem
            // 
            this.iOSToolStripMenuItem.Name = "iOSToolStripMenuItem";
            this.iOSToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.iOSToolStripMenuItem.Text = "&iOS";
            // 
            // windowdsToolStripMenuItem
            // 
            this.windowdsToolStripMenuItem.Name = "windowdsToolStripMenuItem";
            this.windowdsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.windowdsToolStripMenuItem.Text = "&Windows";
            // 
            // platformNameToolStripMenuItem
            // 
            this.platformNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem,
            this.toolStripSeparator1,
            this.normalToolStripMenuItem,
            this.reverseColorToolStripMenuItem});
            this.platformNameToolStripMenuItem.Name = "platformNameToolStripMenuItem";
            this.platformNameToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.platformNameToolStripMenuItem.Text = "Platform &Name";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a Platform";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.onToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.onToolStripMenuItem.Text = "On";
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.offToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.offToolStripMenuItem.Text = "Off";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.normalToolStripMenuItem.Text = "Normal Color";
            // 
            // reverseColorToolStripMenuItem
            // 
            this.reverseColorToolStripMenuItem.Name = "reverseColorToolStripMenuItem";
            this.reverseColorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reverseColorToolStripMenuItem.Text = "Reverse Color";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.osLabel);
            this.Controls.Add(this.apple);
            this.Controls.Add(this.windows);
            this.Controls.Add(this.blackberry);
            this.Controls.Add(this.android);
            this.Controls.Add(this.menuSystem);
            this.MainMenuStrip = this.menuSystem;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.android)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackberry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            this.menuSystem.ResumeLayout(false);
            this.menuSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox android;
        private System.Windows.Forms.PictureBox blackberry;
        private System.Windows.Forms.PictureBox windows;
        private System.Windows.Forms.PictureBox apple;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.MenuStrip menuSystem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem altFToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem androidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackberryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowdsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem platformNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseColorToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

