namespace HW4_ErkinGeorge
{
    partial class HospitalProgram
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
            this.aboutButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.daysInHospitalTextbox = new System.Windows.Forms.TextBox();
            this.medicalChargesTextbox = new System.Windows.Forms.TextBox();
            this.physicalChargesTextbox = new System.Windows.Forms.TextBox();
            this.labFeesTextbox = new System.Windows.Forms.TextBox();
            this.surgicalFeesTextbox = new System.Windows.Forms.TextBox();
            this.telephoneTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.daysInHospitalLabel = new System.Windows.Forms.Label();
            this.medicalChargesLabel = new System.Windows.Forms.Label();
            this.surgicalFeesLabel = new System.Windows.Forms.Label();
            this.labFeesLabel = new System.Windows.Forms.Label();
            this.physicalRehabLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.patientEmailLabel = new System.Windows.Forms.Label();
            this.patientTelephoneLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.GroupBox();
            this.averageDailyOutput = new System.Windows.Forms.Label();
            this.totalChargesOutput = new System.Windows.Forms.Label();
            this.sumOfsomechargesOutput = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dailyChargeOutput = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1004, 477);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(142, 62);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(856, 477);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(142, 62);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(709, 477);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(141, 62);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(562, 477);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(141, 62);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // daysInHospitalTextbox
            // 
            this.daysInHospitalTextbox.Location = new System.Drawing.Point(265, 145);
            this.daysInHospitalTextbox.Name = "daysInHospitalTextbox";
            this.daysInHospitalTextbox.Size = new System.Drawing.Size(100, 20);
            this.daysInHospitalTextbox.TabIndex = 3;
            // 
            // medicalChargesTextbox
            // 
            this.medicalChargesTextbox.Location = new System.Drawing.Point(265, 188);
            this.medicalChargesTextbox.Name = "medicalChargesTextbox";
            this.medicalChargesTextbox.Size = new System.Drawing.Size(100, 20);
            this.medicalChargesTextbox.TabIndex = 4;
            // 
            // physicalChargesTextbox
            // 
            this.physicalChargesTextbox.Location = new System.Drawing.Point(265, 312);
            this.physicalChargesTextbox.Name = "physicalChargesTextbox";
            this.physicalChargesTextbox.Size = new System.Drawing.Size(100, 20);
            this.physicalChargesTextbox.TabIndex = 7;
            // 
            // labFeesTextbox
            // 
            this.labFeesTextbox.Location = new System.Drawing.Point(265, 270);
            this.labFeesTextbox.Name = "labFeesTextbox";
            this.labFeesTextbox.Size = new System.Drawing.Size(100, 20);
            this.labFeesTextbox.TabIndex = 6;
            // 
            // surgicalFeesTextbox
            // 
            this.surgicalFeesTextbox.Location = new System.Drawing.Point(265, 228);
            this.surgicalFeesTextbox.Name = "surgicalFeesTextbox";
            this.surgicalFeesTextbox.Size = new System.Drawing.Size(100, 20);
            this.surgicalFeesTextbox.TabIndex = 5;
            // 
            // telephoneTextbox
            // 
            this.telephoneTextbox.Location = new System.Drawing.Point(265, 100);
            this.telephoneTextbox.Name = "telephoneTextbox";
            this.telephoneTextbox.Size = new System.Drawing.Size(100, 20);
            this.telephoneTextbox.TabIndex = 2;
            this.telephoneTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.telephoneTextbox_Validating);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(265, 59);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(100, 20);
            this.emailTextbox.TabIndex = 1;
            this.emailTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextbox_Validating);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(265, 16);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameTextbox.TabIndex = 0;
            this.nameTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextbox_Validating);
            // 
            // daysInHospitalLabel
            // 
            this.daysInHospitalLabel.AutoSize = true;
            this.daysInHospitalLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysInHospitalLabel.Location = new System.Drawing.Point(8, 145);
            this.daysInHospitalLabel.Name = "daysInHospitalLabel";
            this.daysInHospitalLabel.Size = new System.Drawing.Size(142, 21);
            this.daysInHospitalLabel.TabIndex = 12;
            this.daysInHospitalLabel.Text = "Days in Hospital";
            // 
            // medicalChargesLabel
            // 
            this.medicalChargesLabel.AutoSize = true;
            this.medicalChargesLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalChargesLabel.Location = new System.Drawing.Point(7, 188);
            this.medicalChargesLabel.Name = "medicalChargesLabel";
            this.medicalChargesLabel.Size = new System.Drawing.Size(137, 21);
            this.medicalChargesLabel.TabIndex = 13;
            this.medicalChargesLabel.Text = "Medical Charges";
            // 
            // surgicalFeesLabel
            // 
            this.surgicalFeesLabel.AutoSize = true;
            this.surgicalFeesLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surgicalFeesLabel.Location = new System.Drawing.Point(8, 228);
            this.surgicalFeesLabel.Name = "surgicalFeesLabel";
            this.surgicalFeesLabel.Size = new System.Drawing.Size(114, 21);
            this.surgicalFeesLabel.TabIndex = 14;
            this.surgicalFeesLabel.Text = "Surgical Fees";
            // 
            // labFeesLabel
            // 
            this.labFeesLabel.AutoSize = true;
            this.labFeesLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFeesLabel.Location = new System.Drawing.Point(7, 270);
            this.labFeesLabel.Name = "labFeesLabel";
            this.labFeesLabel.Size = new System.Drawing.Size(76, 21);
            this.labFeesLabel.TabIndex = 15;
            this.labFeesLabel.Text = "Lab fees";
            // 
            // physicalRehabLabel
            // 
            this.physicalRehabLabel.AutoSize = true;
            this.physicalRehabLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalRehabLabel.Location = new System.Drawing.Point(8, 312);
            this.physicalRehabLabel.Name = "physicalRehabLabel";
            this.physicalRehabLabel.Size = new System.Drawing.Size(187, 21);
            this.physicalRehabLabel.TabIndex = 16;
            this.physicalRehabLabel.Text = "phsyical rehab charges";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(7, 16);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(113, 21);
            this.patientNameLabel.TabIndex = 17;
            this.patientNameLabel.Text = "Patient name";
            // 
            // patientEmailLabel
            // 
            this.patientEmailLabel.AutoSize = true;
            this.patientEmailLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientEmailLabel.Location = new System.Drawing.Point(7, 59);
            this.patientEmailLabel.Name = "patientEmailLabel";
            this.patientEmailLabel.Size = new System.Drawing.Size(115, 21);
            this.patientEmailLabel.TabIndex = 18;
            this.patientEmailLabel.Text = "Patient email";
            // 
            // patientTelephoneLabel
            // 
            this.patientTelephoneLabel.AutoSize = true;
            this.patientTelephoneLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientTelephoneLabel.Location = new System.Drawing.Point(7, 100);
            this.patientTelephoneLabel.Name = "patientTelephoneLabel";
            this.patientTelephoneLabel.Size = new System.Drawing.Size(147, 21);
            this.patientTelephoneLabel.TabIndex = 19;
            this.patientTelephoneLabel.Text = "Patient telephone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(322, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(505, 50);
            this.label9.TabIndex = 6;
            this.label9.Text = "Swedish Medical Center";
            // 
            // outputBox
            // 
            this.outputBox.Controls.Add(this.averageDailyOutput);
            this.outputBox.Controls.Add(this.totalChargesOutput);
            this.outputBox.Controls.Add(this.sumOfsomechargesOutput);
            this.outputBox.Controls.Add(this.label14);
            this.outputBox.Controls.Add(this.label13);
            this.outputBox.Controls.Add(this.label12);
            this.outputBox.Controls.Add(this.dailyChargeOutput);
            this.outputBox.Controls.Add(this.label10);
            this.outputBox.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(429, 103);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(717, 300);
            this.outputBox.TabIndex = 21;
            this.outputBox.TabStop = false;
            this.outputBox.Text = "Listed charges";
            this.outputBox.Visible = false;
            // 
            // averageDailyOutput
            // 
            this.averageDailyOutput.AutoSize = true;
            this.averageDailyOutput.Location = new System.Drawing.Point(313, 169);
            this.averageDailyOutput.Name = "averageDailyOutput";
            this.averageDailyOutput.Size = new System.Drawing.Size(105, 21);
            this.averageDailyOutput.TabIndex = 7;
            this.averageDailyOutput.Text = "daily charge";
            // 
            // totalChargesOutput
            // 
            this.totalChargesOutput.AutoSize = true;
            this.totalChargesOutput.Location = new System.Drawing.Point(313, 129);
            this.totalChargesOutput.Name = "totalChargesOutput";
            this.totalChargesOutput.Size = new System.Drawing.Size(109, 21);
            this.totalChargesOutput.TabIndex = 6;
            this.totalChargesOutput.Text = "total charges";
            // 
            // sumOfsomechargesOutput
            // 
            this.sumOfsomechargesOutput.AutoSize = true;
            this.sumOfsomechargesOutput.Location = new System.Drawing.Point(313, 73);
            this.sumOfsomechargesOutput.Name = "sumOfsomechargesOutput";
            this.sumOfsomechargesOutput.Size = new System.Drawing.Size(114, 21);
            this.sumOfsomechargesOutput.TabIndex = 5;
            this.sumOfsomechargesOutput.Text = "other charges";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 21);
            this.label14.TabIndex = 4;
            this.label14.Text = "Average daily bill";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "Sum of all charges";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(243, 42);
            this.label12.TabIndex = 2;
            this.label12.Text = "Sum of medication, surgical,\r\nlab and rehabilitation charges\r\n";
            // 
            // dailyChargeOutput
            // 
            this.dailyChargeOutput.AutoSize = true;
            this.dailyChargeOutput.Location = new System.Drawing.Point(313, 37);
            this.dailyChargeOutput.Name = "dailyChargeOutput";
            this.dailyChargeOutput.Size = new System.Drawing.Size(154, 21);
            this.dailyChargeOutput.TabIndex = 1;
            this.dailyChargeOutput.Text = "daiy charge output";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Daily Charge";
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.patientTelephoneLabel);
            this.inputGroupBox.Controls.Add(this.patientEmailLabel);
            this.inputGroupBox.Controls.Add(this.patientNameLabel);
            this.inputGroupBox.Controls.Add(this.physicalRehabLabel);
            this.inputGroupBox.Controls.Add(this.labFeesLabel);
            this.inputGroupBox.Controls.Add(this.surgicalFeesLabel);
            this.inputGroupBox.Controls.Add(this.nameTextbox);
            this.inputGroupBox.Controls.Add(this.medicalChargesLabel);
            this.inputGroupBox.Controls.Add(this.daysInHospitalTextbox);
            this.inputGroupBox.Controls.Add(this.daysInHospitalLabel);
            this.inputGroupBox.Controls.Add(this.medicalChargesTextbox);
            this.inputGroupBox.Controls.Add(this.emailTextbox);
            this.inputGroupBox.Controls.Add(this.physicalChargesTextbox);
            this.inputGroupBox.Controls.Add(this.telephoneTextbox);
            this.inputGroupBox.Controls.Add(this.labFeesTextbox);
            this.inputGroupBox.Controls.Add(this.surgicalFeesTextbox);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 103);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(387, 361);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            // 
            // HospitalProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 583);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.exitButton);
            this.Name = "HospitalProgram";
            this.Text = "Charges for Hospital Occupant";
            this.outputBox.ResumeLayout(false);
            this.outputBox.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox daysInHospitalTextbox;
        private System.Windows.Forms.TextBox medicalChargesTextbox;
        private System.Windows.Forms.TextBox physicalChargesTextbox;
        private System.Windows.Forms.TextBox labFeesTextbox;
        private System.Windows.Forms.TextBox surgicalFeesTextbox;
        private System.Windows.Forms.TextBox telephoneTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label daysInHospitalLabel;
        private System.Windows.Forms.Label medicalChargesLabel;
        private System.Windows.Forms.Label surgicalFeesLabel;
        private System.Windows.Forms.Label labFeesLabel;
        private System.Windows.Forms.Label physicalRehabLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientEmailLabel;
        private System.Windows.Forms.Label patientTelephoneLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox outputBox;
        private System.Windows.Forms.Label averageDailyOutput;
        private System.Windows.Forms.Label totalChargesOutput;
        private System.Windows.Forms.Label sumOfsomechargesOutput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label dailyChargeOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox inputGroupBox;
    }
}

