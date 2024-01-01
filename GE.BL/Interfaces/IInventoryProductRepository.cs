using GE.BL.Entities;

namespace GE.BL.Interfaces
{
    public interface IInventoryProductRepository
    {
        public void Save(Inventory inventoryEntry);
        public List<Inventory> GetInventoryAllProducts();
    }
}
