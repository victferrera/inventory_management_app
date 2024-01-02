using GE.BL.Entities;

namespace GE.BL.Interfaces
{
    public interface ISupplierRepository
    {
        void Save(Supplier supplier);
        List<Supplier> GetAllSuppliers();
        Supplier GetSupplierByCnpj(string cnpj);
        void Update(Supplier supplier);
    }
}
