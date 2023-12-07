namespace GE.BL.Entities
{
    public record Inventory(Guid Id, Guid productId, decimal Amount, decimal Price);
}
