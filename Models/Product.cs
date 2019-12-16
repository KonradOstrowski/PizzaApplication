using System;
using System.Collections.Generic;

namespace PizzaApplication.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public string Sauce { get; set; }
        public string Detalis { get; set; }
        public string Category { get; set; }

        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
