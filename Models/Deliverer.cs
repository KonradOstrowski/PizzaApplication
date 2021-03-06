﻿using System;
using System.Collections.Generic;

namespace PizzaApplication.Models
{
    public partial class Deliverer
    {
        public Deliverer()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
