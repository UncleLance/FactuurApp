using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactuurApp
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();

            customerStatusLabel.Text = "Voeg nieuw klant toe";
            this.Text = "Nieuwe klant";
        }

        private void customerSubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerFirstNameTextBox.Text)   || 
                string.IsNullOrEmpty(customerLastNameTextBox.Text)    ||
                string.IsNullOrEmpty(customerPhoneNumberTextBox.Text) ||
                string.IsNullOrEmpty(customerEmailTextBox.Text))
            {
                MessageBox.Show("Een van de velden zijn leeg!");
                return;
            }

            string insertion = string.IsNullOrEmpty(customerInsertionTextBox.Text) ? null : customerInsertionTextBox.Text;

            Customer newCustomer = new();
            newCustomer.FirstName = customerFirstNameTextBox.Text;
            newCustomer.Insertion = insertion;
            newCustomer.LastName = customerLastNameTextBox.Text;
            newCustomer.PhoneNumber = customerPhoneNumberTextBox.Text;
            newCustomer.EmailAddress = customerEmailTextBox.Text;

            Database.AddCustomer(newCustomer);

            Close();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            customerToolTip.SetToolTip(label2, "*Mag leeg zijn.");
        }
    }
}
