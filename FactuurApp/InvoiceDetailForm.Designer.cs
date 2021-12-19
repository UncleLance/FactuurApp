
namespace FactuurApp
{
    partial class InvoiceDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paymentTermLabel = new System.Windows.Forms.Label();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceDateLabel = new System.Windows.Forms.Label();
            this.invoiceIdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.invoiceRulesDataGridView = new System.Windows.Forms.DataGridView();
            this.taskAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskPriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailInvoiceMenuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.priceVATExclusiveLabel = new System.Windows.Forms.Label();
            this.priceVATLabel = new System.Windows.Forms.Label();
            this.priceVATInclusiveLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRulesDataGridView)).BeginInit();
            this.detailInvoiceMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paymentTermLabel);
            this.groupBox1.Controls.Add(this.paymentMethodLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.invoiceDateLabel);
            this.groupBox1.Controls.Add(this.invoiceIdLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factuur gegevens";
            // 
            // paymentTermLabel
            // 
            this.paymentTermLabel.AutoSize = true;
            this.paymentTermLabel.Location = new System.Drawing.Point(95, 100);
            this.paymentTermLabel.Name = "paymentTermLabel";
            this.paymentTermLabel.Size = new System.Drawing.Size(25, 13);
            this.paymentTermLabel.TabIndex = 11;
            this.paymentTermLabel.Text = "<?>";
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.Location = new System.Drawing.Point(95, 75);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(25, 13);
            this.paymentMethodLabel.TabIndex = 10;
            this.paymentMethodLabel.Text = "<?>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Betaal termijn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Betaalwijze:";
            // 
            // invoiceDateLabel
            // 
            this.invoiceDateLabel.AutoSize = true;
            this.invoiceDateLabel.Location = new System.Drawing.Point(95, 50);
            this.invoiceDateLabel.Name = "invoiceDateLabel";
            this.invoiceDateLabel.Size = new System.Drawing.Size(25, 13);
            this.invoiceDateLabel.TabIndex = 7;
            this.invoiceDateLabel.Text = "<?>";
            // 
            // invoiceIdLabel
            // 
            this.invoiceIdLabel.AutoSize = true;
            this.invoiceIdLabel.Location = new System.Drawing.Point(95, 25);
            this.invoiceIdLabel.Name = "invoiceIdLabel";
            this.invoiceIdLabel.Size = new System.Drawing.Size(25, 13);
            this.invoiceIdLabel.TabIndex = 6;
            this.invoiceIdLabel.Text = "<?>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Factuurdatum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Factuurnummer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.emailAddressLabel);
            this.groupBox2.Controls.Add(this.phoneNumberLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.customerNameLabel);
            this.groupBox2.Controls.Add(this.customerIdLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(318, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 125);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Klant gegevens";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(95, 100);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(25, 13);
            this.emailAddressLabel.TabIndex = 11;
            this.emailAddressLabel.Text = "<?>";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(95, 75);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(25, 13);
            this.phoneNumberLabel.TabIndex = 10;
            this.phoneNumberLabel.Text = "<?>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefoonnummer:";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(95, 50);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(25, 13);
            this.customerNameLabel.TabIndex = 7;
            this.customerNameLabel.Text = "<?>";
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(95, 25);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(25, 13);
            this.customerIdLabel.TabIndex = 6;
            this.customerIdLabel.Text = "<?>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Klantnaam:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Klantnnummer:";
            // 
            // invoiceRulesDataGridView
            // 
            this.invoiceRulesDataGridView.AllowUserToAddRows = false;
            this.invoiceRulesDataGridView.AllowUserToDeleteRows = false;
            this.invoiceRulesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceRulesDataGridView.ColumnHeadersHeight = 34;
            this.invoiceRulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskAmount,
            this.taskDescription,
            this.taskPrice,
            this.taskPriceTotal});
            this.invoiceRulesDataGridView.Location = new System.Drawing.Point(12, 158);
            this.invoiceRulesDataGridView.Name = "invoiceRulesDataGridView";
            this.invoiceRulesDataGridView.ReadOnly = true;
            this.invoiceRulesDataGridView.Size = new System.Drawing.Size(727, 250);
            this.invoiceRulesDataGridView.TabIndex = 11;
            // 
            // taskAmount
            // 
            this.taskAmount.HeaderText = "Aantal";
            this.taskAmount.Name = "taskAmount";
            this.taskAmount.ReadOnly = true;
            // 
            // taskDescription
            // 
            this.taskDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taskDescription.HeaderText = "Omschrijving";
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.ReadOnly = true;
            // 
            // taskPrice
            // 
            this.taskPrice.HeaderText = "Prijs per eenheid";
            this.taskPrice.Name = "taskPrice";
            this.taskPrice.ReadOnly = true;
            // 
            // taskPriceTotal
            // 
            this.taskPriceTotal.HeaderText = "Totaal";
            this.taskPriceTotal.Name = "taskPriceTotal";
            this.taskPriceTotal.ReadOnly = true;
            // 
            // detailInvoiceMenuStrip
            // 
            this.detailInvoiceMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.detailInvoiceMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.detailInvoiceMenuStrip.Name = "detailInvoiceMenuStrip";
            this.detailInvoiceMenuStrip.Size = new System.Drawing.Size(751, 24);
            this.detailInvoiceMenuStrip.TabIndex = 12;
            this.detailInvoiceMenuStrip.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editInvoiceToolStripMenuItem,
            this.sendInvoiceToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.optionsToolStripMenuItem.Text = "Opties";
            // 
            // editInvoiceToolStripMenuItem
            // 
            this.editInvoiceToolStripMenuItem.Name = "editInvoiceToolStripMenuItem";
            this.editInvoiceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.editInvoiceToolStripMenuItem.Text = "Bewerk factuur";
            this.editInvoiceToolStripMenuItem.Click += new System.EventHandler(this.editInvoiceToolStripMenuItem_Click);
            // 
            // sendInvoiceToolStripMenuItem
            // 
            this.sendInvoiceToolStripMenuItem.Name = "sendInvoiceToolStripMenuItem";
            this.sendInvoiceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sendInvoiceToolStripMenuItem.Text = "Verstuur factuur";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(412, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Totaal excl. BTW";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(412, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "BTW";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(412, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Totaal incl. BTW";
            // 
            // priceVATExclusiveLabel
            // 
            this.priceVATExclusiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priceVATExclusiveLabel.AutoSize = true;
            this.priceVATExclusiveLabel.Location = new System.Drawing.Point(637, 425);
            this.priceVATExclusiveLabel.Name = "priceVATExclusiveLabel";
            this.priceVATExclusiveLabel.Size = new System.Drawing.Size(25, 13);
            this.priceVATExclusiveLabel.TabIndex = 16;
            this.priceVATExclusiveLabel.Text = "<?>";
            // 
            // priceVATLabel
            // 
            this.priceVATLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priceVATLabel.AutoSize = true;
            this.priceVATLabel.Location = new System.Drawing.Point(637, 450);
            this.priceVATLabel.Name = "priceVATLabel";
            this.priceVATLabel.Size = new System.Drawing.Size(25, 13);
            this.priceVATLabel.TabIndex = 17;
            this.priceVATLabel.Text = "<?>";
            // 
            // priceVATInclusiveLabel
            // 
            this.priceVATInclusiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priceVATInclusiveLabel.AutoSize = true;
            this.priceVATInclusiveLabel.Location = new System.Drawing.Point(637, 475);
            this.priceVATInclusiveLabel.Name = "priceVATInclusiveLabel";
            this.priceVATInclusiveLabel.Size = new System.Drawing.Size(25, 13);
            this.priceVATInclusiveLabel.TabIndex = 18;
            this.priceVATInclusiveLabel.Text = "<?>";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(635, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "________";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(696, 453);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "+";
            // 
            // InvoiceDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 511);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.priceVATInclusiveLabel);
            this.Controls.Add(this.priceVATLabel);
            this.Controls.Add(this.priceVATExclusiveLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.invoiceRulesDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.detailInvoiceMenuStrip);
            this.Controls.Add(this.label12);
            this.MainMenuStrip = this.detailInvoiceMenuStrip;
            this.Name = "InvoiceDetailForm";
            this.Text = "Factuur";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRulesDataGridView)).EndInit();
            this.detailInvoiceMenuStrip.ResumeLayout(false);
            this.detailInvoiceMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label invoiceDateLabel;
        private System.Windows.Forms.Label invoiceIdLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label paymentTermLabel;
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.DataGridView invoiceRulesDataGridView;
        private System.Windows.Forms.MenuStrip detailInvoiceMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskPriceTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label priceVATExclusiveLabel;
        private System.Windows.Forms.Label priceVATLabel;
        private System.Windows.Forms.Label priceVATInclusiveLabel;
        private System.Windows.Forms.ToolStripMenuItem editInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendInvoiceToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}