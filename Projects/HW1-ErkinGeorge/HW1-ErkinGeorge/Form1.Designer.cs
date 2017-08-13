namespace HW1_ErkinGeorge
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
            this.exitButton = new System.Windows.Forms.Button();
            this.chefButton = new System.Windows.Forms.Button();
            this.fishButton = new System.Windows.Forms.Button();
            this.soupButton = new System.Windows.Forms.Button();
            this.specialPic = new System.Windows.Forms.PictureBox();
            this.pictureFish = new System.Windows.Forms.PictureBox();
            this.pictureSoup = new System.Windows.Forms.PictureBox();
            this.dinerName = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.specialPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoup)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(804, 354);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // chefButton
            // 
            this.chefButton.Location = new System.Drawing.Point(614, 266);
            this.chefButton.Name = "chefButton";
            this.chefButton.Size = new System.Drawing.Size(101, 35);
            this.chefButton.TabIndex = 1;
            this.chefButton.Text = "Chef\'s Special";
            this.chefButton.UseVisualStyleBackColor = true;
            this.chefButton.Click += new System.EventHandler(this.chefButton_Click);
            // 
            // fishButton
            // 
            this.fishButton.Location = new System.Drawing.Point(309, 266);
            this.fishButton.Name = "fishButton";
            this.fishButton.Size = new System.Drawing.Size(101, 35);
            this.fishButton.TabIndex = 2;
            this.fishButton.Text = "Daily Fish";
            this.fishButton.UseVisualStyleBackColor = true;
            this.fishButton.Click += new System.EventHandler(this.fishButton_Click);
            // 
            // soupButton
            // 
            this.soupButton.Location = new System.Drawing.Point(12, 266);
            this.soupButton.Name = "soupButton";
            this.soupButton.Size = new System.Drawing.Size(101, 35);
            this.soupButton.TabIndex = 0;
            this.soupButton.Text = "Today\'s Soup";
            this.soupButton.UseVisualStyleBackColor = true;
            this.soupButton.Click += new System.EventHandler(this.soupButton_Click);
            // 
            // specialPic
            // 
            this.specialPic.Image = global::HW1_ErkinGeorge.Properties.Resources.spaghetti;
            this.specialPic.Location = new System.Drawing.Point(614, 78);
            this.specialPic.Name = "specialPic";
            this.specialPic.Size = new System.Drawing.Size(291, 173);
            this.specialPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.specialPic.TabIndex = 4;
            this.specialPic.TabStop = false;
            this.specialPic.Visible = false;
            // 
            // pictureFish
            // 
            this.pictureFish.Image = global::HW1_ErkinGeorge.Properties.Resources.fish;
            this.pictureFish.Location = new System.Drawing.Point(309, 78);
            this.pictureFish.Name = "pictureFish";
            this.pictureFish.Size = new System.Drawing.Size(291, 173);
            this.pictureFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFish.TabIndex = 5;
            this.pictureFish.TabStop = false;
            this.pictureFish.Visible = false;
            // 
            // pictureSoup
            // 
            this.pictureSoup.Image = global::HW1_ErkinGeorge.Properties.Resources.soup;
            this.pictureSoup.Location = new System.Drawing.Point(12, 78);
            this.pictureSoup.Name = "pictureSoup";
            this.pictureSoup.Size = new System.Drawing.Size(291, 173);
            this.pictureSoup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSoup.TabIndex = 6;
            this.pictureSoup.TabStop = false;
            this.pictureSoup.Visible = false;
            // 
            // dinerName
            // 
            this.dinerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinerName.ForeColor = System.Drawing.Color.Red;
            this.dinerName.Location = new System.Drawing.Point(374, 9);
            this.dinerName.Name = "dinerName";
            this.dinerName.Size = new System.Drawing.Size(217, 55);
            this.dinerName.TabIndex = 10;
            this.dinerName.Text = "Erkin\'s Eatery";
            // 
            // foodLabel
            // 
            this.foodLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.foodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.Location = new System.Drawing.Point(118, 334);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(560, 36);
            this.foodLabel.TabIndex = 11;
            this.foodLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(917, 401);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.dinerName);
            this.Controls.Add(this.pictureSoup);
            this.Controls.Add(this.pictureFish);
            this.Controls.Add(this.specialPic);
            this.Controls.Add(this.soupButton);
            this.Controls.Add(this.chefButton);
            this.Controls.Add(this.fishButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.specialPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button chefButton;
        private System.Windows.Forms.Button fishButton;
        private System.Windows.Forms.Button soupButton;
        private System.Windows.Forms.PictureBox specialPic;
        private System.Windows.Forms.PictureBox pictureFish;
        private System.Windows.Forms.PictureBox pictureSoup;
        private System.Windows.Forms.Label dinerName;
        private System.Windows.Forms.Label foodLabel;
    }
}

