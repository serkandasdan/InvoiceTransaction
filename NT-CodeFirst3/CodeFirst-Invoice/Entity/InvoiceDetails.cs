using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Invoice.Entity
{
    public class InvoiceDetails
    {
        [Key]

        [Column(Order =1)]
        public int InvoiceID { get; set; }
        [Column(Order = 2)]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal VATAmount { get; set; }

        public decimal AmountWithVAT { get; set; }

        public string Description { get; set; }

        public Product product { get; set; }

        public InvoiceHeader ınvoiceHeader { get; set; }


    }
}
