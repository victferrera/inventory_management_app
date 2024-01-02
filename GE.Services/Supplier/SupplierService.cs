using GE.BL.Interfaces;
using GE.BL.Entities;
using GE.BL.Validators;
using GE.BL.Exceptions;
using GE.BL.Helpers;
using GE.BL.Messages;

namespace GE.Services.Suppliers
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly AddressValidator _addressValidator;
        private readonly ContactValidator _contactValidator;
        private readonly SupplierValidator _supplierValidator;
        private ErrorHandling _errorHandling;

        public SupplierService(ISupplierRepository supplierRepository, AddressValidator addressValidator, ContactValidator contactValidator,
            SupplierValidator supplierValidator)
        {
            _supplierRepository = supplierRepository;
            _addressValidator = addressValidator;
            _contactValidator = contactValidator;
            _supplierValidator = supplierValidator;
            _errorHandling = new ErrorHandling();
        }

        public void Save(Supplier supplier)
        {
            Validate(supplier);
            _supplierRepository.Save(supplier);
        }

        private void Validate(Supplier supplier)
        {
            ValidateContact(supplier.Contact);
            ValidateAddress(supplier.Contact.Address);
            ValidateSupplier(supplier);

            if (_errorHandling.hasErrors)
            {
                throw new ValidatorException(_errorHandling.GetErrors());
            }
        }

        private void ValidateContact(Contact contact)
        {
            var validationResult = _contactValidator.Validate(contact);

            if(!validationResult.IsValid)
            {
                foreach(var error in validationResult.Errors)
                {
                    _errorHandling.AddError(error.ErrorMessage);
                }
            }
        }

        private void ValidateAddress(Address address)
        {
            var validationResult = _addressValidator.Validate(address);

            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    _errorHandling.AddError(error.ErrorMessage);
                }
            }
        }

        private void ValidateSupplier(Supplier supplier)
        {
            var validationResult = _supplierValidator.Validate(supplier);

            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    _errorHandling.AddError(error.ErrorMessage);
                }
            }
        }

        public List<Supplier> GetAllSupliers()
        {
            return _supplierRepository.GetAllSuppliers();
        }

        public Supplier GetSupplierByCnpj(string cnpj)
        {
            var supplier =  _supplierRepository.GetSupplierByCnpj(cnpj);

            if (supplier != null)
                return supplier;
            else
                throw new NotFoundException(ErrorMessages.supplierNotFound);
        }

        public void Update(Supplier supplier)
        {
            Validate(supplier);
            _supplierRepository.Update(supplier);
        }
    }
}
