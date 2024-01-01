using GE.BL.Entities;
using GE.BL.Exceptions;
using GE.BL.Helpers;
using GE.BL.Interfaces;
using GE.BL.Validators;

namespace GE.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ProductValidator _productValidator;
        private ErrorHandling _errorHandling;

        public ProductService(IProductRepository productRepository, ProductValidator productValidator)
        {
            _productRepository = productRepository;
            _productValidator = productValidator;
            _errorHandling = new ErrorHandling();
        }

        public void Delete(Guid id)
        {
            _productRepository.DeleteProductById(id);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(Guid id)
        {
            return _productRepository.GetProductById(id);
        }

        public Product GetProductByName(string name)
        {
            return _productRepository.GetProductByName(name);
        }

        public void Save(Product product)
        {
            Validate(product);
            _productRepository.Save(product);
        }

        public void Update(Product product)
        {
            _productValidator.Validate(product);
            _productRepository.Update(product);
        }

        private void Validate(Product product)
        {
            var result = _productValidator.Validate(product);

            if(!result.IsValid)
            {
                foreach(var error in result.Errors)
                {
                    _errorHandling.AddError(error.ErrorMessage);
                }
            }

            if(_errorHandling.hasErrors)
            {
                throw new ValidatorException(_errorHandling.GetErrors());
            }
        }
    }
}
