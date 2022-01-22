using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FactuurApp
{
    public partial class MainForm : Form
    {
        public List<Invoice> invoiceList = new();
        public MainForm()
        {
            InitializeComponent();

            Database.MakeConnection();

            customerIdLabel.Text = string.Empty;
            customerNameLabel.Text = string.Empty;

            if (Database.CheckConnection() == true)
            {
                statusLabel.Text = "Verbonden";
                statusLabel.ForeColor = Color.FromArgb(0, 175, 0);

                invoiceList = Database.GetAllInvoices();
                ShowInvoices();
            }
            else
            {
                statusLabel.Text = "Niet verbonden";
                statusLabel.ForeColor = Color.FromArgb(175, 0, 0);
            }
        }

        //==================
        // METHODS
        //==================

        private void ShowInvoices()
        {
            foreach (Invoice invoice in invoiceList)
            {
                double difference = Math.Round((invoice.PaymentTerm - DateTime.Now).TotalDays);
                string paymentTerm = string.Format("Binnen {0} dagen", difference);

                invoicesGridView.Rows.Add(
                    invoice.Id,
                    invoice.Company.Id,
                    invoice.PaymentMethod.Method,
                    paymentTerm,
                    invoice.PriceExclusive(),
                    invoice.VATPrice,
                    invoice.TotalPrice,
                    invoice.CreatedAt);
            }
        }

        //==================
        // EVENT TRIGGERS
        //==================
        private void invoicesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = int.Parse(invoicesGridView.CurrentRow.Cells[0].Value.ToString());
            Invoice invoice = invoiceList.Single(i => i.Id == selectedRow);

            InvoiceDetailForm invoiceDetailForm = new();

            invoiceDetailForm.SetInvoice(invoice);

            invoiceDetailForm.ShowDialog();
        }

        //To do: optimize query by searching on index in CombBox
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = searchTextBox.Text;


            if (searchOptionsComboBox.SelectedItem == null)
            {
                MessageBox.Show("Er is geen zoek optie geselecteerd!");
                return;
            }
            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Zoekveld is leeg!");
                return;
            }

            invoicesGridView.Rows.Clear();
            invoicesGridView.Refresh();
        }

        private void invoicesGridView_MouseClick(object sender, MouseEventArgs e)
        {
            //Always select the value from 'customerId' column (second column)
            int selectedRow = int.Parse(invoicesGridView.CurrentRow.Cells[1].Value.ToString());
            Invoice invoice = invoiceList.Where(i => i.Company.Id == selectedRow).First();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new();

            customerForm.ShowDialog();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new();

            invoiceForm.ShowDialog();
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new();

            taskForm.ShowDialog();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new();

            companyForm.ShowDialog();
        }
    }
}
