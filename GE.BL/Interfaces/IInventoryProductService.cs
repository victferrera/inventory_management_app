using GE.BL.Entities;

namespace GE.BL.Interfaces
{
    public interface IInventoryProductService
    {
        void Save(Inventory inventoryEntry);
        void Remove(Inventory inventoryOutput);
        List<Inventory> GetInventoryAllProducts();
    }
}
