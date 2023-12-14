using GE.BL.Entities;
using GE.BL.Interfaces;

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

        public void Save(Supplier supplier)
        {
            _suppliers.Add(supplier);
        }
    }
}
