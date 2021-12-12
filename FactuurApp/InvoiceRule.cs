using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactuurApp
{
    public class InvoiceRule
    {
       public int Id { get; set; }
       public Task Task { get; set; }
       public int InvoiceId { get; set; }
       public Car Car { get; set; }
       public int Amount { get; set; }
    }
}
