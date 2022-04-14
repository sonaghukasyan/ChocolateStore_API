using System;
using System.Collections.Generic;

#nullable disable

namespace ChocolateStore_API.Models
{
    public partial class Chocolate
    {
        public Chocolate()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
