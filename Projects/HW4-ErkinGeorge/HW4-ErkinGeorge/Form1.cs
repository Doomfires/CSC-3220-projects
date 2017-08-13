using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HW4_ErkinGeorge
{
    public partial class HospitalProgram : Form
    {

        //starts the program
        public HospitalProgram()
        {
            InitializeComponent();
            this.resetFunction();
        }

        //Variables for arithmetic for program
        int numberOfDays; //Numbers of days in hospital
        double medicationCost; //cost of medication
        double surgicalCost; //cost of surgery
        double labCost; //cost of lab tests
        double physicalCost; //cost of physical test
        double chargePerDay = 350; //Charge per day

        //exits the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            //this.resetFunction(); //resets all data to prevent error messages from incomplete forms, do this
            
            this.Close();
        }


        //
        private void resetButton_Click(object sender, EventArgs e)
        {
            outputBox.Visible = false;
            nameTextbox.Focus();
            this.resetFunction();
        }


        //
        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutSolution1 aboutBox = new AboutSolution1();
            aboutBox.Show();//rename this, and set the text

            if (aboutBox.Focus() == false)
            {
                nameTextbox.Focus();
                aboutBox.Focus();
            }
        }

        //
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //number of days, required
            try
            {
                if (daysInHospitalTextbox.Text == "")
                {
                    MessageBox.Show("Please enter a numeric integer value into the Days Charges Textbox, without the $ symbol.");
                    daysInHospitalTextbox.Focus();
                    return;
                }
                //int value ensures that full days are entered
                numberOfDays = int.Parse(daysInHospitalTextbox.Text);
               if(numberOfDays <= 0)
                {
                    MessageBox.Show("Please enter a value greater than zero.");
                    daysInHospitalTextbox.Clear();
                    daysInHospitalTextbox.Focus();
                    return;
                }
            }
            //catches invalid values for days
            catch
            {
                MessageBox.Show("Please enter a numeric value into the Days in Hospital Textbox.");
                daysInHospitalTextbox.Clear();
                daysInHospitalTextbox.Focus();
                return;
            }

            //medication, required
            //statement to insure that this field is not blank
            try
            {
                if (medicalChargesTextbox.Text == "")
                {
                    MessageBox.Show("Please enter a numeric value into the Medical Charges Textbox, without the $ symbol.");
                    medicalChargesTextbox.Focus();
                    return;
                }
                if (medicalChargesTextbox.Text[0] == '$' && medicalChargesTextbox.Text.Length > 1)//bug here?
                {
                    //Removes not needed $ symbol if placed in text
                    medicalChargesTextbox.Text = medicalChargesTextbox.Text.Remove(0, 1);
                }
                medicationCost = double.Parse(medicalChargesTextbox.Text);
                if(medicationCost <= 0)
                {
                    MessageBox.Show("Please enter a value greater than zero");
                    medicalChargesTextbox.Focus();
                    medicalChargesTextbox.Clear();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a numeric value into the Medical Charges Textbox, without the $ symbol.");
                medicalChargesTextbox.Focus();
                medicalChargesTextbox.Clear();
                return;
            }

            //surgical charges, not needed
            
            try
            {
                if (surgicalFeesTextbox.Text[0] == '$' && surgicalFeesTextbox.Text.Length > 1)
                {
                    surgicalFeesTextbox.Text = surgicalFeesTextbox.Text.Remove(0, 1);
                }
                else
                {//sets to defaults if there is no input
                    if (surgicalFeesTextbox.Text == "")
                    {
                        surgicalFeesTextbox.Text = "0";
                        surgicalCost = 0;
                    }
                }

                surgicalCost = double.Parse(surgicalFeesTextbox.Text);
                if(surgicalCost < 0)//catches less than zero issues
                {
                    surgicalFeesTextbox.Text = "0";
                    surgicalCost = 0;
                }
            }
            catch//catches nonnumeric issues
            {
                surgicalFeesTextbox.Text = "0";
                surgicalCost = 0;
            }

            //lab charges, required, greater than or equal to zero
            try
            {
                if (labFeesTextbox.Text[0] == '$' && labFeesTextbox.Text.Length > 1)
                {
                    labFeesTextbox.Text = labFeesTextbox.Text.Remove(0, 1);
                }
                if (labFeesTextbox.Text == "")
                {
                    MessageBox.Show("Please enter a numeric value into the Lab Charges Textbox, without the $ symbol.");
                    labFeesTextbox.Focus();
                    labFeesTextbox.Clear();
                    return;
                }
                labCost = double.Parse(labFeesTextbox.Text);
                if(labCost < 0)
                {
                    MessageBox.Show("Please enter a value that is greater than zero into the Lab Charges Texbox.");
                    labFeesTextbox.Focus();
                    labFeesTextbox.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a numeric value into the lab Charges Textbox, without the $ symbol");
                labFeesTextbox.Focus();
                labFeesTextbox.Clear();
                return;
            }

            //physical charges, not needed
            if(physicalChargesTextbox.Text == "")
            {
                physicalChargesTextbox.Text = "0";
                physicalCost = 0;
                
            }
            try
            {
                if (physicalChargesTextbox.Text[0] == '$' && physicalChargesTextbox.Text.Length > 1)
                {
                    physicalChargesTextbox.Text = physicalChargesTextbox.Text.Remove(0, 1);
                }
                physicalCost = double.Parse(physicalChargesTextbox.Text);
                if(physicalCost < 0)
                {
                    physicalChargesTextbox.Text = "0";
                    physicalCost = 0;
                }
            }
            catch
            {
                physicalChargesTextbox.Text = "0";
                physicalCost = 0;
            }

            //Make the output visible
            outputBox.Visible = true;

            //validate this math with checks
            //daily chargeoutput
            try
            {
                double totalDailyCharge = chargePerDay * numberOfDays;
                dailyChargeOutput.Text = totalDailyCharge.ToString("c");

                //sum of medication, surgical, lab and rehabilitation charges
                double extraCosts = medicationCost + surgicalCost + labCost + physicalCost;
                sumOfsomechargesOutput.Text = extraCosts.ToString("c");

                //total charges computations
                double totalCosts = extraCosts + totalDailyCharge;
                totalChargesOutput.Text = totalCosts.ToString("c");

                //Average daily bill
                double averageBill = totalCosts / numberOfDays;
                averageDailyOutput.Text = averageBill.ToString("c");
            }
            catch
            {
                MessageBox.Show("Please enter a value greater than zero for number of days.");
                daysInHospitalTextbox.Focus();
            }

        }

        //this is the manual setting of the values
        private void resetFunction()
        {
            //Resets the textboxes to null states
            nameTextbox.Text = null;
            emailTextbox.Text = null;
            telephoneTextbox.Text = null;
            daysInHospitalTextbox.Text = null;
            medicalChargesTextbox.Text = null;
            surgicalFeesTextbox.Text = null;
            labFeesTextbox.Text = null;
            physicalChargesTextbox.Text = null;
            nameTextbox.Focus();
        }

        //Code that makes sure the name textbox is not empty//works
        //Checks Patient name
        private void nameTextbox_Validating(object sender, CancelEventArgs e)
        {
            //code not allowing for null data 
            if (nameTextbox.Text == "" && exitButton.Focus() != true) //WAIT< MAY BE BUGGGG  && exitButton.Focus() != true
            {
                MessageBox.Show("Please enter a name.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
       
        //Code that makes sure the email textbox is not empty//works?
        //Checks patient email
        private void emailTextbox_Validating(object sender, CancelEventArgs e)
        {
            string temp1 = emailTextbox.Text;
            Regex validate = new Regex(@"^(([\S]{1,})[\@]([\w]{1,})[\.]([\w]{3}))$");
            bool success = validate.IsMatch(temp1);

            if (success)
                e.Cancel = false;
            else
            {
                MessageBox.Show("Please enter an email in the format: name@provider.domain");
                e.Cancel = true;
            }
        }
        //Code that makes sure the user inputs a formatted string if one is put in
        //Checks Patient phone/works
        private void telephoneTextbox_Validating(object sender, CancelEventArgs e)
        {
            Regex validate = new Regex(@"^(([0-9]{3})[\.]([0-9]{3})[\.]([0-9]{4}))$");
            string temp = telephoneTextbox.Text;
            //maybe try storing it in a string first?
            bool success = validate.IsMatch(temp);

            if (success)
                e.Cancel = false;
            else
            {
                //this is the first error box i get, which means
                MessageBox.Show("Please enter a number in the format: xxx.xxx.xxxx");
                e.Cancel = true;
            }
        }

    }
}