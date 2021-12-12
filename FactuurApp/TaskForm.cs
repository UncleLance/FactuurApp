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
    public partial class TaskForm : Form
    {
        private Task task = new Task();
        public TaskForm()
        {
            InitializeComponent();

            taskStatusLabel.Text = "Voeg nieuw taak toe";
            this.Text = "Nieuwe taak";
        }

        private void taskSubmitButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(taskDescriptionTextBox.Text) || string.IsNullOrEmpty(taskPriceTextBox.Text))
            {
                MessageBox.Show("Een van de velden zijn leeg!");
                return;
            }

            decimal price;
            if (!decimal.TryParse(taskPriceTextBox.Text, out price))
            {
                MessageBox.Show("Er mag alleen een bedrag worden ingevoerd in prijs veld!");
                taskPriceTextBox.Text = string.Empty;
                return;
            }

            price = taskPriceTextBox.Text.Contains(",") == true ? 
                    decimal.Parse(taskPriceTextBox.Text.Replace(',', '.')) : 
                    decimal.Parse(taskPriceTextBox.Text);

            Task newTask = new Task(taskDescriptionTextBox.Text, price);

            Database.AddTask(newTask);

            this.Close();
        }
    }
}
