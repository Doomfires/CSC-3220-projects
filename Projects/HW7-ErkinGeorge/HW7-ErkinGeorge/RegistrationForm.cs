using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HW7_ErkinGeorge
{
    public partial class RegistrationForm : Form
    {
        public Registrant user = new Registrant();
        int overAlltotalCost;

        //Checks if the 4 radio buttons have been selected
        bool eCommerce = false;
        bool cloud = false;
        bool perl = false;
        bool network = false;
        bool keynote = false;
        bool conference = false;

        public RegistrationForm()
        {
            InitializeComponent();
            if (conferenceRegCheckbox.Checked != true)
            {
                keyNoteCheckBox.Enabled = false;
            }
        }   

        public void createRegistrationButton_Click(object sender, EventArgs e)
        {
            //Forces user to choose something
            if(conferenceRegCheckbox.Checked != true && radioButtonCloud.Checked != true  &&
                radioButtonEcommerce.Checked != true && radioButtonNetwork.Checked != true && radioButtonPerl.Checked != true)
            {
                MessageBox.Show("Please selecst one of the Preconference Registration choices, or just the Conference choice, or both as you require");
                return;
            }
            int totalCost = 0;

            if (radioButtonEcommerce.Checked == true)
            {
                totalCost += 150;
                eCommerce = true;
            }
            else if(radioButtonCloud.Checked == true)
            {
                totalCost += 295;
                cloud = true;
            }
            else if(radioButtonPerl.Checked == true)
            {
                totalCost += 195;
                perl = true;
            }
            else if(radioButtonNetwork.Checked == true)
            {
                totalCost += 350;
                network = true;
            }
            if(keyNoteCheckBox.Checked == true)
            {
                totalCost += 30;
                keynote = true;
            }
            if(conferenceRegCheckbox.Checked == true)
            {
                conference = true;
                totalCost += 495;
            }
            overAlltotalCost = totalCost;

            //pulls data from form into the object
            user.Name = regFormNameTtxbox.Text;
            user.Company = regFormCompTxtbox.Text;
            user.City = regFormCityTxtbox.Text;
            user.Email = regFormEmailTxtbox.Text;
            user.Phone = regFormMaskedPhone.Text;
            int zip;
            if (regFormZip.Text != "")
            {
                zip = int.Parse(regFormZip.Text);
            }
            else
            {
                zip = 0;
            }

            string state = stateListComboBox.Text;
            user.Zip = zip;
            user.State = state;    
        }

        private void conferenceFinishBut_Click(object sender, EventArgs e)
        {
            ReceiptForm receipt = new ReceiptForm();
            receipt.customer = user;
            //change cost labels here
            //These also set the workshop charges label to visible
            if(cloud)
            {
                receipt.workshopCharges.Text = "Workshop Charges: $295";
                receipt.workshopCharges.Visible = true;
            }
            if(network)
            {
                receipt.workshopCharges.Text = "Workshop Charges: $350";
                receipt.workshopCharges.Visible = true;
            }
            if(keynote)
            {
                receipt.DinerChargeslabel.Text = "Dinner Charges: $30";
                receipt.DinerChargeslabel.Visible = true;
            }
            if(perl)
            {

                receipt.workshopCharges.Text = "Workshop Charges: $195";
                receipt.workshopCharges.Visible = true;
            }
            if(eCommerce)
            {
                receipt.workshopCharges.Text = "Workshop Charges: $150";
                receipt.workshopCharges.Visible = true;
            }

            if(conference)
            {
                receipt.ConferenceChargesLabel.Text = "Conference Charges: $495";
                receipt.ConferenceChargesLabel.Visible = true;
            }

            receipt.totalChargesLabel.Text = "Total Charges: $" + overAlltotalCost.ToString();
            receipt.ShowDialog();
        }

        private void conferenceBackToMainbut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conferenceRegCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (conferenceRegCheckbox.Checked != true)
            {
                keyNoteCheckBox.Enabled = false;
                keyNoteCheckBox.Checked = false;
            }
            else
            {
                keyNoteCheckBox.Enabled = true;
            }
        }
    }
}
