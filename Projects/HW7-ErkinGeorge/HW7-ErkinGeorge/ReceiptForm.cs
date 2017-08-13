using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_ErkinGeorge
{
    public partial class ReceiptForm : Form
    {
        public Registrant customer = new Registrant();
        public int costs;

        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void receiptFormSubmitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            registrantNameLabel.Text = "Registrant name: " + customer.Name;
            companyNameLabel.Text = "Company: " + customer.Company;
            cityStateLabel.Text = "City: " + customer.cityState;
            phoneLabel.Text = "Phone: " + customer.Phone;
            emailLabel.Text = "Email: " + customer.Email;   
        }
    }
}
