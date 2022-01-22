
namespace FactuurApp
{
    partial class InvoiceForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.taskAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.taskSubmitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tasksComboBox = new System.Windows.Forms.ComboBox();
            this.taskDeleteButton = new System.Windows.Forms.Button();
            this.paymentTermMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.companiesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceRulesDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.invoiceSubmitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.priceVATInclusiveLabel = new System.Windows.Forms.Label();
            this.priceVATLabel = new System.Windows.Forms.Label();
            this.priceVATExclusiveLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.companyPostalCodeLabel = new System.Windows.Forms.Label();
            this.companyAddressLabel = new System.Windows.Forms.Label();
            this.companyIdLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.ruleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskPriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRulesDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.taskAmountNumericUpDown);
            this.groupBox1.Controls.Add(this.taskSubmitButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tasksComboBox);
            this.groupBox1.Location = new System.Drawing.Point(529, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 212);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taken";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Aantal:";
            // 
            // taskAmountNumericUpDown
            // 
            this.taskAmountNumericUpDown.Location = new System.Drawing.Point(219, 37);
            this.taskAmountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.taskAmountNumericUpDown.Name = "taskAmountNumericUpDown";
            this.taskAmountNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.taskAmountNumericUpDown.TabIndex = 26;
            this.taskAmountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // taskSubmitButton
            // 
            this.taskSubmitButton.Location = new System.Drawing.Point(9, 67);
            this.taskSubmitButton.Name = "taskSubmitButton";
            this.taskSubmitButton.Size = new System.Drawing.Size(100, 23);
            this.taskSubmitButton.TabIndex = 24;
            this.taskSubmitButton.Text = "Voeg taak toe";
            this.taskSubmitButton.UseVisualStyleBackColor = true;
            this.taskSubmitButton.Click += new System.EventHandler(this.taskSubmitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Taak:";
            // 
            // tasksComboBox
            // 
            this.tasksComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tasksComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tasksComboBox.FormattingEnabled = true;
            this.tasksComboBox.Location = new System.Drawing.Point(9, 36);
            this.tasksComboBox.Name = "tasksComboBox";
            this.tasksComboBox.Size = new System.Drawing.Size(197, 21);
            this.tasksComboBox.TabIndex = 22;
            this.tasksComboBox.SelectedIndexChanged += new System.EventHandler(this.tasksComboBox_SelectedIndexChanged);
            // 
            // taskDeleteButton
            // 
            this.taskDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDeleteButton.Location = new System.Drawing.Point(747, 230);
            this.taskDeleteButton.Name = "taskDeleteButton";
            this.taskDeleteButton.Size = new System.Drawing.Size(100, 23);
            this.taskDeleteButton.TabIndex = 25;
            this.taskDeleteButton.Text = "Verwijder uit lijst";
            this.taskDeleteButton.UseVisualStyleBackColor = true;
            this.taskDeleteButton.Click += new System.EventHandler(this.taskDeleteButton_Click);
            // 
            // paymentTermMonthCalendar
            // 
            this.paymentTermMonthCalendar.Location = new System.Drawing.Point(272, 36);
            this.paymentTermMonthCalendar.MaxSelectionCount = 1;
            this.paymentTermMonthCalendar.Name = "paymentTermMonthCalendar";
            this.paymentTermMonthCalendar.TabIndex = 14;
            this.paymentTermMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.paymentTermMonthCalendar_DateChanged);
            // 
            // companiesComboBox
            // 
            this.companiesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.companiesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.companiesComboBox.FormattingEnabled = true;
            this.companiesComboBox.Location = new System.Drawing.Point(9, 36);
            this.companiesComboBox.Name = "companiesComboBox";
            this.companiesComboBox.Size = new System.Drawing.Size(251, 21);
            this.companiesComboBox.TabIndex = 15;
            this.companiesComboBox.SelectedIndexChanged += new System.EventHandler(this.companiesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bedrijf:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bedrijfsgegevens";
            // 
            // invoiceRulesDataGridView
            // 
            this.invoiceRulesDataGridView.AllowUserToAddRows = false;
            this.invoiceRulesDataGridView.AllowUserToDeleteRows = false;
            this.invoiceRulesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceRulesDataGridView.ColumnHeadersHeight = 34;
            this.invoiceRulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ruleId,
            this.taskAmount,
            this.taskDescription,
            this.taskPrice,
            this.taskPriceTotal});
            this.invoiceRulesDataGridView.Location = new System.Drawing.Point(12, 259);
            this.invoiceRulesDataGridView.Name = "invoiceRulesDataGridView";
            this.invoiceRulesDataGridView.ReadOnly = true;
            this.invoiceRulesDataGridView.Size = new System.Drawing.Size(835, 283);
            this.invoiceRulesDataGridView.TabIndex = 19;
            this.invoiceRulesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceRulesDataGridView_CellClick);
            this.invoiceRulesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceRulesDataGridView_CellDoubleClick);
            this.invoiceRulesDataGridView.SelectionChanged += new System.EventHandler(this.invoiceRulesDataGridView_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Uiterste betaaldatum:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.companyIdLabel);
            this.groupBox2.Controls.Add(this.companyNameLabel);
            this.groupBox2.Controls.Add(this.companyAddressLabel);
            this.groupBox2.Controls.Add(this.companyPostalCodeLabel);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.companiesComboBox);
            this.groupBox2.Controls.Add(this.paymentTermMonthCalendar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 212);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factuur gegevens";
            // 
            // invoiceSubmitButton
            // 
            this.invoiceSubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceSubmitButton.Location = new System.Drawing.Point(772, 548);
            this.invoiceSubmitButton.Name = "invoiceSubmitButton";
            this.invoiceSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.invoiceSubmitButton.TabIndex = 28;
            this.invoiceSubmitButton.Text = "Opslaan";
            this.invoiceSubmitButton.UseVisualStyleBackColor = true;
            this.invoiceSubmitButton.Click += new System.EventHandler(this.invoiceSubmitButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(809, 609);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "+";
            // 
            // priceVATInclusiveLabel
            // 
            this.priceVATInclusiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priceVATInclusiveLabel.AutoSize = true;
            this.priceVATInclusiveLabel.Location = new System.Drawing.Point(751, 633);
            this.priceVATInclusiveLabel.Name = "priceVATInclusiveLabel";
            this.priceVATInclusiveLabel.Size = new System.Drawing.Size(25, 13);
            this.priceVATInclusiveLabel.TabIndex = 34;
            this.priceVATInclusiveLabel.Text = "<?>";
            // 
            // priceVATLabel
            // 
            this.priceVATLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priceVATLabel.AutoSize = true;
            this.priceVATLabel.Location = new System.Drawing.Point(751, 608);
            this.priceVATLabel.Name = "priceVATLabel";
            this.priceVATLabel.Size = new System.Drawing.Size(25, 13);
            this.priceVATLabel.TabIndex = 33;
            this.priceVATLabel.Text = "<?>";
            // 
            // priceVATExclusiveLabel
            // 
            this.priceVATExclusiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priceVATExclusiveLabel.AutoSize = true;
            this.priceVATExclusiveLabel.Location = new System.Drawing.Point(751, 583);
            this.priceVATExclusiveLabel.Name = "priceVATExclusiveLabel";
            this.priceVATExclusiveLabel.Size = new System.Drawing.Size(25, 13);
            this.priceVATExclusiveLabel.TabIndex = 32;
            this.priceVATExclusiveLabel.Text = "<?>";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(526, 633);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Totaal incl. BTW";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(526, 583);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Totaal excl. BTW";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(526, 608);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "BTW";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(748, 614);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nummer:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Naam:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Adres:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Postcode:";
            // 
            // companyPostalCodeLabel
            // 
            this.companyPostalCodeLabel.AutoSize = true;
            this.companyPostalCodeLabel.Location = new System.Drawing.Point(75, 147);
            this.companyPostalCodeLabel.Name = "companyPostalCodeLabel";
            this.companyPostalCodeLabel.Size = new System.Drawing.Size(25, 13);
            this.companyPostalCodeLabel.TabIndex = 26;
            this.companyPostalCodeLabel.Text = "<?>";
            // 
            // companyAddressLabel
            // 
            this.companyAddressLabel.AutoSize = true;
            this.companyAddressLabel.Location = new System.Drawing.Point(75, 127);
            this.companyAddressLabel.Name = "companyAddressLabel";
            this.companyAddressLabel.Size = new System.Drawing.Size(25, 13);
            this.companyAddressLabel.TabIndex = 27;
            this.companyAddressLabel.Text = "<?>";
            // 
            // companyIdLabel
            // 
            this.companyIdLabel.AutoSize = true;
            this.companyIdLabel.Location = new System.Drawing.Point(75, 87);
            this.companyIdLabel.Name = "companyIdLabel";
            this.companyIdLabel.Size = new System.Drawing.Size(25, 13);
            this.companyIdLabel.TabIndex = 29;
            this.companyIdLabel.Text = "<?>";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(75, 107);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(25, 13);
            this.companyNameLabel.TabIndex = 28;
            this.companyNameLabel.Text = "<?>";
            // 
            // ruleId
            // 
            this.ruleId.HeaderText = "ruleId";
            this.ruleId.Name = "ruleId";
            this.ruleId.ReadOnly = true;
            this.ruleId.Visible = false;
            // 
            // taskAmount
            // 
            this.taskAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.taskAmount.HeaderText = "Aantal";
            this.taskAmount.Name = "taskAmount";
            this.taskAmount.ReadOnly = true;
            this.taskAmount.Width = 62;
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
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 661);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceVATInclusiveLabel);
            this.Controls.Add(this.priceVATLabel);
            this.Controls.Add(this.priceVATExclusiveLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.invoiceSubmitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.taskDeleteButton);
            this.Controls.Add(this.invoiceRulesDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "InvoiceForm";
            this.Text = "<?>";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRulesDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar paymentTermMonthCalendar;
        private System.Windows.Forms.ComboBox companiesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView invoiceRulesDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button taskDeleteButton;
        private System.Windows.Forms.Button taskSubmitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tasksComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown taskAmountNumericUpDown;
        private System.Windows.Forms.Button invoiceSubmitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label priceVATInclusiveLabel;
        private System.Windows.Forms.Label priceVATLabel;
        private System.Windows.Forms.Label priceVATExclusiveLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label companyIdLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label companyAddressLabel;
        private System.Windows.Forms.Label companyPostalCodeLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskPriceTotal;
    }
}