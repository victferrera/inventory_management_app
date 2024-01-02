using GE.BL.Entities;
using GE.BL.Exceptions;
using GE.BL.Interfaces;
using GE.BL.Messages;

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

        public void Remove(BL.Entities.Inventory inventoryOutput)
        {
            var product = _inventory.Where(x => x.productId == inventoryOutput.productId).FirstOrDefault();

            if (product != null)
            {
                if (product.Amount < inventoryOutput.Amount)
                    throw new Exception(ErrorMessages.insuficientProduct);

                product.Amount -= inventoryOutput.Amount;
            }
            else
                throw new NotFoundException(ErrorMessages.productNotFound);
        }

        public void Save(GE.BL.Entities.Inventory newEntry)
        {
            var product = _inventory.Where(x => x.productId == newEntry.productId).FirstOrDefault();

            if(product != null)
            {
                product.Amount += newEntry.Amount;
                product.Price = newEntry.Price;
            }
            else
                _inventory.Add(newEntry);
        }
    }
}
