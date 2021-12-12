
namespace FactuurApp
{
    partial class MainForm
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
            this.invoicesGridView = new System.Windows.Forms.DataGridView();
            this.invoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceExclusive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceInclusive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.optionsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.newAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.credentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesGridView)).BeginInit();
            this.searchOptionsGroupBox.SuspendLayout();
            this.optionsMenuStrip.SuspendLayout();
            this.customerInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoicesGridView
            // 
            this.invoicesGridView.AllowUserToAddRows = false;
            this.invoicesGridView.AllowUserToDeleteRows = false;
            this.invoicesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceId,
            this.customerId,
            this.paymentMethod,
            this.paymentTerm,
            this.totalPriceExclusive,
            this.vatPrice,
            this.totalPriceInclusive,
            this.createdAt});
            this.invoicesGridView.Location = new System.Drawing.Point(12, 149);
            this.invoicesGridView.Name = "invoicesGridView";
            this.invoicesGridView.ReadOnly = true;
            this.invoicesGridView.Size = new System.Drawing.Size(1010, 350);
            this.invoicesGridView.TabIndex = 0;
            this.invoicesGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoicesGridView_CellDoubleClick);
            this.invoicesGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.invoicesGridView_MouseClick);
            // 
            // invoiceId
            // 
            this.invoiceId.HeaderText = "Factuur nummer";
            this.invoiceId.Name = "invoiceId";
            this.invoiceId.ReadOnly = true;
            this.invoiceId.Width = 120;
            // 
            // customerId
            // 
            this.customerId.HeaderText = "Klant nummer";
            this.customerId.Name = "customerId";
            this.customerId.ReadOnly = true;
            this.customerId.Width = 120;
            // 
            // paymentMethod
            // 
            this.paymentMethod.HeaderText = "Betaalwijze";
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.ReadOnly = true;
            // 
            // paymentTerm
            // 
            this.paymentTerm.HeaderText = "Betaaltermijn";
            this.paymentTerm.Name = "paymentTerm";
            this.paymentTerm.ReadOnly = true;
            this.paymentTerm.Width = 150;
            // 
            // totalPriceExclusive
            // 
            this.totalPriceExclusive.HeaderText = "Totaal excl. BTW";
            this.totalPriceExclusive.Name = "totalPriceExclusive";
            this.totalPriceExclusive.ReadOnly = true;
            this.totalPriceExclusive.Width = 105;
            // 
            // vatPrice
            // 
            this.vatPrice.HeaderText = "BTW prijs";
            this.vatPrice.Name = "vatPrice";
            this.vatPrice.ReadOnly = true;
            this.vatPrice.Width = 105;
            // 
            // totalPriceInclusive
            // 
            this.totalPriceInclusive.HeaderText = "Totaal incl. BTW";
            this.totalPriceInclusive.Name = "totalPriceInclusive";
            this.totalPriceInclusive.ReadOnly = true;
            this.totalPriceInclusive.Width = 105;
            // 
            // createdAt
            // 
            this.createdAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdAt.HeaderText = "Gemaakt op";
            this.createdAt.Name = "createdAt";
            this.createdAt.ReadOnly = true;
            // 
            // searchOptionsGroupBox
            // 
            this.searchOptionsGroupBox.Controls.Add(this.label2);
            this.searchOptionsGroupBox.Controls.Add(this.searchTextBox);
            this.searchOptionsGroupBox.Controls.Add(this.searchButton);
            this.searchOptionsGroupBox.Controls.Add(this.label1);
            this.searchOptionsGroupBox.Controls.Add(this.searchOptionsComboBox);
            this.searchOptionsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.searchOptionsGroupBox.Name = "searchOptionsGroupBox";
            this.searchOptionsGroupBox.Size = new System.Drawing.Size(250, 116);
            this.searchOptionsGroupBox.TabIndex = 1;
            this.searchOptionsGroupBox.TabStop = false;
            this.searchOptionsGroupBox.Text = "Zoek opties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Waarde:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(9, 81);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(120, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(135, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 21);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Zoeken";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zoek op:";
            // 
            // searchOptionsComboBox
            // 
            this.searchOptionsComboBox.FormattingEnabled = true;
            this.searchOptionsComboBox.Items.AddRange(new object[] {
            "Factuur nummer",
            "Klant nummer",
            "Factuur datum"});
            this.searchOptionsComboBox.Location = new System.Drawing.Point(9, 41);
            this.searchOptionsComboBox.Name = "searchOptionsComboBox";
            this.searchOptionsComboBox.Size = new System.Drawing.Size(120, 21);
            this.searchOptionsComboBox.TabIndex = 0;
            // 
            // optionsMenuStrip
            // 
            this.optionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAddToolStripMenuItem,
            this.credentialsToolStripMenuItem});
            this.optionsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.optionsMenuStrip.Name = "optionsMenuStrip";
            this.optionsMenuStrip.Size = new System.Drawing.Size(1034, 24);
            this.optionsMenuStrip.TabIndex = 2;
            this.optionsMenuStrip.Text = "menuStrip1";
            // 
            // newAddToolStripMenuItem
            // 
            this.newAddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.taskToolStripMenuItem});
            this.newAddToolStripMenuItem.Name = "newAddToolStripMenuItem";
            this.newAddToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.newAddToolStripMenuItem.Text = "Voeg nieuw...";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem.Text = "Klant";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.invoiceToolStripMenuItem.Text = "Factuur";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taskToolStripMenuItem.Text = "Taak";
            this.taskToolStripMenuItem.Click += new System.EventHandler(this.taskToolStripMenuItem_Click);
            // 
            // credentialsToolStripMenuItem
            // 
            this.credentialsToolStripMenuItem.Name = "credentialsToolStripMenuItem";
            this.credentialsToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.credentialsToolStripMenuItem.Text = "Connectie gegevens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Connectie status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(693, 35);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(25, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "<?>";
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.Controls.Add(this.customerNameLabel);
            this.customerInfoGroupBox.Controls.Add(this.customerIdLabel);
            this.customerInfoGroupBox.Controls.Add(this.label5);
            this.customerInfoGroupBox.Controls.Add(this.label4);
            this.customerInfoGroupBox.Location = new System.Drawing.Point(292, 27);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(300, 116);
            this.customerInfoGroupBox.TabIndex = 5;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Klant gegevens";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(89, 65);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(25, 13);
            this.customerNameLabel.TabIndex = 3;
            this.customerNameLabel.Text = "<?>";
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(89, 25);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(25, 13);
            this.customerIdLabel.TabIndex = 2;
            this.customerIdLabel.Text = "<?>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Klantnaam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Klantnnummer:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 511);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchOptionsGroupBox);
            this.Controls.Add(this.invoicesGridView);
            this.Controls.Add(this.optionsMenuStrip);
            this.MainMenuStrip = this.optionsMenuStrip;
            this.Name = "MainForm";
            this.Text = "Factuur overzicht";
            ((System.ComponentModel.ISupportInitialize)(this.invoicesGridView)).EndInit();
            this.searchOptionsGroupBox.ResumeLayout(false);
            this.searchOptionsGroupBox.PerformLayout();
            this.optionsMenuStrip.ResumeLayout(false);
            this.optionsMenuStrip.PerformLayout();
            this.customerInfoGroupBox.ResumeLayout(false);
            this.customerInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView invoicesGridView;
        private System.Windows.Forms.GroupBox searchOptionsGroupBox;
        private System.Windows.Forms.MenuStrip optionsMenuStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchOptionsComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ToolStripMenuItem newAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem credentialsToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceExclusive;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceInclusive;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
    }
}

