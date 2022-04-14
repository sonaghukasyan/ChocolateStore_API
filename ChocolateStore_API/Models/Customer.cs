using System;
using System.Collections.Generic;

#nullable disable

namespace ChocolateStore_API.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
