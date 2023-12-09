using Forms.Inventory.Reports;
using Forms.Products.Edit;
using Forms.Products.New;
using Forms.Suppliers;
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
            _serviceProvider.GetRequiredService<Frm_supplier>().Show();
        }

        private void productSubMenuNew_Click(object sender, EventArgs e)
        {
            _serviceProvider.GetRequiredService<Frm_product_new>().Show();
        }
    }
}