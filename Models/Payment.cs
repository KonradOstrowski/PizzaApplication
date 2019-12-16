using System;
using System.Collections.Generic;

namespace PizzaApplication.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int StatusId { get; set; }
        public int PaymentMethodId { get; set; }
        public string Details { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
