using System;
using System.Collections.Generic;

#nullable disable

namespace ChocolateStore_API.Models
{
    public partial class Order
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Chocolate Product { get; set; }
    }
}
