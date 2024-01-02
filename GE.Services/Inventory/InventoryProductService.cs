using GE.BL.Entities;
using GE.BL.Interfaces;

namespace Gerenciamento_Estoque.Services
{
    public class InventoryProductService : IInventoryProductService
    {
        private IInventoryProductRepository _inventoryProductsRepository;
        public InventoryProductService(IInventoryProductRepository inventoryProductsRepository)
        {
            _inventoryProductsRepository = inventoryProductsRepository;
        }

        public List<Inventory> GetInventoryAllProducts()
        {
            return _inventoryProductsRepository.GetInventoryAllProducts();
        }

        public void Remove(Inventory inventoryOutput)
        {
            _inventoryProductsRepository.Remove(inventoryOutput);
        }

        public void Save(Inventory inventoryEntry)
        {
            _inventoryProductsRepository.Save(inventoryEntry);
        }
    }
}
