using GE.BL.Interfaces;

namespace Forms.Inventory.Reports
{
    public partial class Frm_inventory_all_products : Form
    {
        private IInventoryProductService _inventoryService;
        private IProductService _productService;
        private ISupplierService _supplierService;
        public Frm_inventory_all_products(IInventoryProductService inventoryService, IProductService productService,
            ISupplierService supplierService)
        {
            InitializeComponent();
            _inventoryService = inventoryService;
            _productService = productService;
            _supplierService = supplierService;
        }

        public void GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            var suppliers = _supplierService.GetAllSupliers();

            var dataSource = from itens in _inventoryService.GetInventoryAllProducts()
                             join itens2 in products on itens.productId equals itens2.Id
                             join itens3 in suppliers on itens.SupplierId equals itens3.Id
                             select new { Produto = itens2.Name, Fornecedor = itens3.Name, Quantidade = itens.Amount, Preco = itens.Price };

            grid_produtos.DataSource = dataSource.ToList();
            grid_produtos.Refresh();
        }
    }
}
