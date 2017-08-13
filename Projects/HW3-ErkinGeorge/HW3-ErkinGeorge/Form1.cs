using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_ErkinGeorge
{
    public partial class reservationProgram : Form
    {
        public reservationProgram()
        {
            InitializeComponent();
        }

        //Set cost of the rooms
        private double standardQueenRoomFee = 284;
        private double standardKingRoomFee = 290;
        private double atriumQueenRoomFee = 325;
        private double atriumKingRoomFee = 350;

        //Set cost of daily parking
        private double parkingFee = 12.75;

        //Resort fee
        private double resortFee = 15;

        //Total due
        private double totalDue = 0;
        //Dynamic adjustment of values based on user selection

        //tracks number of people
        private int numOfPeople = 0;

        //Exits the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sets all values back to defaults
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Sets the name back to blank
            reservationName.Text = "";
            //Sets number of nights and rooms to defaults
            numOfNights.Value = 1;
            numOfRooms.Value = 1;
            //Sets the number of guests to defaults
            numOfAdults.Minimum = 1;
            numOfChildren.Minimum = 0;//makes sure it doesn't break
            numOfAdults.Value = 1;//
            numOfChildren.Value = 0;
            //Sets summary box labels to blank
            summaryParking.Text = "";
            summaryRoom.Text = "";
            summaryTax.Text = "";
            summaryTotalDue.Text = "";
            summaryResortFee.Text = "";

            //Hides the summary box
            summaryBox.Visible = false;

            //Sets the radio buttons to defaults
            standardSizeRadio.Checked = false;
            atriumSizeRadio.Checked = false;
            kingRadio.Checked = false;
            queenRadio.Checked = false;

            //Sets the payment radio buttons to defaults
            payAmerican.Checked = false;
            payDiscover.Checked = false;
            payMaster.Checked = false;
            payVisa.Checked = false;

            //Sets payment boxes to empty
            expirationDate.Clear();
            paymentEntry.Clear();

            //Clears daily parking 
            parkingChoice.Checked = false;

            //Clears credit card information
            paymentEntry.Text = "";
            paymentEntry.Mask = "0000-0000-0000-0000";
            expirationDate.Mask = "00/0000";

            //Resets focus
            reservationName.Select();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //if statement that makes sure all boxes have been checked that must be checked
            if(reservationName.Text != "" && (standardSizeRadio.Checked ||atriumSizeRadio.Checked) && 
                (queenRadio.Checked || kingRadio.Checked) && 
                (payAmerican.Checked || payMaster.Checked || payDiscover.Checked || payVisa.Checked) && paymentEntry.Text != "" && expirationDate.Text != "")

            {
                //Calculates price for standard room, Queen size
                if (standardSizeRadio.Checked && queenRadio.Checked)
                {
                    totalDue = standardQueenRoomFee * numOfRooms.Value * numOfNights.Value;
                }
                //Calculates price for an atrium room, Queen size
                else if (atriumSizeRadio.Checked && queenRadio.Checked)
                {
                    totalDue = atriumQueenRoomFee * numOfRooms.Value * numOfNights.Value;
                }
                //Calculates price for a standard room, King size
                else if (standardSizeRadio.Checked && kingRadio.Checked)
                {
                    totalDue = standardKingRoomFee * numOfRooms.Value * numOfNights.Value;
                }
                //Calculates price for an atrium room, King size
                else if (atriumSizeRadio.Checked && kingRadio.Checked)
                {
                    totalDue = atriumKingRoomFee * numOfRooms.Value * numOfNights.Value;
                }

                //saves just room value before other calcuations start
                double roomValue = totalDue;

                //Adds in the tax
                double tax = totalDue * 0.15;

                //Adds in vehicle fee if needed
                if (parkingChoice.Checked)
                {
                    double parkingCost = parkingFee * numOfNights.Value;
                    totalDue = totalDue + parkingCost;
                    summaryParking.Text = "$" + parkingCost.ToString("n2");
                }

                //Calculates resort fee
                double totalResortFee = (resortFee * numOfRooms.Value) * numOfNights.Value;

                //final total fee
                totalDue = totalDue + totalResortFee + tax;

                //Makes box visible
                summaryBox.Visible = true;
                //Sets values inside of the labels
                summaryResortFee.Text = "$" + totalResortFee.ToString("n2");
                summaryTax.Text = "$" + tax.ToString("n2");
                summaryTotalDue.Text = "$" + totalDue.ToString("n2");
                summaryRoom.Text = "$" + roomValue.ToString("n2");
            }
            else
            {
                //Makes sure user enters all data
                MessageBox.Show("Please check that you have selected the required data, and that you have left nothing blank.");
            }        
        }

        //The lines below dynamically manage the data before it is submitted by the user
        //adjusts the number of kids and adults based on where the user clicks
        private void numOfRooms_Scroll(object sender, EventArgs e)
        {
            numOfPeople = numOfRooms.Value * 6;
            numOfAdults.Minimum = numOfRooms.Value;

            numOfAdults.Maximum = numOfPeople - numOfChildren.Value;
            numOfChildren.Maximum = numOfPeople - numOfAdults.Value;

        }
        //adjusts the number of kids and adults based on where the user clicks
        private void numOfAdults_ValueChanged(object sender, EventArgs e)
        {     
            numOfAdults.Maximum = numOfPeople - numOfChildren.Value;
            numOfChildren.Maximum = numOfPeople - numOfAdults.Value;

            numOfPeople = numOfRooms.Value * 6;
            numOfAdults.Minimum = numOfRooms.Value;
        }
        //adjusts the number of kids and adults based on where the user clicks
        private void numOfChildren_ValueChanged(object sender, EventArgs e)
        {
            numOfPeople = numOfRooms.Value * 6;
            numOfAdults.Minimum = numOfRooms.Value;

            numOfAdults.Maximum = numOfPeople - numOfChildren.Value;
            numOfChildren.Maximum = numOfPeople - numOfAdults.Value;
        }

        //Formats for an American credit card 
        private void payAmerican_CheckedChanged(object sender, EventArgs e)
        {
            paymentEntry.Text = "";
            paymentEntry.Mask = "3000-0000000-00000";
            expirationDate.Mask = "00/0000";
            paymentEntry.Select();
        }
        //Formats for a Master credit card
        private void payMaster_CheckedChanged(object sender, EventArgs e)
        {
            paymentEntry.Text = "";
            paymentEntry.Mask = "5000-0000-0000-0000";
            expirationDate.Mask = "00/0000";
            paymentEntry.Select();
        }
        //Formats for a Visa credit card
        private void payVisa_CheckedChanged(object sender, EventArgs e)
        {
            paymentEntry.Text = "";
            paymentEntry.Mask = "4000-0000-0000-0000";
            expirationDate.Mask = "00/0000";
            paymentEntry.Select();
        }
        //Formats for a Discover credit card
        private void payDiscover_CheckedChanged(object sender, EventArgs e)
        {
            paymentEntry.Text = "";
            paymentEntry.Mask = "6000-0000-0000-0000";
            expirationDate.Mask = "00/0000";
            paymentEntry.Select();
        }
    }
}
