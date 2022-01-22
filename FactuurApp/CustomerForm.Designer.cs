
namespace FactuurApp
{
    partial class CustomerForm
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
            this.components = new System.ComponentModel.Container();
            this.customerStatusLabel = new System.Windows.Forms.Label();
            this.customerInsertionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerSubmitButton = new System.Windows.Forms.Button();
            this.customerToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // customerStatusLabel
            // 
            this.customerStatusLabel.AutoSize = true;
            this.customerStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerStatusLabel.Location = new System.Drawing.Point(12, 9);
            this.customerStatusLabel.Name = "customerStatusLabel";
            this.customerStatusLabel.Size = new System.Drawing.Size(36, 20);
            this.customerStatusLabel.TabIndex = 5;
            this.customerStatusLabel.Text = "<?>";
            // 
            // customerInsertionTextBox
            // 
            this.customerInsertionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerInsertionTextBox.Location = new System.Drawing.Point(101, 71);
            this.customerInsertionTextBox.Name = "customerInsertionTextBox";
            this.customerInsertionTextBox.Size = new System.Drawing.Size(270, 20);
            this.customerInsertionTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tussenvoegsel*:";
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // customerFirstNameTextBox
            // 
            this.customerFirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerFirstNameTextBox.Location = new System.Drawing.Point(101, 45);
            this.customerFirstNameTextBox.Name = "customerFirstNameTextBox";
            this.customerFirstNameTextBox.Size = new System.Drawing.Size(270, 20);
            this.customerFirstNameTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Voornaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Achternaam:";
            // 
            // customerLastNameTextBox
            // 
            this.customerLastNameTextBox.Location = new System.Drawing.Point(101, 97);
            this.customerLastNameTextBox.Name = "customerLastNameTextBox";
            this.customerLastNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.customerLastNameTextBox.TabIndex = 11;
            // 
            // customerPhoneNumberTextBox
            // 
            this.customerPhoneNumberTextBox.Location = new System.Drawing.Point(101, 123);
            this.customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            this.customerPhoneNumberTextBox.Size = new System.Drawing.Size(150, 20);
            this.customerPhoneNumberTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefoon:";
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Location = new System.Drawing.Point(101, 149);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(150, 20);
            this.customerEmailTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "E-mail:";
            // 
            // customerSubmitButton
            // 
            this.customerSubmitButton.Location = new System.Drawing.Point(101, 180);
            this.customerSubmitButton.Name = "customerSubmitButton";
            this.customerSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.customerSubmitButton.TabIndex = 17;
            this.customerSubmitButton.Text = "Opslaan";
            this.customerSubmitButton.UseVisualStyleBackColor = true;
            this.customerSubmitButton.Click += new System.EventHandler(this.customerSubmitButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 216);
            this.Controls.Add(this.customerSubmitButton);
            this.Controls.Add(this.customerEmailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customerPhoneNumberTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerLastNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerInsertionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerFirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerStatusLabel);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerStatusLabel;
        private System.Windows.Forms.TextBox customerInsertionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerFirstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerLastNameTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button customerSubmitButton;
        private System.Windows.Forms.ToolTip customerToolTip;
    }
}