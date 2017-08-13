namespace HW2_ErkinGeorge
{
    partial class calculatorApp
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
            this.bankBlurb = new System.Windows.Forms.Label();
            this.programDescription = new System.Windows.Forms.Label();
            this.bankName = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.activityLabel = new System.Windows.Forms.Label();
            this.checking = new System.Windows.Forms.Label();
            this.savings = new System.Windows.Forms.Label();
            this.balanceShow = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.activityTextbox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.checkingStart = new System.Windows.Forms.TextBox();
            this.savingsStart = new System.Windows.Forms.TextBox();
            this.checkingDeposit = new System.Windows.Forms.TextBox();
            this.savingsDeposit = new System.Windows.Forms.TextBox();
            this.checkingWithdraw = new System.Windows.Forms.TextBox();
            this.savingsWithdraw = new System.Windows.Forms.TextBox();
            this.checkingBalance = new System.Windows.Forms.TextBox();
            this.savingsBalance = new System.Windows.Forms.TextBox();
            this.begBalanceLabel = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.withdrawLabel = new System.Windows.Forms.Label();
            this.endBalanceLabel = new System.Windows.Forms.Label();
            this.accountsInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bankBlurb
            // 
            this.bankBlurb.AutoSize = true;
            this.bankBlurb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankBlurb.Location = new System.Drawing.Point(364, 66);
            this.bankBlurb.Name = "bankBlurb";
            this.bankBlurb.Size = new System.Drawing.Size(168, 20);
            this.bankBlurb.TabIndex = 1;
            this.bankBlurb.Text = "\" We\'re small but safe\"";
            // 
            // programDescription
            // 
            this.programDescription.AutoSize = true;
            this.programDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programDescription.Location = new System.Drawing.Point(338, 86);
            this.programDescription.Name = "programDescription";
            this.programDescription.Size = new System.Drawing.Size(225, 20);
            this.programDescription.TabIndex = 2;
            this.programDescription.Text = "Personal Account Manager";
            // 
            // bankName
            // 
            this.bankName.AutoSize = true;
            this.bankName.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankName.Location = new System.Drawing.Point(349, 9);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(214, 57);
            this.bankName.TabIndex = 10;
            this.bankName.Text = "Tiny Bank";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(157, 147);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLabel.Location = new System.Drawing.Point(157, 190);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(68, 16);
            this.activityLabel.TabIndex = 5;
            this.activityLabel.Text = "Activity for";
            // 
            // checking
            // 
            this.checking.AutoSize = true;
            this.checking.Location = new System.Drawing.Point(122, 291);
            this.checking.Name = "checking";
            this.checking.Size = new System.Drawing.Size(52, 13);
            this.checking.TabIndex = 17;
            this.checking.Text = "Checking";
            // 
            // savings
            // 
            this.savings.AutoSize = true;
            this.savings.Location = new System.Drawing.Point(122, 346);
            this.savings.Name = "savings";
            this.savings.Size = new System.Drawing.Size(45, 13);
            this.savings.TabIndex = 16;
            this.savings.Text = "Savings";
            // 
            // balanceShow
            // 
            this.balanceShow.Location = new System.Drawing.Point(589, 405);
            this.balanceShow.Name = "balanceShow";
            this.balanceShow.Size = new System.Drawing.Size(95, 23);
            this.balanceShow.TabIndex = 10;
            this.balanceShow.Text = "Show balance";
            this.balanceShow.UseVisualStyleBackColor = true;
            this.balanceShow.Click += new System.EventHandler(this.balanceShow_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(713, 405);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(808, 405);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(234, 143);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(167, 20);
            this.nameTextbox.TabIndex = 0;
            // 
            // activityTextbox
            // 
            this.activityTextbox.Location = new System.Drawing.Point(234, 186);
            this.activityTextbox.Name = "activityTextbox";
            this.activityTextbox.Size = new System.Drawing.Size(167, 20);
            this.activityTextbox.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(231, 209);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(71, 13);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Month, YYYY";
            // 
            // checkingStart
            // 
            this.checkingStart.Location = new System.Drawing.Point(266, 284);
            this.checkingStart.Name = "checkingStart";
            this.checkingStart.Size = new System.Drawing.Size(100, 20);
            this.checkingStart.TabIndex = 2;
            this.checkingStart.Text = "0.00";
            // 
            // savingsStart
            // 
            this.savingsStart.Location = new System.Drawing.Point(266, 346);
            this.savingsStart.Name = "savingsStart";
            this.savingsStart.Size = new System.Drawing.Size(100, 20);
            this.savingsStart.TabIndex = 6;
            this.savingsStart.Text = "0.00";
            // 
            // checkingDeposit
            // 
            this.checkingDeposit.Location = new System.Drawing.Point(448, 284);
            this.checkingDeposit.Name = "checkingDeposit";
            this.checkingDeposit.Size = new System.Drawing.Size(100, 20);
            this.checkingDeposit.TabIndex = 3;
            this.checkingDeposit.Text = "0.00";
            // 
            // savingsDeposit
            // 
            this.savingsDeposit.Location = new System.Drawing.Point(448, 343);
            this.savingsDeposit.Name = "savingsDeposit";
            this.savingsDeposit.Size = new System.Drawing.Size(100, 20);
            this.savingsDeposit.TabIndex = 7;
            this.savingsDeposit.Text = "0.00";
            // 
            // checkingWithdraw
            // 
            this.checkingWithdraw.Location = new System.Drawing.Point(635, 284);
            this.checkingWithdraw.Name = "checkingWithdraw";
            this.checkingWithdraw.Size = new System.Drawing.Size(100, 20);
            this.checkingWithdraw.TabIndex = 4;
            this.checkingWithdraw.Text = "0.00";
            // 
            // savingsWithdraw
            // 
            this.savingsWithdraw.Location = new System.Drawing.Point(635, 339);
            this.savingsWithdraw.Name = "savingsWithdraw";
            this.savingsWithdraw.Size = new System.Drawing.Size(100, 20);
            this.savingsWithdraw.TabIndex = 8;
            this.savingsWithdraw.Text = "0.00";
            // 
            // checkingBalance
            // 
            this.checkingBalance.Location = new System.Drawing.Point(783, 284);
            this.checkingBalance.Name = "checkingBalance";
            this.checkingBalance.Size = new System.Drawing.Size(100, 20);
            this.checkingBalance.TabIndex = 5;
            // 
            // savingsBalance
            // 
            this.savingsBalance.Location = new System.Drawing.Point(783, 339);
            this.savingsBalance.Name = "savingsBalance";
            this.savingsBalance.Size = new System.Drawing.Size(100, 20);
            this.savingsBalance.TabIndex = 9;
            // 
            // begBalanceLabel
            // 
            this.begBalanceLabel.AutoSize = true;
            this.begBalanceLabel.Location = new System.Drawing.Point(263, 263);
            this.begBalanceLabel.Name = "begBalanceLabel";
            this.begBalanceLabel.Size = new System.Drawing.Size(96, 13);
            this.begBalanceLabel.TabIndex = 22;
            this.begBalanceLabel.Text = "Beginning Balance";
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Location = new System.Drawing.Point(445, 263);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(48, 13);
            this.depositLabel.TabIndex = 23;
            this.depositLabel.Text = "Deposits";
            // 
            // withdrawLabel
            // 
            this.withdrawLabel.AutoSize = true;
            this.withdrawLabel.Location = new System.Drawing.Point(632, 263);
            this.withdrawLabel.Name = "withdrawLabel";
            this.withdrawLabel.Size = new System.Drawing.Size(65, 13);
            this.withdrawLabel.TabIndex = 24;
            this.withdrawLabel.Text = "Withdrawals";
            // 
            // endBalanceLabel
            // 
            this.endBalanceLabel.AutoSize = true;
            this.endBalanceLabel.Location = new System.Drawing.Point(780, 263);
            this.endBalanceLabel.Name = "endBalanceLabel";
            this.endBalanceLabel.Size = new System.Drawing.Size(82, 13);
            this.endBalanceLabel.TabIndex = 25;
            this.endBalanceLabel.Text = "Ending Balance";
            // 
            // accountsInfo
            // 
            this.accountsInfo.AutoSize = true;
            this.accountsInfo.Location = new System.Drawing.Point(356, 437);
            this.accountsInfo.Name = "accountsInfo";
            this.accountsInfo.Size = new System.Drawing.Size(98, 13);
            this.accountsInfo.TabIndex = 14;
            this.accountsInfo.Text = "Accounts Summary";
            this.accountsInfo.Visible = false;
            // 
            // calculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(997, 518);
            this.Controls.Add(this.accountsInfo);
            this.Controls.Add(this.endBalanceLabel);
            this.Controls.Add(this.withdrawLabel);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.begBalanceLabel);
            this.Controls.Add(this.savingsBalance);
            this.Controls.Add(this.checkingBalance);
            this.Controls.Add(this.savingsWithdraw);
            this.Controls.Add(this.checkingWithdraw);
            this.Controls.Add(this.savingsDeposit);
            this.Controls.Add(this.checkingDeposit);
            this.Controls.Add(this.savingsStart);
            this.Controls.Add(this.checkingStart);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.activityTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.balanceShow);
            this.Controls.Add(this.savings);
            this.Controls.Add(this.checking);
            this.Controls.Add(this.activityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.bankName);
            this.Controls.Add(this.programDescription);
            this.Controls.Add(this.bankBlurb);
            this.Name = "calculatorApp";
            this.Text = "Personal Finance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bankBlurb;
        private System.Windows.Forms.Label programDescription;
        private System.Windows.Forms.Label bankName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.Label checking;
        private System.Windows.Forms.Label savings;
        private System.Windows.Forms.Button balanceShow;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox activityTextbox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox checkingStart;
        private System.Windows.Forms.TextBox savingsStart;
        private System.Windows.Forms.TextBox checkingDeposit;
        private System.Windows.Forms.TextBox savingsDeposit;
        private System.Windows.Forms.TextBox checkingWithdraw;
        private System.Windows.Forms.TextBox savingsWithdraw;
        private System.Windows.Forms.TextBox checkingBalance;
        private System.Windows.Forms.TextBox savingsBalance;
        private System.Windows.Forms.Label begBalanceLabel;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label withdrawLabel;
        private System.Windows.Forms.Label endBalanceLabel;
        private System.Windows.Forms.Label accountsInfo;
    }
}

