using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FactuurApp
{
    static class Database
    {
        static readonly string connectionString = "server=localhost;user=root;database=facturen_apcbreda;port=3306";
        static readonly MySqlConnection connection = new MySqlConnection(connectionString);

        //==================
        // DATABASE CLASS RELATED METHODS
        //==================
        public static void MakeConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

        public static bool CheckConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                //MessageBox.Show("Er is geen connectie met de database!");
                return false;
            }
        }

        //==================
        // INVOICE RELATED METHODS
        //==================
        public static List<Invoice> GetAllInvoices()
        {
            List<Invoice> invoiceList = new List<Invoice>();

            if (CheckConnection() == true)
            {
                //Step 1: Get all invoices with the corresponding customer and payment method
                List<Customer> customerList = GetAllCustomers();
                List<PaymentMethod> methods = GetAllMethods();

                string query = "SELECT * FROM invoices";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Invoice invoice = new Invoice();
                    invoice.Id = reader.GetInt32(0);
                    invoice.Customer = customerList.Where(c => c.Id == reader.GetInt32(1)).First();
                    invoice.PaymentMethod = methods.Where(c => c.Id == reader.GetInt32(2)).First();
                    invoice.PaymentTerm = reader.GetDateTime(3);
                    invoice.TotalPrice = reader.GetDecimal(4);
                    invoice.VATPrice = reader.GetDecimal(5);
                    invoice.CreatedAt = reader.GetDateTime(6);

                    invoiceList.Add(invoice);
                }
                reader.Close();

                //Step 2: Get all the invoice rules to the corresponding invoice
                GetAllInvoiceRules(invoiceList);
                connection.Close();
                return invoiceList;
            }
            connection.Close();
            return null;
        }

        //==================
        // INVOICE RULE RELATED METHODS
        //==================
        private static void GetAllInvoiceRules(List<Invoice> invoices)
        {
            List<Car> cars = GetAllCars();
            List<Task> tasks = GetAllTasks();
            
            List<InvoiceRule> rules = new List<InvoiceRule>();
            
            string query = "SELECT * FROM invoice_rules";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            if(CheckConnection() == true)
            {
                while (reader.Read())
                {
                    InvoiceRule invoiceRule = new InvoiceRule();
                    invoiceRule.Id = reader.GetInt32(0);
                    invoiceRule.InvoiceId = reader.GetInt32(1);
                    invoiceRule.Task = tasks.Where(t => t.Id == reader.GetInt32(2)).First();
                    invoiceRule.Car = cars.Where(c => c.Id == reader.GetInt32(3)).First();
                    invoiceRule.Amount = reader.GetInt32(4);

                    rules.Add(invoiceRule);
                }
                reader.Close();

                foreach(Invoice invoice in invoices)
                {
                    invoice.InvoiceRules = rules.Where(r => r.InvoiceId == invoice.Id).ToList();
                }
            }
            else
            {
                MessageBox.Show("er ging iets mis...");
                return;
            }
        }

        //==================
        // TASK RELATED METHODS
        //==================
        public static List<Task> GetAllTasks()
        {
            List<Task> tasks = new List<Task>();

            if (CheckConnection() == true)
            {
                string query = "SELECT * FROM tasks";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Task task = new Task();

                    task.Id = reader.GetInt32(0);
                    task.Description = reader.GetString(1);
                    task.Price = reader.GetDecimal(2);

                    tasks.Add(task);
                }
                reader.Close();

                return tasks;
            }
            return null;
        }

        public static void AddTask(Task task)
        {
            connection.Open();
            
            if (CheckConnection() == true)
            {
                try
                {
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO tasks (description, price) VALUES (?description, ?price)";
                    command.Parameters.Add("?description", MySqlDbType.VarChar).Value = task.Description;
                    command.Parameters.Add("?price", MySqlDbType.Decimal).Value = task.Price;

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Taak is succesvol toegevoegd!");
                    }
                    else
                    {
                        MessageBox.Show("Er ging iets mis...");
                    }
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connection.Close();
            }
        }

        //==================
        // CAR RELATED METHODS
        //==================
        public static List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();

            if(CheckConnection() == true)
            {
                string query = "SELECT * FROM cars";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Car car = new Car();

                    car.Id = reader.GetInt32(0);
                    car.Model = reader.GetString(1);
                    car.NumberPlate = reader.GetString(2);

                    cars.Add(car);
                }
                reader.Close();

                return cars;
            }
            return null;
        }

        //==================
        // PAYMENT METHOD RELATED METHODS
        //==================
        public static List<PaymentMethod> GetAllMethods()
        {
            List<PaymentMethod> methods = new List<PaymentMethod>();

            if (CheckConnection() == true)
            {
                string query = "SELECT * FROM payment_methods";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    PaymentMethod paymentMethod = new PaymentMethod();
                    paymentMethod.Id = reader.GetInt32(0);
                    paymentMethod.Method = reader.GetString(1);

                    methods.Add(paymentMethod);
                }
                reader.Close();

                return methods;
            }

            return null;
        }

        //==================
        // CUSTOMER RELATED METHODS
        //==================
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customerList = new List<Customer>();

            if (CheckConnection() == true)
            {
                string query = "SELECT * FROM customers";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.Id = reader.GetInt32(0);
                    customer.FirstName = reader.GetString(1);
                    customer.Insertion = !reader.IsDBNull(2) ? reader.GetString(2) : null;
                    customer.LastName = reader.GetString(3);
                    customer.PhoneNumber = reader.GetString(4);
                    customer.EmailAddress = reader.GetString(5);

                    customerList.Add(customer);
                }
                reader.Close();

                return customerList;
            }

            return null;
        }

        public static void AddCustomer(Customer customer)
        {
            connection.Open();

            if (CheckConnection() == true)
            {
                try
                {
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO customers (first_name, insertion, last_name, phone_number, email_address) " +
                                          "VALUES (?first_name, ?insertion, ?last_name, ?phone_number, ?email_address)";
                    command.Parameters.Add("?first_name", MySqlDbType.VarChar).Value = customer.FirstName;
                    command.Parameters.Add("?insertion", MySqlDbType.VarChar).Value = customer.Insertion;
                    command.Parameters.Add("?last_name", MySqlDbType.VarChar).Value = customer.LastName;
                    command.Parameters.Add("?phone_number", MySqlDbType.VarChar).Value = customer.PhoneNumber;
                    command.Parameters.Add("?email_address", MySqlDbType.VarChar).Value = customer.EmailAddress;

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Klant is succesvol toegevoegd!");
                    }
                    else
                    {
                        MessageBox.Show("Er ging iets mis...");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connection.Close();
            }
        }
    }
}