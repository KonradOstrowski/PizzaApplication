using System;
using System.Collections.Generic;

namespace PizzaApplication.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public int OrderId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateFinished { get; set; }
        public int Totalprice { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int DelivererId { get; set; }
        public int StatusId { get; set; }
        public int PaymentId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Deliverer Deliverer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
