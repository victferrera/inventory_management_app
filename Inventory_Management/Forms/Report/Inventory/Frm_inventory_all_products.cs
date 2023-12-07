using GE.BL.Interfaces;

namespace Forms.Inventory.Reports
{
    public partial class Frm_inventory_all_products : Form
    {
        private IProductService _productService;
        public Frm_inventory_all_products(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        public void GetAllProducts()
        {
            grid_produtos.DataSource = _productService.GetAllProducts();
            grid_produtos.Refresh();
        }
    }
}
