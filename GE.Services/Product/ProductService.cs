using GE.BL.Entities;
using GE.BL.Exceptions;
using GE.BL.Interfaces;
using GE.BL.Validators;
using System.ComponentModel.DataAnnotations;

namespace GE.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ProductValidator _productValidator;
        private readonly ValidatorException _validatorException;

        public ProductService(IProductRepository productRepository, ProductValidator productValidator)
        {
            _productRepository = productRepository;
            _productValidator = productValidator;
            _validatorException = new ValidatorException();
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(Guid id)
        {
            return _productRepository.GetProductById(id);
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
                    _validatorException.AddError(error.ErrorMessage);
                }

                throw _validatorException;
            }
        }
    }
}
