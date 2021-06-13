namespace Inventory.Domain.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Department department { get; set; }
        public string Category { get; set; }
        public bool Availability { get; set; }
    }
}
