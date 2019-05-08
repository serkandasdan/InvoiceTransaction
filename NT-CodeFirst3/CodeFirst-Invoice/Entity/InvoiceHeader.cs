using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Invoice.Entity
{
    public class InvoiceHeader
    {
        [Key]
        public int InvoiceID { get; set; }

        public int CustomerID { get; set; }

        public DateTime InvoiceDate { get; set; }

        public string DeliveryNote { get; set; }

        public DateTime PaymentDate { get; set; }

        public int TotalAmount { get; set; }
        public Customer customer { get; set; }

        public ICollection<InvoiceDetails> ınvoiceDetails { get; set; }


    }
}
