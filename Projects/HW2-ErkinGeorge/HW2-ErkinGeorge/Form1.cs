using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_ErkinGeorge
{
    public partial class calculatorApp : Form
    {
        //Temp variables to do calcuations with
        decimal initialChecking, depositChecking, withdrawChecking, endChecking;
        decimal initialSavings, depositSavings, withdrawSavings, endSavings;
        //Variables to hold the decimal values for end values
        decimal gainOrLoss;
        decimal totalBeg;
        decimal totalEnd;

        public calculatorApp()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void balanceShow_Click(object sender, EventArgs e)
        {
            accountsInfo.Show();

            //converts the checkings data
            initialChecking = decimal.Parse(checkingStart.Text); //Initial checking money
            depositChecking = decimal.Parse(checkingDeposit.Text);
            withdrawChecking = decimal.Parse(checkingWithdraw.Text);
            //endChecking = decimal.Parse(checkingBalance.Text);

            //converts the savings data
            initialSavings = decimal.Parse(savingsStart.Text); //Initial savings money
            depositSavings = decimal.Parse(savingsDeposit.Text);
            withdrawSavings = decimal.Parse(savingsWithdraw.Text);
            //endSavings = decimal.Parse(savingsBalance.Text);

            //Proccess the checking and saving data
            endChecking = initialChecking + depositChecking - withdrawChecking;
            endSavings = initialSavings + depositSavings - withdrawSavings;

            //Adds up the numbers
            totalBeg = initialChecking + initialSavings;
            totalEnd = endChecking + endSavings;
            gainOrLoss = totalEnd - totalBeg;

            //Turns the decimals into strings
            string tempBeg = totalBeg.ToString("c");
            string tempEnd = totalEnd.ToString("c");
            string profitOrNot = gainOrLoss.ToString("c");
            accountsInfo.Text = "Total Beginning  " + tempBeg + "\n" + "Total End  " + tempEnd + "\n" + "Gain(loss)  " + profitOrNot;

            //Outputs the actual values to the text box
            checkingBalance.Text = endChecking.ToString("c");
            savingsBalance.Text = endSavings.ToString("c");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Hides the label
            accountsInfo.Hide();
            //clears the checking information
            checkingStart.Text = "0.00";
            checkingDeposit.Text = "0.00";
            checkingWithdraw.Text = "0.00";
            checkingBalance.Text = "";
            //clears the savings information
            savingsStart.Text = "0.00";
            savingsDeposit.Text = "0.00";
            savingsWithdraw.Text = "0.00";
            savingsBalance.Text = "";
            //clears the name and date box
            nameTextbox.Clear();
            activityTextbox.Clear();
            //Sets the focus back
            nameTextbox.Select();
          
        } 
    }
}
