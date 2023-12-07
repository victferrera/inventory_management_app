using GE.BL.Entities;
using GE.BL.Exceptions;
using GE.BL.Interfaces;
using GE.BL.Messages;

namespace GE.Repository.Products
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            if(_products == null)
                _products = new List<Product>();
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(Guid id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public Product GetProductByName(string name)
        {
            return _products.FirstOrDefault(x => x.Name == name);
        }

        public void Save(Product product)
        {
            var productInfo = GetProductByName(product.Name);

            if(productInfo != null)
                    throw new DataAlreadyExistsException(ErrorMessages.productAlreadyExists);

            _products.Add(product);       
        }

        public void Update(Product product)
        {
            var productInfo = GetProductById(product.Id);

            if (productInfo == null)
                throw new NotFoundException(ErrorMessages.productNotFound);

            productInfo.SetName(product.Name);
            productInfo.SetDescription(product.Description);
        }
    }
}
