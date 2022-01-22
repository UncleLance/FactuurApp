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
    public partial class InvoiceDetailForm : Form
    {
        private Invoice invoice = new();
        private decimal totalPriceVATExlusive = 0M;
        private decimal priceVAT = 0M;
        private decimal totalPriceVATInclusive = 0M;

        public InvoiceDetailForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            this.Text += string.Format(" #{0}", invoice.Id);

            foreach(InvoiceRule rule in invoice.InvoiceRules)
            {
                totalPriceVATExlusive += rule.Task.Price;

                invoiceRulesDataGridView.Rows.Add(rule.Amount, rule.Task.Description, rule.Task.Price, rule.Task.Price * rule.Amount);
            }

            priceVAT = totalPriceVATExlusive * 0.21M;

            totalPriceVATInclusive = Math.Round(totalPriceVATExlusive + priceVAT, 2);

            LabelSetup();
        }

        private void LabelSetup()
        {
            invoiceIdLabel.Text = invoice.Id.ToString();
            invoiceDateLabel.Text = invoice.CreatedAt.ToString();
            paymentMethodLabel.Text = invoice.PaymentMethod.Method;

            double difference = Math.Round((invoice.PaymentTerm - DateTime.Now).TotalDays);
            paymentTermLabel.Text = string.Format("Binnen {0} dagen", difference);

            //customeridlabel.text = invoice.customer.id.tostring();
            //if (invoice.customer.insertion != null)
            //{
            //    customernamelabel.text = string.format("{0} {1} {2}", invoice.customer.firstname, invoice.customer.insertion, invoice.customer.lastname);
            //}
            //else
            //{
            //    customernamelabel.text = string.format("{0} {1}", invoice.customer.firstname, invoice.customer.lastname);
            //}
            //phonenumberlabel.text = invoice.customer.phonenumber;
            //emailaddresslabel.text = invoice.customer.emailaddress;

            priceVATExclusiveLabel.Text = string.Format("€ {0}", invoice.TotalPrice - invoice.VATPrice);
            priceVATLabel.Text = string.Format("€ {0}", invoice.VATPrice);
            priceVATInclusiveLabel.Text = string.Format("€ {0}", invoice.TotalPrice);
        }

        public void SetInvoice(Invoice Invoice)
        {
            invoice = Invoice;
        }

        private void editInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new();

            invoiceForm.SetInvoice(invoice);

            this.Close();

            invoiceForm.ShowDialog();
        }
    }
}
