using GE.BL.Entities;

namespace GE.BL.Interfaces
{
    public interface IProductRepository
    {
        void Save(Product product);
        void Update(Product product);
        Product GetProductById(Guid id);
        List<Product> GetAllProducts();
        Product GetProductByName(string name);
        void DeleteProductById(Guid id);
    }
}
