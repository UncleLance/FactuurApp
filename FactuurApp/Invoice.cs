using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactuurApp
{
    public class Invoice
    {
        public int Id { get; set; }
        public List<InvoiceRule> InvoiceRules { get; set; }
        public Customer Customer { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime PaymentTerm { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal VATPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public decimal PriceExclusive()
        {
            return TotalPrice - VATPrice;
        }
    }


}
