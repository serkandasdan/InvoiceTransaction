using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Invoice.Entity
{
    public class City
    {
        public int CityID { get; set; }

        public String Description { get; set; }

        public ICollection<Customer> customers { get; set; }

        public ICollection <County> counties { get; set; }

    }
}
