using System;
using System.Collections.Generic;

namespace PizzaApplication.Models
{
    public partial class OrderProduct
    {
        public int Id { get; set; }
        public int OrderOrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public virtual Order OrderOrder { get; set; }
        public virtual Product Product { get; set; }
    }
}
