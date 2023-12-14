using GE.BL.Entities;

namespace GE.BL.Interfaces
{
    public interface ISupplierService
    {
        void Save(Supplier supplier);
        List<Supplier> GetAllSupliers();
    }
}
