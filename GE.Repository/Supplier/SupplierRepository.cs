using GE.BL.Entities;
using GE.BL.Exceptions;
using GE.BL.Interfaces;
using GE.BL.Messages;

namespace GE.Repository.Suppliers
{
    public class SupplierRepository : ISupplierRepository
    {
        private List<Supplier> _suppliers;
        public SupplierRepository()
        {
            if(_suppliers == null)
                _suppliers = new List<Supplier>();
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _suppliers;
        }

        public Supplier GetSupplierByCnpj(string cnpj)
        {
            var supplier  = _suppliers.FirstOrDefault(x => x.Cnpj == cnpj);

            if (supplier != null)
                return supplier;
            else
                throw new NotFoundException(ErrorMessages.supplierNotFound);
        }

        public void Save(Supplier supplier)
        {
            _suppliers.Add(supplier);
        }

        public void Update(Supplier supplier)
        {
            _suppliers.Remove(GetSupplierByCnpj(supplier.Cnpj));
            _suppliers.Add(supplier);
        }
    }
}
