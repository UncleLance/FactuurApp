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
        static readonly MySqlConnection connection = new(connectionString);

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
            List<Invoice> invoiceList = new();

            if (CheckConnection())
            {
                //Step 1: Get all invoices with the corresponding company and payment method
                List<Company> companyList = GetAllCompanies();
                List<PaymentMethod> methods = GetAllMethods();

                string query = "SELECT * FROM invoices";
                MySqlCommand command = new(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Invoice invoice = new()
                    {
                        Id = reader.GetInt32(0),
                        Company = companyList.Where(c => c.Id == reader.GetInt32(1)).First(),
                        PaymentMethod = methods.Where(c => c.Id == reader.GetInt32(2)).First(),
                        PaymentTerm = reader.GetDateTime(3),
                        TotalPrice = reader.GetDecimal(4),
                        VATPrice = reader.GetDecimal(5),
                        CreatedAt = reader.GetDateTime(6)
                    };

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

        public static void AddCompany(Company company)
        {
            connection.Open();

            if (CheckConnection())
            {
                try
                {
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO companies (company_name, address, city, postal_code, country, contact_person, phone_number, email_address)" +
                        " VALUES (?company_name, ?address, ?city, ?postal_code, ?country, ?contact_person, ?phone_number, ?email_address)";
                    command.Parameters.Add("?company_name", MySqlDbType.VarChar).Value = company.CompanyName;
                    command.Parameters.Add("?address", MySqlDbType.VarChar).Value = company.Address;
                    command.Parameters.Add("?city", MySqlDbType.VarChar).Value = company.City;
                    command.Parameters.Add("?postal_code", MySqlDbType.VarChar).Value = company.PostalCode;
                    command.Parameters.Add("?country", MySqlDbType.VarChar).Value = company.Country;
                    command.Parameters.Add("?contact_person", MySqlDbType.VarChar).Value = company.ContactPerson;
                    command.Parameters.Add("?phone_number", MySqlDbType.VarChar).Value = company.PhoneNumber;
                    command.Parameters.Add("?email_address", MySqlDbType.VarChar).Value = company.EmailAddress;

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Bedrijf is succesvol toegevoegd!");
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

        public static List<Company> GetAllCompanies()
        {
            List<Company> companyList = new();

            if (CheckConnection())
            {
                string query = "SELECT * FROM companies";
                MySqlCommand command = new(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Company company = new()
                    {
                        Id = reader.GetInt32(0),
                        CompanyName = reader.GetString(1),
                        Address = reader.GetString(2),
                        City = reader.GetString(3),
                        PostalCode = reader.GetString(4),
                        Country = !reader.IsDBNull(5) ? reader.GetString(5) : null,
                        ContactPerson = !reader.IsDBNull(6) ? reader.GetString(6) : null,
                        PhoneNumber = !reader.IsDBNull(7) ? reader.GetString(7) : null,
                        EmailAddress = !reader.IsDBNull(8) ? reader.GetString(8) : null
                    };

                    companyList.Add(company);
                }
                reader.Close();

                return companyList;
            }

            return null;
        }

        //==================
        // INVOICE RULE RELATED METHODS
        //==================
        private static void GetAllInvoiceRules(List<Invoice> invoices)
        {
            List<Car> cars = GetAllCars();
            List<Task> tasks = GetAllTasks();
            
            List<InvoiceRule> rules = new();
            
            string query = "SELECT * FROM invoice_rules";
            MySqlCommand command = new(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            if(CheckConnection())
            {
                while (reader.Read())
                {
                    InvoiceRule invoiceRule = new()
                    {
                        Id = reader.GetInt32(0),
                        InvoiceId = reader.GetInt32(1),
                        Task = tasks.Where(t => t.Id == reader.GetInt32(2)).First(),
                        Car = cars.Where(c => c.Id == reader.GetInt32(3)).First(),
                        Amount = reader.GetInt32(4)
                    };

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
            List<Task> tasks = new();

            if (CheckConnection())
            {
                string query = "SELECT * FROM tasks";
                MySqlCommand command = new(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Task task = new()
                    {
                        Id = reader.GetInt32(0),
                        Description = reader.GetString(1),
                        Price = reader.GetDecimal(2)
                    };

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
            
            if (CheckConnection())
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
            List<Car> cars = new();

            if(CheckConnection())
            {
                string query = "SELECT * FROM cars";
                MySqlCommand command = new(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Car car = new()
                    {
                        Id = reader.GetInt32(0),
                        Model = reader.GetString(1),
                        NumberPlate = reader.GetString(2)
                    };

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
            List<PaymentMethod> methods = new();

            if (CheckConnection())
            {
                string query = "SELECT * FROM payment_methods";
                MySqlCommand command = new(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    PaymentMethod paymentMethod = new()
                    {
                        Id = reader.GetInt32(0),
                        Method = reader.GetString(1)
                    };

                    methods.Add(paymentMethod);
                }
                reader.Close();

                return methods;
            }

            return null;
        }

        public static void AddCustomer(Customer customer)
        {
            connection.Open();

            if (CheckConnection())
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