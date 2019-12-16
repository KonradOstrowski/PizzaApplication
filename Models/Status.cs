using System;
using System.Collections.Generic;

namespace PizzaApplication.Models
{
    public partial class Status
    {
        public Status()
        {
            Order = new HashSet<Order>();
            Payment = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Details { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
