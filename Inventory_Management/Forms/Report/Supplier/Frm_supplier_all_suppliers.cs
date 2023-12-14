using GE.BL.Interfaces;

namespace Inventory_Management.Forms.Report.Supplier
{
    public partial class Frm_supplier_all_suppliers : Form
    {
        private readonly ISupplierService _supplierService;
        public Frm_supplier_all_suppliers(ISupplierService supplierService)
        {
            InitializeComponent();
            _supplierService = supplierService;
        }

        public void GetAllSuppliers()
        {
            grid_suppliers.DataSource = _supplierService.GetAllSupliers();
            grid_suppliers.Refresh();
        }
    }
}
