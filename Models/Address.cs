using System;
using System.Collections.Generic;

namespace PizzaApplication.Models
{
    public partial class Address
    {
        public Address()
        {
            Customer = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Streetname { get; set; }
        public int Streetnumber { get; set; }
        public int? Homenumber { get; set; }
        public string City { get; set; }
        public int Postcode { get; set; }
        public string AddressDetails { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
