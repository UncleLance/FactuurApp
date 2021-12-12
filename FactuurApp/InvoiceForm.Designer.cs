
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
            this.priceVATInclusiveLabel = new System.Windows.Forms.Label();
            this.priceVATLabel = new System.Windows.Forms.Label();
            this.priceVATExclusiveLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentTermMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceRulesDataGridView = new System.Windows.Forms.DataGridView();
            this.taskAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskPriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pinRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.groupBox1.Location = new System.Drawing.Point(479, 12);
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
            this.taskAmountNumericUpDown.Location = new System.Drawing.Point(219, 36);
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
            this.taskSubmitButton.Location = new System.Drawing.Point(6, 67);
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
            this.tasksComboBox.Location = new System.Drawing.Point(6, 35);
            this.tasksComboBox.Name = "tasksComboBox";
            this.tasksComboBox.Size = new System.Drawing.Size(200, 21);
            this.tasksComboBox.TabIndex = 22;
            this.tasksComboBox.SelectedIndexChanged += new System.EventHandler(this.tasksComboBox_SelectedIndexChanged);
            // 
            // taskDeleteButton
            // 
            this.taskDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDeleteButton.Location = new System.Drawing.Point(697, 230);
            this.taskDeleteButton.Name = "taskDeleteButton";
            this.taskDeleteButton.Size = new System.Drawing.Size(100, 23);
            this.taskDeleteButton.TabIndex = 25;
            this.taskDeleteButton.Text = "Verwijder uit lijst";
            this.taskDeleteButton.UseVisualStyleBackColor = true;
            this.taskDeleteButton.Click += new System.EventHandler(this.taskDeleteButton_Click);
            // 
            // priceVATInclusiveLabel
            // 
            this.priceVATInclusiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priceVATInclusiveLabel.AutoSize = true;
            this.priceVATInclusiveLabel.Location = new System.Drawing.Point(695, 716);
            this.priceVATInclusiveLabel.Name = "priceVATInclusiveLabel";
            this.priceVATInclusiveLabel.Size = new System.Drawing.Size(25, 13);
            this.priceVATInclusiveLabel.TabIndex = 24;
            this.priceVATInclusiveLabel.Text = "<?>";
            // 
            // priceVATLabel
            // 
            this.priceVATLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priceVATLabel.AutoSize = true;
            this.priceVATLabel.Location = new System.Drawing.Point(695, 691);
            this.priceVATLabel.Name = "priceVATLabel";
            this.priceVATLabel.Size = new System.Drawing.Size(25, 13);
            this.priceVATLabel.TabIndex = 23;
            this.priceVATLabel.Text = "<?>";
            // 
            // priceVATExclusiveLabel
            // 
            this.priceVATExclusiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priceVATExclusiveLabel.AutoSize = true;
            this.priceVATExclusiveLabel.Location = new System.Drawing.Point(695, 666);
            this.priceVATExclusiveLabel.Name = "priceVATExclusiveLabel";
            this.priceVATExclusiveLabel.Size = new System.Drawing.Size(25, 13);
            this.priceVATExclusiveLabel.TabIndex = 22;
            this.priceVATExclusiveLabel.Text = "<?>";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(470, 716);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Totaal incl. BTW";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(470, 691);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "BTW";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(470, 666);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Totaal exlc. BTW";
            // 
            // paymentTermMonthCalendar
            // 
            this.paymentTermMonthCalendar.Location = new System.Drawing.Point(218, 35);
            this.paymentTermMonthCalendar.MaxSelectionCount = 1;
            this.paymentTermMonthCalendar.Name = "paymentTermMonthCalendar";
            this.paymentTermMonthCalendar.TabIndex = 14;
            this.paymentTermMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.paymentTermMonthCalendar_DateChanged);
            // 
            // customersComboBox
            // 
            this.customersComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customersComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(6, 35);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(200, 21);
            this.customersComboBox.TabIndex = 15;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.customersComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Klant:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Betaalwijze:";
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
            this.invoiceRulesDataGridView.Location = new System.Drawing.Point(12, 259);
            this.invoiceRulesDataGridView.Name = "invoiceRulesDataGridView";
            this.invoiceRulesDataGridView.ReadOnly = true;
            this.invoiceRulesDataGridView.Size = new System.Drawing.Size(785, 383);
            this.invoiceRulesDataGridView.TabIndex = 19;
            this.invoiceRulesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceRulesDataGridView_CellClick);
            this.invoiceRulesDataGridView.SelectionChanged += new System.EventHandler(this.invoiceRulesDataGridView_SelectionChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Uiterste betaaldatum:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cashRadioButton);
            this.groupBox2.Controls.Add(this.pinRadioButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.customersComboBox);
            this.groupBox2.Controls.Add(this.paymentTermMonthCalendar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 212);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factuur gegevens";
            // 
            // pinRadioButton
            // 
            this.pinRadioButton.AutoSize = true;
            this.pinRadioButton.Location = new System.Drawing.Point(9, 83);
            this.pinRadioButton.Name = "pinRadioButton";
            this.pinRadioButton.Size = new System.Drawing.Size(40, 17);
            this.pinRadioButton.TabIndex = 22;
            this.pinRadioButton.TabStop = true;
            this.pinRadioButton.Text = "Pin";
            this.pinRadioButton.UseVisualStyleBackColor = true;
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(9, 106);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(62, 17);
            this.cashRadioButton.TabIndex = 23;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Contant";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(692, 697);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "________";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(753, 692);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "+";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 751);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceVATInclusiveLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.taskDeleteButton);
            this.Controls.Add(this.priceVATLabel);
            this.Controls.Add(this.invoiceRulesDataGridView);
            this.Controls.Add(this.priceVATExclusiveLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Name = "InvoiceForm";
            this.Text = "<?>";
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
        private System.Windows.Forms.Label priceVATInclusiveLabel;
        private System.Windows.Forms.Label priceVATLabel;
        private System.Windows.Forms.Label priceVATExclusiveLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar paymentTermMonthCalendar;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView invoiceRulesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskPriceTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button taskDeleteButton;
        private System.Windows.Forms.Button taskSubmitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tasksComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown taskAmountNumericUpDown;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton pinRadioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}