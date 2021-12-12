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
        public List<Invoice> invoiceList = new List<Invoice>();
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
                    invoice.Customer.Id,
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

            InvoiceDetailForm invoiceDetailForm = new InvoiceDetailForm();

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

            if(searchOptionsComboBox.SelectedItem.ToString() != "Factuur datum")
            {
                int searchId = int.Parse(searchQuery);

                if(searchOptionsComboBox.SelectedItem.ToString() == "Factuur nummer")
                {
                    try
                    {
                        Invoice invoice = invoiceList.First(s => s.Id == searchId);
                        invoicesGridView.Rows.Add(
                                        invoice.Id,
                                        invoice.Customer.Id,
                                        invoice.PaymentMethod,
                                        invoice.PaymentTerm,
                                        invoice.PriceExclusive(),
                                        invoice.VATPrice,
                                        invoice.TotalPrice,
                                        invoice.CreatedAt);
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("Factuur nummer niet gevonden!");
                        ShowInvoices();
                    }
                }

                if(searchOptionsComboBox.SelectedItem.ToString() == "Klant nummer")
                {
                    try
                    {
                        Invoice invoice = invoiceList.First(s => s.Customer.Id == searchId);
                        invoicesGridView.Rows.Add(
                                        invoice.Id,
                                        invoice.Customer.Id,
                                        invoice.PaymentMethod,
                                        invoice.PaymentTerm,
                                        invoice.PriceExclusive(),
                                        invoice.VATPrice,
                                        invoice.TotalPrice,
                                        invoice.CreatedAt);
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("Klant nummer niet gevonden!");
                        ShowInvoices();
                    }
                }
            }
        }

        private void invoicesGridView_MouseClick(object sender, MouseEventArgs e)
        {
            //Always select the value from 'customerId' column (second column)
            int selectedRow = int.Parse(invoicesGridView.CurrentRow.Cells[1].Value.ToString());
            Invoice invoice = invoiceList.Where(i => i.Customer.Id == selectedRow).First();

            customerIdLabel.Text = invoice.Customer.Id.ToString();
            if (invoice.Customer.Insertion != null)
            {
                customerNameLabel.Text = string.Format("{0} {1} {2}", invoice.Customer.FirstName,
                                                              invoice.Customer.Insertion,
                                                              invoice.Customer.LastName);
            }
            else
            {
                customerNameLabel.Text = string.Format("{0} {1}", invoice.Customer.FirstName,
                                                              invoice.Customer.LastName);
            } 
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();

            customerForm.ShowDialog();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();

            invoiceForm.ShowDialog();
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();

            taskForm.ShowDialog();
        }
    }
}
