using GE.BL.Entities;
using GE.BL.Interfaces;

namespace Gerenciamento_Estoque.Services
{
    public class InventoryProductService : IInventoryProductService
    {
        private IInventoryProductRepository _inventoryProductsService;
        public InventoryProductService(IInventoryProductRepository inventoryProductsService)
        {
            _inventoryProductsService = inventoryProductsService;
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById()
        {
            throw new NotImplementedException();
        }

        public void Save(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
