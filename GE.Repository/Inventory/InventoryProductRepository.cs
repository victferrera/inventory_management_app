using GE.BL.Entities;
using GE.BL.Interfaces;

namespace GE.Repository.Inventory
{
    public class InventoryProductRepository : IInventoryProductRepository
    {
        public InventoryProductRepository()
        {
            
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(Product produto)
        {
            throw new NotImplementedException();
        }
    }
}
