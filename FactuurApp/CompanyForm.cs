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
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }
        private void CompanyForm_Load(object sender, EventArgs e)
        {
            this.Text = "Nieuw bedrijf";
            companyStatusLabel.Text = "Voeg nieuw bedrijf toe";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(companyNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(companyAddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(companyPostalCodeTextBox.Text) ||
                string.IsNullOrWhiteSpace(companyCityTextBox.Text))
            {
                MessageBox.Show("Een van de verplichte velden is leeg!");
                return;
            }

            Company company = new()
            {
                CompanyName = companyNameTextBox.Text,
                Address = companyAddressTextBox.Text,
                PostalCode = companyPostalCodeTextBox.Text,
                City = companyCityTextBox.Text,
                Country = companyCountryTextBox.Text,
                ContactPerson = companyContactPersonTextBox.Text,
                PhoneNumber = companyPhoneNumberTextBox.Text,
                EmailAddress = companyEmailAddressTextBox.Text
            };

            Database.AddCompany(company);

            Close();
        }
    }
}
