using GE.BL.Entities;

namespace GE.BL.Interfaces
{
    public interface IInventoryProductRepository
    {
        public void Save(Product produto);
        public List<Product> GetAllProducts();
        public Product GetProductById(Guid id);
    }
}
