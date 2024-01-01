namespace GE.BL.Entities
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public Guid productId { get; set; }
        public Guid SupplierId { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }

        public Inventory()
        {
            Id = Guid.NewGuid();
        }
    }
}
