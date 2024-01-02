using Forms.Inventory.Reports;
using Forms.Products.Edit;
using Forms.Products.New;
using Forms.Suppliers;
using Inventory_Management.Forms.Inventory;
using Inventory_Management.Forms.Report.Supplier;
using Inventory_Management.Forms.Supplier;
using Microsoft.Extensions.DependencyInjection;

namespace Inventory_Management
{
    public partial class Frm_main : Form
    {
        private IServiceProvider _serviceProvider;

        public Frm_main()
        {
            InitializeComponent();
            _serviceProvider = DependencyInjectionConfig.GetServiceProviderInstance();
        }

        private void produtoNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _serviceProvider.GetRequiredService<Frm_product_new>().Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_rel_estoque = _serviceProvider.GetRequiredService<Frm_inventory_all_products>();
            frm_rel_estoque.GetAllProducts();
            frm_rel_estoque.Show();
        }

        private void produtoEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _serviceProvider.GetRequiredService<Frm_product_edit>().Show();
        }

        private void fornecedorNovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form_supplier = _serviceProvider.GetRequiredService<Frm_supplier>();
            form_supplier.SetFormMode(Frm_supplier_mode.Frm_save);
            form_supplier.Show();
        }

        private void productSubMenuNew_Click(object sender, EventArgs e)
        {
            _serviceProvider.GetRequiredService<Frm_product_new>().Show();
        }

        private void reportsSubMenuSupplier_Click(object sender, EventArgs e)
        {
            var frm_rel_suppliers = _serviceProvider.GetService<Frm_supplier_all_suppliers>();
            frm_rel_suppliers.GetAllSuppliers();
            frm_rel_suppliers.Show();
        }

        private void supplierSubMenuEdit_Click(object sender, EventArgs e)
        {
            var form_supplier = _serviceProvider.GetRequiredService<Frm_supplier>();
            form_supplier.SetFormMode(Frm_supplier_mode.Frm_edit);
            form_supplier.Show();
        }

        private void actionsSubMenuInput_Click(object sender, EventArgs e)
        {
            var form_inventory_input = _serviceProvider.GetRequiredService<Frm_inventory>();
            form_inventory_input.SetMode(Frm_inventory_mode.Frm_input);
            form_inventory_input.Show();
        }

        private void actionsSubMenuOutput_Click(object sender, EventArgs e)
        {
            var form_inventory_input = _serviceProvider.GetRequiredService<Frm_inventory>();
            form_inventory_input.SetMode(Frm_inventory_mode.Frm_output);
            form_inventory_input.Show();
        }
    }
}