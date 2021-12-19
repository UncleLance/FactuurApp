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
    public partial class InvoiceForm : Form
    {
        private Invoice invoice = new Invoice();
        
        private List<Customer> customersList = new List<Customer>();
        private List<Task> tasksList = new List<Task>();

        private Customer customer = new Customer();
        private DateTime paymentTerm;
        private decimal totalPriceVATExlusive = 0M;
        private decimal priceVAT = 0M;
        private decimal totalPriceVATInclusive = 0M;
        public InvoiceForm()
        {
            InitializeComponent();

            taskDeleteButton.Enabled = false;
            taskSubmitButton.Enabled = false;

            Database.MakeConnection();

            if (Database.CheckConnection())
            {
                customersList = Database.GetAllCustomers();
                tasksList = Database.GetAllTasks();

                tasksComboBox.DataSource = tasksList;
                tasksComboBox.DisplayMember = "Description";
                tasksComboBox.ValueMember = "Id";

                tasksComboBox.SelectedIndex = -1;

                if (invoice.Id > 0)
                {
                    this.Text = "Nieuw factuur";

                    foreach (Customer customer in customersList)
                    {
                        string fullName = customer.Insertion != null ? string.Format("{0} {1} {2}", customer.FirstName, customer.Insertion, customer.LastName) :
                            string.Format("{0} {1}", customer.FirstName, customer.LastName);

                        customersComboBox.Items.Add(string.Format("{0} - {1}", customer.Id, fullName));
                    }


                    priceVATExclusiveLabel.Text = "€ 0.00";
                    priceVATLabel.Text = "€ 0.00";
                    priceVATInclusiveLabel.Text = "€ 0.00";

                    paymentTermMonthCalendar.TodayDate = DateTime.Now;
                }
                else
                {
                    this.Text = string.Format("Factuur #{0}", invoice.Id);

                    priceVATExclusiveLabel.Text = string.Format("€ {0}", invoice.TotalPrice);
                    priceVATLabel.Text = string.Format("€ {0}", invoice.VATPrice);
                    priceVATInclusiveLabel.Text = string.Format("€ {0}", (invoice.TotalPrice + invoice.VATPrice));

                    customer = invoice.Customer;
                    if(customer == null)
                    {
                        MessageBox.Show("Klant is leeg");
                        return;
                    }

                    string fullName = customer.Insertion != null ? 
                    string.Format("{0} {1} {2}", customer.FirstName, customer.Insertion, customer.LastName) :
                    string.Format("{0} {1}", customer.FirstName, customer.LastName);

                    customersComboBox.Text = string.Format("{0} - {1}", customer.Id, fullName);
                    customersComboBox.Enabled = false;

                    foreach(InvoiceRule rule in invoice.InvoiceRules)
                    {
                        invoiceRulesDataGridView.Rows.Add(rule.Amount, rule.Task.Description, rule.Task.Price, rule.Task.Price * rule.Amount);
                    }

                    paymentTermMonthCalendar.TodayDate = invoice.PaymentTerm;
                }


            }
            Database.CloseConnection();
        }

        public void SetInvoice(Invoice Invoice)
        {
            invoice = Invoice;
        }

        //private void CalculatePrices()
        //{
        //    //foreach (DataGridViewRow row in invoiceRulesDataGridView.SelectedRows)
        //    //{
        //    //    row.Cells.;
        //    //}

        //    for(int i = 0; i < invoiceRulesDataGridView.RowCount; i++)
        //    {
        //        decimal priceTask = decimal.Parse(invoiceRulesDataGridView.Rows[i].Cells[3].Value.ToString());
        //        totalPriceVATExlusive += priceTask;
        //    }
        //}

        private void SetPriceLabels()
        {
            priceVATExclusiveLabel.Text = string.Format("€ {0}", Math.Round(totalPriceVATExlusive, 2));
            priceVATLabel.Text = string.Format("€ {0}", Math.Round(priceVAT, 2));
            priceVATInclusiveLabel.Text = string.Format("€ {0}", Math.Round(totalPriceVATInclusive, 2));
        }

        private void paymentTermMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            paymentTerm = paymentTermMonthCalendar.SelectionRange.Start;
        }

        private void customersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            customer = customersList.Where(customer => customer.Id == (customersComboBox.SelectedIndex + 1)).First();
        }

        private void invoiceRulesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //invoiceRulesDataGridView.Rows.Remove(invoiceRulesDataGridView)
        }

        private void invoiceRulesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //If a row (or a cell from a row) is selected, enable the delete button, else disable it
            if(invoiceRulesDataGridView.SelectedCells.Count > 1)
            {
                taskDeleteButton.Enabled = true;
            }
            else
            {
                taskDeleteButton.Enabled = false;
            }
        }

        private void taskDeleteButton_Click(object sender, EventArgs e)
        {
            if (invoiceRulesDataGridView.SelectedCells.Count > 1)
            {
                foreach(DataGridViewRow row in invoiceRulesDataGridView.SelectedRows)
                {
                    decimal priceTask = decimal.Parse(row.Cells[3].Value.ToString());

                    totalPriceVATExlusive -= priceTask;
                    priceVAT -= priceTask * 0.21M;
                    totalPriceVATInclusive = totalPriceVATExlusive + priceVAT;

                    invoiceRulesDataGridView.Rows.Remove(row);
                }

                SetPriceLabels();
            }
        }

        private void taskSubmitButton_Click(object sender, EventArgs e)
        {
            if(taskAmountNumericUpDown.Value < 1)
            {
                MessageBox.Show("Aantal mag niet kleiner dan 1 zijn!");
                return;
            }
            
            Task task = (Task)tasksComboBox.SelectedItem;

            decimal amount = Math.Round(taskAmountNumericUpDown.Value);

            invoiceRulesDataGridView.Rows.Add(amount, task.Description, task.Price, amount * task.Price);

            totalPriceVATExlusive += (amount * task.Price);
            priceVAT += (amount * task.Price) * 0.21M;
            totalPriceVATInclusive = totalPriceVATExlusive + priceVAT;

            SetPriceLabels();

            taskAmountNumericUpDown.Value = taskAmountNumericUpDown.Minimum;
            tasksComboBox.SelectedIndex = -1;
        }

        private void tasksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tasksComboBox.SelectedItem != null)
            {
                taskSubmitButton.Enabled = true;
            }
            else
            {
                taskSubmitButton.Enabled = false;
            }
        }
    }
}
