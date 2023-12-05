using Modern.Crown.Domain.Catalog;

namespace Modern.Crown.Domain.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Item? Item { get; set; }
        public int Quantity { get; set; }
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        public decimal Price => Item.Price * Quantity;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}