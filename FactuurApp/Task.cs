using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactuurApp
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Task(string description, decimal price)
        {
            this.Description = description;
            this.Price = price;
        }

        public Task()
        {
        }
    }
}
