namespace HW7_ErkinGeorge
{
    partial class MainForm
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
            this.registerButton = new System.Windows.Forms.Button();
            this.nameOfConferenceLabel = new System.Windows.Forms.Label();
            this.mainFormPicBox = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(559, 329);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(478, 329);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // nameOfConferenceLabel
            // 
            this.nameOfConferenceLabel.AutoSize = true;
            this.nameOfConferenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfConferenceLabel.Location = new System.Drawing.Point(2, 9);
            this.nameOfConferenceLabel.Name = "nameOfConferenceLabel";
            this.nameOfConferenceLabel.Size = new System.Drawing.Size(299, 25);
            this.nameOfConferenceLabel.TabIndex = 3;
            this.nameOfConferenceLabel.Text = "Cloud Computing in Seattle";
            // 
            // mainFormPicBox
            // 
            this.mainFormPicBox.Image = global::HW7_ErkinGeorge.Properties.Resources.Conference;
            this.mainFormPicBox.Location = new System.Drawing.Point(182, 81);
            this.mainFormPicBox.Name = "mainFormPicBox";
            this.mainFormPicBox.Size = new System.Drawing.Size(254, 176);
            this.mainFormPicBox.TabIndex = 2;
            this.mainFormPicBox.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(12, 65);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(159, 20);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "June 12 - 15, 2017";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(12, 45);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(309, 20);
            this.locationLabel.TabIndex = 5;
            this.locationLabel.Text = "Falcon Resort in Seattle, Washington";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 364);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameOfConferenceLabel);
            this.Controls.Add(this.mainFormPicBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.exitButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.mainFormPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.PictureBox mainFormPicBox;
        private System.Windows.Forms.Label nameOfConferenceLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label locationLabel;
    }
}

