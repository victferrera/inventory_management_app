using GE.BL.Entities;

namespace GE.BL.Interfaces
{
    public interface IProductService
    {
        void Save(Product product);
        void Update(Product product);
        Product GetProductById(Guid id);
        List<Product> GetAllProducts();
        void Delete(Guid id);
    }
}
