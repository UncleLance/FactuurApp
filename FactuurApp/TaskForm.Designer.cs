
namespace FactuurApp
{
    partial class TaskForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.taskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.taskPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.taskStatusLabel = new System.Windows.Forms.Label();
            this.taskSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taak naam:";
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(99, 44);
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(150, 20);
            this.taskDescriptionTextBox.TabIndex = 1;
            // 
            // taskPriceTextBox
            // 
            this.taskPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskPriceTextBox.Location = new System.Drawing.Point(99, 70);
            this.taskPriceTextBox.Name = "taskPriceTextBox";
            this.taskPriceTextBox.Size = new System.Drawing.Size(150, 20);
            this.taskPriceTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prijs voor taak:";
            // 
            // taskStatusLabel
            // 
            this.taskStatusLabel.AutoSize = true;
            this.taskStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskStatusLabel.Location = new System.Drawing.Point(12, 9);
            this.taskStatusLabel.Name = "taskStatusLabel";
            this.taskStatusLabel.Size = new System.Drawing.Size(36, 20);
            this.taskStatusLabel.TabIndex = 4;
            this.taskStatusLabel.Text = "<?>";
            // 
            // taskSubmitButton
            // 
            this.taskSubmitButton.Location = new System.Drawing.Point(99, 101);
            this.taskSubmitButton.Name = "taskSubmitButton";
            this.taskSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.taskSubmitButton.TabIndex = 5;
            this.taskSubmitButton.Text = "Voeg toe";
            this.taskSubmitButton.UseVisualStyleBackColor = true;
            this.taskSubmitButton.Click += new System.EventHandler(this.taskSubmitButton_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 136);
            this.Controls.Add(this.taskSubmitButton);
            this.Controls.Add(this.taskStatusLabel);
            this.Controls.Add(this.taskPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskDescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taskDescriptionTextBox;
        private System.Windows.Forms.TextBox taskPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label taskStatusLabel;
        private System.Windows.Forms.Button taskSubmitButton;
    }
}