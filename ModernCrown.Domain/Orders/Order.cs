using System.Collections.Generic;
using System.Linq;

namespace Modern.Crown.Domain.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem>? Items { get; set; }
        public DateTime CreatedDate { get; set; }
#pragma warning disable CS8604 // Possible null reference argument.
        public decimal TotalPrice => Items.Sum(i => i.Price);
#pragma warning restore CS8604 // Possible null reference argument.

    }
}