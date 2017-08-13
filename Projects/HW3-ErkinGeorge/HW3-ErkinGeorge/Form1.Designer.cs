namespace HW3_ErkinGeorge
{
    partial class reservationProgram
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
            this.exitButton = new System.Windows.Forms.Button();
            this.queenRadio = new System.Windows.Forms.RadioButton();
            this.kingRadio = new System.Windows.Forms.RadioButton();
            this.namelabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.roomSizeGroup = new System.Windows.Forms.GroupBox();
            this.standardSizeRadio = new System.Windows.Forms.RadioButton();
            this.atriumSizeRadio = new System.Windows.Forms.RadioButton();
            this.viewBox = new System.Windows.Forms.GroupBox();
            this.parkingChoice = new System.Windows.Forms.CheckBox();
            this.numRoomLabel = new System.Windows.Forms.Label();
            this.nightsLabel = new System.Windows.Forms.Label();
            this.numOfAdults = new System.Windows.Forms.NumericUpDown();
            this.adultLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.reservationName = new System.Windows.Forms.TextBox();
            this.numOfRooms = new System.Windows.Forms.TrackBar();
            this.numOfNights = new System.Windows.Forms.TrackBar();
            this.paymentEntry = new System.Windows.Forms.MaskedTextBox();
            this.title = new System.Windows.Forms.Label();
            this.payMaster = new System.Windows.Forms.RadioButton();
            this.payAmerican = new System.Windows.Forms.RadioButton();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.payDiscover = new System.Windows.Forms.RadioButton();
            this.payVisa = new System.Windows.Forms.RadioButton();
            this.roomNameSum = new System.Windows.Forms.Label();
            this.taxNameSum = new System.Windows.Forms.Label();
            this.parkingNameSum = new System.Windows.Forms.Label();
            this.resortNameSum = new System.Windows.Forms.Label();
            this.totalNameSum = new System.Windows.Forms.Label();
            this.summaryBox = new System.Windows.Forms.GroupBox();
            this.summaryTotalDue = new System.Windows.Forms.Label();
            this.summaryResortFee = new System.Windows.Forms.Label();
            this.summaryParking = new System.Windows.Forms.Label();
            this.summaryTax = new System.Windows.Forms.Label();
            this.summaryRoom = new System.Windows.Forms.Label();
            this.childrenLabel = new System.Windows.Forms.Label();
            this.numOfChildren = new System.Windows.Forms.NumericUpDown();
            this.submitButton = new System.Windows.Forms.Button();
            this.expirationLabel = new System.Windows.Forms.Label();
            this.expirationDate = new System.Windows.Forms.MaskedTextBox();
            this.toolTipSubmit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCancel = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.roomSizeGroup.SuspendLayout();
            this.viewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfNights)).BeginInit();
            this.paymentGroupBox.SuspendLayout();
            this.summaryBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfChildren)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(545, 494);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "E&xit";
            this.exitToolTip.SetToolTip(this.exitButton, "Press to exit program.");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // queenRadio
            // 
            this.queenRadio.AutoSize = true;
            this.queenRadio.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queenRadio.Location = new System.Drawing.Point(18, 25);
            this.queenRadio.Name = "queenRadio";
            this.queenRadio.Size = new System.Drawing.Size(53, 19);
            this.queenRadio.TabIndex = 0;
            this.queenRadio.TabStop = true;
            this.queenRadio.Text = "Queen";
            this.queenRadio.UseVisualStyleBackColor = true;
            // 
            // kingRadio
            // 
            this.kingRadio.AutoSize = true;
            this.kingRadio.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kingRadio.Location = new System.Drawing.Point(18, 48);
            this.kingRadio.Name = "kingRadio";
            this.kingRadio.Size = new System.Drawing.Size(48, 19);
            this.kingRadio.TabIndex = 1;
            this.kingRadio.TabStop = true;
            this.kingRadio.Text = "King";
            this.kingRadio.UseVisualStyleBackColor = true;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(22, 64);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(33, 15);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "Name";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(464, 494);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "&Cancel";
            this.toolTipCancel.SetToolTip(this.cancelButton, "Press to reset all data.");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // roomSizeGroup
            // 
            this.roomSizeGroup.Controls.Add(this.kingRadio);
            this.roomSizeGroup.Controls.Add(this.queenRadio);
            this.roomSizeGroup.Location = new System.Drawing.Point(464, 123);
            this.roomSizeGroup.Name = "roomSizeGroup";
            this.roomSizeGroup.Size = new System.Drawing.Size(118, 75);
            this.roomSizeGroup.TabIndex = 6;
            this.roomSizeGroup.TabStop = false;
            this.roomSizeGroup.Text = "Room size";
            // 
            // standardSizeRadio
            // 
            this.standardSizeRadio.AutoSize = true;
            this.standardSizeRadio.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardSizeRadio.Location = new System.Drawing.Point(17, 18);
            this.standardSizeRadio.Name = "standardSizeRadio";
            this.standardSizeRadio.Size = new System.Drawing.Size(67, 19);
            this.standardSizeRadio.TabIndex = 0;
            this.standardSizeRadio.TabStop = true;
            this.standardSizeRadio.Text = "Standard";
            this.standardSizeRadio.UseVisualStyleBackColor = true;
            // 
            // atriumSizeRadio
            // 
            this.atriumSizeRadio.AutoSize = true;
            this.atriumSizeRadio.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atriumSizeRadio.Location = new System.Drawing.Point(17, 42);
            this.atriumSizeRadio.Name = "atriumSizeRadio";
            this.atriumSizeRadio.Size = new System.Drawing.Size(58, 19);
            this.atriumSizeRadio.TabIndex = 1;
            this.atriumSizeRadio.TabStop = true;
            this.atriumSizeRadio.Text = "Atrium";
            this.atriumSizeRadio.UseVisualStyleBackColor = true;
            // 
            // viewBox
            // 
            this.viewBox.Controls.Add(this.atriumSizeRadio);
            this.viewBox.Controls.Add(this.standardSizeRadio);
            this.viewBox.Location = new System.Drawing.Point(465, 45);
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(117, 72);
            this.viewBox.TabIndex = 5;
            this.viewBox.TabStop = false;
            this.viewBox.Text = "View";
            // 
            // parkingChoice
            // 
            this.parkingChoice.AutoSize = true;
            this.parkingChoice.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkingChoice.Location = new System.Drawing.Point(465, 204);
            this.parkingChoice.Name = "parkingChoice";
            this.parkingChoice.Size = new System.Drawing.Size(89, 19);
            this.parkingChoice.TabIndex = 7;
            this.parkingChoice.Text = "Daily parking";
            this.parkingChoice.UseVisualStyleBackColor = true;
            // 
            // numRoomLabel
            // 
            this.numRoomLabel.AutoSize = true;
            this.numRoomLabel.Location = new System.Drawing.Point(22, 123);
            this.numRoomLabel.Name = "numRoomLabel";
            this.numRoomLabel.Size = new System.Drawing.Size(92, 13);
            this.numRoomLabel.TabIndex = 11;
            this.numRoomLabel.Text = "Number of Rooms";
            // 
            // nightsLabel
            // 
            this.nightsLabel.AutoSize = true;
            this.nightsLabel.Location = new System.Drawing.Point(22, 174);
            this.nightsLabel.Name = "nightsLabel";
            this.nightsLabel.Size = new System.Drawing.Size(89, 13);
            this.nightsLabel.TabIndex = 13;
            this.nightsLabel.Text = "Number of Nights";
            // 
            // numOfAdults
            // 
            this.numOfAdults.Location = new System.Drawing.Point(217, 228);
            this.numOfAdults.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numOfAdults.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfAdults.Name = "numOfAdults";
            this.numOfAdults.Size = new System.Drawing.Size(44, 20);
            this.numOfAdults.TabIndex = 3;
            this.numOfAdults.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfAdults.ValueChanged += new System.EventHandler(this.numOfAdults_ValueChanged);
            // 
            // adultLabel
            // 
            this.adultLabel.AutoSize = true;
            this.adultLabel.Location = new System.Drawing.Point(22, 235);
            this.adultLabel.Name = "adultLabel";
            this.adultLabel.Size = new System.Drawing.Size(88, 13);
            this.adultLabel.TabIndex = 15;
            this.adultLabel.Text = "Number of Adults";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(399, 378);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(48, 13);
            this.paymentLabel.TabIndex = 11;
            this.paymentLabel.Text = "Payment";
            // 
            // reservationName
            // 
            this.reservationName.Location = new System.Drawing.Point(83, 57);
            this.reservationName.Name = "reservationName";
            this.reservationName.Size = new System.Drawing.Size(100, 20);
            this.reservationName.TabIndex = 0;
            // 
            // numOfRooms
            // 
            this.numOfRooms.Location = new System.Drawing.Point(193, 110);
            this.numOfRooms.Minimum = 1;
            this.numOfRooms.Name = "numOfRooms";
            this.numOfRooms.Size = new System.Drawing.Size(104, 45);
            this.numOfRooms.TabIndex = 1;
            this.numOfRooms.Value = 1;
            this.numOfRooms.Scroll += new System.EventHandler(this.numOfRooms_Scroll);
            // 
            // numOfNights
            // 
            this.numOfNights.Location = new System.Drawing.Point(193, 171);
            this.numOfNights.Maximum = 7;
            this.numOfNights.Minimum = 1;
            this.numOfNights.Name = "numOfNights";
            this.numOfNights.Size = new System.Drawing.Size(104, 45);
            this.numOfNights.TabIndex = 2;
            this.numOfNights.Value = 1;
            // 
            // paymentEntry
            // 
            this.paymentEntry.Location = new System.Drawing.Point(453, 371);
            this.paymentEntry.Name = "paymentEntry";
            this.paymentEntry.Size = new System.Drawing.Size(146, 20);
            this.paymentEntry.TabIndex = 9;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(150, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(275, 25);
            this.title.TabIndex = 21;
            this.title.Text = "Canal Resort Reservation Form";
            // 
            // payMaster
            // 
            this.payMaster.AutoSize = true;
            this.payMaster.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payMaster.Location = new System.Drawing.Point(6, 42);
            this.payMaster.Name = "payMaster";
            this.payMaster.Size = new System.Drawing.Size(79, 19);
            this.payMaster.TabIndex = 1;
            this.payMaster.TabStop = true;
            this.payMaster.Text = "MasterCard";
            this.payMaster.UseVisualStyleBackColor = true;
            this.payMaster.CheckedChanged += new System.EventHandler(this.payMaster_CheckedChanged);
            // 
            // payAmerican
            // 
            this.payAmerican.AutoSize = true;
            this.payAmerican.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payAmerican.Location = new System.Drawing.Point(6, 19);
            this.payAmerican.Name = "payAmerican";
            this.payAmerican.Size = new System.Drawing.Size(130, 19);
            this.payAmerican.TabIndex = 0;
            this.payAmerican.TabStop = true;
            this.payAmerican.Text = "American Express Card";
            this.payAmerican.UseVisualStyleBackColor = true;
            this.payAmerican.CheckedChanged += new System.EventHandler(this.payAmerican_CheckedChanged);
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.payDiscover);
            this.paymentGroupBox.Controls.Add(this.payVisa);
            this.paymentGroupBox.Controls.Add(this.payAmerican);
            this.paymentGroupBox.Controls.Add(this.payMaster);
            this.paymentGroupBox.Location = new System.Drawing.Point(431, 235);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(168, 120);
            this.paymentGroupBox.TabIndex = 8;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment Method";
            // 
            // payDiscover
            // 
            this.payDiscover.AutoSize = true;
            this.payDiscover.Location = new System.Drawing.Point(6, 92);
            this.payDiscover.Name = "payDiscover";
            this.payDiscover.Size = new System.Drawing.Size(67, 17);
            this.payDiscover.TabIndex = 3;
            this.payDiscover.TabStop = true;
            this.payDiscover.Text = "Discover";
            this.payDiscover.UseVisualStyleBackColor = true;
            this.payDiscover.CheckedChanged += new System.EventHandler(this.payDiscover_CheckedChanged);
            // 
            // payVisa
            // 
            this.payVisa.AutoSize = true;
            this.payVisa.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payVisa.Location = new System.Drawing.Point(6, 67);
            this.payVisa.Name = "payVisa";
            this.payVisa.Size = new System.Drawing.Size(52, 19);
            this.payVisa.TabIndex = 2;
            this.payVisa.TabStop = true;
            this.payVisa.Text = "VISA";
            this.payVisa.UseVisualStyleBackColor = true;
            this.payVisa.CheckedChanged += new System.EventHandler(this.payVisa_CheckedChanged);
            // 
            // roomNameSum
            // 
            this.roomNameSum.AutoSize = true;
            this.roomNameSum.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameSum.Location = new System.Drawing.Point(10, 41);
            this.roomNameSum.Name = "roomNameSum";
            this.roomNameSum.Size = new System.Drawing.Size(35, 15);
            this.roomNameSum.TabIndex = 26;
            this.roomNameSum.Text = "Room";
            // 
            // taxNameSum
            // 
            this.taxNameSum.AutoSize = true;
            this.taxNameSum.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxNameSum.Location = new System.Drawing.Point(10, 73);
            this.taxNameSum.Name = "taxNameSum";
            this.taxNameSum.Size = new System.Drawing.Size(24, 15);
            this.taxNameSum.TabIndex = 27;
            this.taxNameSum.Text = "Tax";
            // 
            // parkingNameSum
            // 
            this.parkingNameSum.AutoSize = true;
            this.parkingNameSum.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkingNameSum.Location = new System.Drawing.Point(10, 108);
            this.parkingNameSum.Name = "parkingNameSum";
            this.parkingNameSum.Size = new System.Drawing.Size(44, 15);
            this.parkingNameSum.TabIndex = 28;
            this.parkingNameSum.Text = "Parking";
            // 
            // resortNameSum
            // 
            this.resortNameSum.AutoSize = true;
            this.resortNameSum.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resortNameSum.Location = new System.Drawing.Point(10, 147);
            this.resortNameSum.Name = "resortNameSum";
            this.resortNameSum.Size = new System.Drawing.Size(52, 15);
            this.resortNameSum.TabIndex = 29;
            this.resortNameSum.Text = "Resort fee";
            // 
            // totalNameSum
            // 
            this.totalNameSum.AutoSize = true;
            this.totalNameSum.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNameSum.Location = new System.Drawing.Point(10, 180);
            this.totalNameSum.Name = "totalNameSum";
            this.totalNameSum.Size = new System.Drawing.Size(51, 15);
            this.totalNameSum.TabIndex = 30;
            this.totalNameSum.Text = "Total due";
            // 
            // summaryBox
            // 
            this.summaryBox.Controls.Add(this.summaryTotalDue);
            this.summaryBox.Controls.Add(this.summaryResortFee);
            this.summaryBox.Controls.Add(this.summaryParking);
            this.summaryBox.Controls.Add(this.summaryTax);
            this.summaryBox.Controls.Add(this.summaryRoom);
            this.summaryBox.Controls.Add(this.totalNameSum);
            this.summaryBox.Controls.Add(this.resortNameSum);
            this.summaryBox.Controls.Add(this.parkingNameSum);
            this.summaryBox.Controls.Add(this.taxNameSum);
            this.summaryBox.Controls.Add(this.roomNameSum);
            this.summaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryBox.Location = new System.Drawing.Point(12, 301);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(365, 218);
            this.summaryBox.TabIndex = 32;
            this.summaryBox.TabStop = false;
            this.summaryBox.Text = "Summary of charges";
            this.summaryBox.Visible = false;
            // 
            // summaryTotalDue
            // 
            this.summaryTotalDue.BackColor = System.Drawing.SystemColors.Control;
            this.summaryTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.summaryTotalDue.Location = new System.Drawing.Point(179, 170);
            this.summaryTotalDue.Name = "summaryTotalDue";
            this.summaryTotalDue.Padding = new System.Windows.Forms.Padding(1);
            this.summaryTotalDue.Size = new System.Drawing.Size(100, 23);
            this.summaryTotalDue.TabIndex = 35;
            // 
            // summaryResortFee
            // 
            this.summaryResortFee.BackColor = System.Drawing.SystemColors.Control;
            this.summaryResortFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.summaryResortFee.Location = new System.Drawing.Point(179, 137);
            this.summaryResortFee.Name = "summaryResortFee";
            this.summaryResortFee.Padding = new System.Windows.Forms.Padding(1);
            this.summaryResortFee.Size = new System.Drawing.Size(100, 23);
            this.summaryResortFee.TabIndex = 34;
            // 
            // summaryParking
            // 
            this.summaryParking.BackColor = System.Drawing.SystemColors.Control;
            this.summaryParking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.summaryParking.Location = new System.Drawing.Point(181, 98);
            this.summaryParking.Name = "summaryParking";
            this.summaryParking.Padding = new System.Windows.Forms.Padding(1);
            this.summaryParking.Size = new System.Drawing.Size(100, 23);
            this.summaryParking.TabIndex = 33;
            // 
            // summaryTax
            // 
            this.summaryTax.BackColor = System.Drawing.SystemColors.Control;
            this.summaryTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.summaryTax.Location = new System.Drawing.Point(181, 63);
            this.summaryTax.Name = "summaryTax";
            this.summaryTax.Padding = new System.Windows.Forms.Padding(1);
            this.summaryTax.Size = new System.Drawing.Size(100, 23);
            this.summaryTax.TabIndex = 32;
            // 
            // summaryRoom
            // 
            this.summaryRoom.BackColor = System.Drawing.SystemColors.Control;
            this.summaryRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.summaryRoom.Location = new System.Drawing.Point(181, 31);
            this.summaryRoom.Name = "summaryRoom";
            this.summaryRoom.Padding = new System.Windows.Forms.Padding(1);
            this.summaryRoom.Size = new System.Drawing.Size(100, 23);
            this.summaryRoom.TabIndex = 31;
            // 
            // childrenLabel
            // 
            this.childrenLabel.AutoSize = true;
            this.childrenLabel.Location = new System.Drawing.Point(22, 265);
            this.childrenLabel.Name = "childrenLabel";
            this.childrenLabel.Size = new System.Drawing.Size(97, 13);
            this.childrenLabel.TabIndex = 33;
            this.childrenLabel.Text = "Number of Children";
            // 
            // numOfChildren
            // 
            this.numOfChildren.Location = new System.Drawing.Point(217, 263);
            this.numOfChildren.Maximum = new decimal(new int[] {
            54,
            0,
            0,
            0});
            this.numOfChildren.Name = "numOfChildren";
            this.numOfChildren.Size = new System.Drawing.Size(44, 20);
            this.numOfChildren.TabIndex = 4;
            this.numOfChildren.ValueChanged += new System.EventHandler(this.numOfChildren_ValueChanged);
            // 
            // submitButton
            // 
            this.submitButton.AccessibleDescription = "";
            this.submitButton.AccessibleName = "";
            this.submitButton.Location = new System.Drawing.Point(383, 494);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "&Submit";
            this.toolTipSubmit.SetToolTip(this.submitButton, "Press to submit data.");
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // expirationLabel
            // 
            this.expirationLabel.AutoSize = true;
            this.expirationLabel.Location = new System.Drawing.Point(399, 406);
            this.expirationLabel.Name = "expirationLabel";
            this.expirationLabel.Size = new System.Drawing.Size(77, 13);
            this.expirationLabel.TabIndex = 35;
            this.expirationLabel.Text = "Expiration date";
            // 
            // expirationDate
            // 
            this.expirationDate.Location = new System.Drawing.Point(514, 399);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(68, 20);
            this.expirationDate.TabIndex = 10;
            // 
            // reservationProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 533);
            this.Controls.Add(this.expirationDate);
            this.Controls.Add(this.expirationLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numOfChildren);
            this.Controls.Add(this.childrenLabel);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.paymentEntry);
            this.Controls.Add(this.numOfNights);
            this.Controls.Add(this.numOfRooms);
            this.Controls.Add(this.reservationName);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.adultLabel);
            this.Controls.Add(this.numOfAdults);
            this.Controls.Add(this.nightsLabel);
            this.Controls.Add(this.numRoomLabel);
            this.Controls.Add(this.parkingChoice);
            this.Controls.Add(this.viewBox);
            this.Controls.Add(this.roomSizeGroup);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.exitButton);
            this.Name = "reservationProgram";
            this.Text = "Reservation Form";
            this.roomSizeGroup.ResumeLayout(false);
            this.roomSizeGroup.PerformLayout();
            this.viewBox.ResumeLayout(false);
            this.viewBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfNights)).EndInit();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.summaryBox.ResumeLayout(false);
            this.summaryBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfChildren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton queenRadio;
        private System.Windows.Forms.RadioButton kingRadio;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox roomSizeGroup;
        private System.Windows.Forms.RadioButton standardSizeRadio;
        private System.Windows.Forms.RadioButton atriumSizeRadio;
        private System.Windows.Forms.GroupBox viewBox;
        private System.Windows.Forms.CheckBox parkingChoice;
        private System.Windows.Forms.Label numRoomLabel;
        private System.Windows.Forms.Label nightsLabel;
        private System.Windows.Forms.NumericUpDown numOfAdults;
        private System.Windows.Forms.Label adultLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.TextBox reservationName;
        private System.Windows.Forms.TrackBar numOfRooms;
        private System.Windows.Forms.TrackBar numOfNights;
        private System.Windows.Forms.MaskedTextBox paymentEntry;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RadioButton payMaster;
        private System.Windows.Forms.RadioButton payAmerican;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.Label roomNameSum;
        private System.Windows.Forms.Label taxNameSum;
        private System.Windows.Forms.Label parkingNameSum;
        private System.Windows.Forms.Label resortNameSum;
        private System.Windows.Forms.Label totalNameSum;
        private System.Windows.Forms.GroupBox summaryBox;
        private System.Windows.Forms.Label summaryRoom;
        private System.Windows.Forms.Label summaryTotalDue;
        private System.Windows.Forms.Label summaryResortFee;
        private System.Windows.Forms.Label summaryParking;
        private System.Windows.Forms.Label summaryTax;
        private System.Windows.Forms.Label childrenLabel;
        private System.Windows.Forms.NumericUpDown numOfChildren;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label expirationLabel;
        private System.Windows.Forms.MaskedTextBox expirationDate;
        private System.Windows.Forms.RadioButton payVisa;
        private System.Windows.Forms.RadioButton payDiscover;
        private System.Windows.Forms.ToolTip toolTipSubmit;
        private System.Windows.Forms.ToolTip toolTipCancel;
        private System.Windows.Forms.ToolTip exitToolTip;
    }
}

