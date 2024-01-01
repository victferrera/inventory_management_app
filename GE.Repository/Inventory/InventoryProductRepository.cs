using GE.BL.Entities;
using GE.BL.Interfaces;

namespace GE.Repository.Inventory
{
    public class InventoryProductRepository : IInventoryProductRepository
    {
        private List<GE.BL.Entities.Inventory> _inventory;
        public InventoryProductRepository()
        {
            if(_inventory == null)
                _inventory = new List<BL.Entities.Inventory> ();
        }

        public List<BL.Entities.Inventory> GetInventoryAllProducts()
        {
            return _inventory;
        }

        public void Save(GE.BL.Entities.Inventory newEntry)
        {
            _inventory.Add(newEntry);
        }
    }
}
