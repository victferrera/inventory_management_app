using GE.BL.Entities;

namespace GE.BL.Interfaces
{
    public interface IInventoryProductService
    {
        void Save(Inventory inventoryEntry);
        List<Inventory> GetInventoryAllProducts();
    }
}
