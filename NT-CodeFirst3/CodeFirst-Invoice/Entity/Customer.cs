using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Invoice.Entity
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string CompanyName { get; set; }
        
        public int CityID { get; set; }
        
        public int CountyID { get; set; }

        public string Address { get; set; }

        public City city { get; set; }

        public County county { get; set; }

        public ICollection<InvoiceHeader> ınvoiceHeaders { get; set; }

    }
}
