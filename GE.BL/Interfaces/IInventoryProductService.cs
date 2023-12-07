using GE.BL.Entities;

namespace GE.BL.Interfaces
{
    public interface IInventoryProductService
    {
        void Save(Product product);
        List<Product> GetAllProducts();
        Product GetProductById();
    }
}
