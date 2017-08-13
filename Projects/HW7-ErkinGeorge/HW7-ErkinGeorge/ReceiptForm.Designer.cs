namespace HW7_ErkinGeorge
{
    partial class ReceiptForm
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
            this.receiptFormSubmitButton = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.registrantNameLabel = new System.Windows.Forms.Label();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.cityStateLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.thankYouPicBox = new System.Windows.Forms.PictureBox();
            this.ConferenceChargesLabel = new System.Windows.Forms.Label();
            this.DinerChargeslabel = new System.Windows.Forms.Label();
            this.workshopCharges = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thankYouPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptFormSubmitButton
            // 
            this.receiptFormSubmitButton.Location = new System.Drawing.Point(517, 311);
            this.receiptFormSubmitButton.Name = "receiptFormSubmitButton";
            this.receiptFormSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.receiptFormSubmitButton.TabIndex = 0;
            this.receiptFormSubmitButton.Text = "Submit";
            this.receiptFormSubmitButton.UseVisualStyleBackColor = true;
            this.receiptFormSubmitButton.Click += new System.EventHandler(this.receiptFormSubmitButton_Click);
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(112, 9);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(369, 31);
            this.headingLabel.TabIndex = 1;
            this.headingLabel.Text = "Cloud Computing in Seattle";
            // 
            // registrantNameLabel
            // 
            this.registrantNameLabel.AutoSize = true;
            this.registrantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrantNameLabel.Location = new System.Drawing.Point(23, 68);
            this.registrantNameLabel.Name = "registrantNameLabel";
            this.registrantNameLabel.Size = new System.Drawing.Size(149, 24);
            this.registrantNameLabel.TabIndex = 2;
            this.registrantNameLabel.Text = "Registrant Name";
            // 
            // totalChargesLabel
            // 
            this.totalChargesLabel.AutoSize = true;
            this.totalChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalChargesLabel.Location = new System.Drawing.Point(23, 308);
            this.totalChargesLabel.Name = "totalChargesLabel";
            this.totalChargesLabel.Size = new System.Drawing.Size(215, 24);
            this.totalChargesLabel.TabIndex = 3;
            this.totalChargesLabel.Text = "Total charges for Person";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(23, 105);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(91, 24);
            this.companyNameLabel.TabIndex = 4;
            this.companyNameLabel.Text = "Company";
            // 
            // cityStateLabel
            // 
            this.cityStateLabel.AutoSize = true;
            this.cityStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityStateLabel.Location = new System.Drawing.Point(23, 135);
            this.cityStateLabel.Name = "cityStateLabel";
            this.cityStateLabel.Size = new System.Drawing.Size(86, 24);
            this.cityStateLabel.TabIndex = 5;
            this.cityStateLabel.Text = "City State";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(23, 166);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(71, 24);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(23, 190);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 24);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email";
            // 
            // thankYouPicBox
            // 
            this.thankYouPicBox.Image = global::HW7_ErkinGeorge.Properties.Resources.thank_you_pic;
            this.thankYouPicBox.Location = new System.Drawing.Point(344, 68);
            this.thankYouPicBox.Name = "thankYouPicBox";
            this.thankYouPicBox.Size = new System.Drawing.Size(235, 192);
            this.thankYouPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thankYouPicBox.TabIndex = 8;
            this.thankYouPicBox.TabStop = false;
            // 
            // ConferenceChargesLabel
            // 
            this.ConferenceChargesLabel.AutoSize = true;
            this.ConferenceChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConferenceChargesLabel.Location = new System.Drawing.Point(23, 214);
            this.ConferenceChargesLabel.Name = "ConferenceChargesLabel";
            this.ConferenceChargesLabel.Size = new System.Drawing.Size(185, 24);
            this.ConferenceChargesLabel.TabIndex = 9;
            this.ConferenceChargesLabel.Text = "Conference Charges";
            this.ConferenceChargesLabel.Visible = false;
            // 
            // DinerChargeslabel
            // 
            this.DinerChargeslabel.AutoSize = true;
            this.DinerChargeslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinerChargeslabel.Location = new System.Drawing.Point(23, 238);
            this.DinerChargeslabel.Name = "DinerChargeslabel";
            this.DinerChargeslabel.Size = new System.Drawing.Size(142, 24);
            this.DinerChargeslabel.TabIndex = 10;
            this.DinerChargeslabel.Text = "Dinner Charges";
            this.DinerChargeslabel.Visible = false;
            // 
            // workshopCharges
            // 
            this.workshopCharges.AutoSize = true;
            this.workshopCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopCharges.Location = new System.Drawing.Point(23, 262);
            this.workshopCharges.Name = "workshopCharges";
            this.workshopCharges.Size = new System.Drawing.Size(172, 24);
            this.workshopCharges.TabIndex = 11;
            this.workshopCharges.Text = "Workshop Charges";
            this.workshopCharges.Visible = false;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 346);
            this.Controls.Add(this.workshopCharges);
            this.Controls.Add(this.DinerChargeslabel);
            this.Controls.Add(this.ConferenceChargesLabel);
            this.Controls.Add(this.thankYouPicBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.cityStateLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.totalChargesLabel);
            this.Controls.Add(this.registrantNameLabel);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.receiptFormSubmitButton);
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thankYouPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button receiptFormSubmitButton;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label registrantNameLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label cityStateLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.PictureBox thankYouPicBox;
        public System.Windows.Forms.Label ConferenceChargesLabel;
        public System.Windows.Forms.Label totalChargesLabel;
        public System.Windows.Forms.Label DinerChargeslabel;
        public System.Windows.Forms.Label workshopCharges;
    }
}