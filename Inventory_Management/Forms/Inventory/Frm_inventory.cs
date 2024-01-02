using GE.BL.Entities;
using GE.BL.Exceptions;
using GE.BL.Helpers;
using GE.BL.Interfaces;
using GE.BL.Messages;

namespace Inventory_Management.Forms.Inventory
{
    public partial class Frm_inventory : FormBase
    {
        private IInventoryProductService _inventoryProductService;
        private readonly IProductService _productService;
        private readonly ISupplierService _supplierService;
        private List<GE.BL.Entities.Inventory> _productsToBeAdd;
        private Frm_inventory_mode _mode;
        public Frm_inventory(IInventoryProductService inventoryProductService, IProductService productService, ISupplierService supplierService)
        {
            InitializeComponent();
            _inventoryProductService = inventoryProductService;
            _productService = productService;
            _supplierService = supplierService;

            if (_productsToBeAdd == null)
                _productsToBeAdd = new List<GE.BL.Entities.Inventory>();
        }

        public void SetMode(Frm_inventory_mode mode)
        {
            _mode = mode;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var supplier = GetSupplierByCnpj();

                foreach (var item in _productsToBeAdd)
                {
                    item.SupplierId = supplier.Id;

                    if(_mode.Equals(Frm_inventory_mode.Frm_input))
                        _inventoryProductService.Save(item);
                    else
                        _inventoryProductService.Remove(item);
                };

                MessageBox.Show(SuccessMessages.inputSavedSuccess);

                ResetForm(this);

            }catch(NotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }catch(GuidParseException ex)
            {
                MessageBox.Show(ex.Message);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product;

                if(!String.IsNullOrEmpty(txt_productId.Text.Trim()))
                    product = GetProductById();
                else
                    product = GetProductByName();

                txt_productName.Text = product.Name;
                txt_productId.Text = product.Id.ToString();
            }
            catch (NotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (GuidParseException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_inventory_input_Load(object sender, EventArgs e)
        {
            txt_docIdentifier.Text = Guid.NewGuid().ToString();

            if (_mode.Equals(Frm_inventory_mode.Frm_output))
                this.Text = "Movimentação de Saída";
            else
                this.Text = "Movimentação de Entrada";
        }

        private void btn_addProductToList_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductById();

                var inventory = new GE.BL.Entities.Inventory
                {
                    productId = product.Id,
                    Amount = decimal.Parse(txt_inputQtd.Text.Trim()),
                    Price = decimal.Parse(txt_inputPrice.Text.Trim())
                };

                _productsToBeAdd.Add(inventory);

                RebindDataGrid();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Product GetProductById()
        {
            return _productService.GetProductById(GuidHelper.TryParse(txt_productId.Text.Trim()));
        }

        private Product GetProductByName()
        {
            return _productService.GetProductByName(txt_productName.Text.Trim());
        }

        private GE.BL.Entities.Supplier GetSupplierByCnpj()
        {
            return _supplierService.GetSupplierByCnpj(txt_supplierCnpj.Text.Trim());
        }

        private void RebindDataGrid()
        {
            grd_productToSave.DataSource = null;
            grd_productToSave.DataSource = _productsToBeAdd;
        }

        private void btn_searchSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                var supplier = GetSupplierByCnpj();
                txt_supplierName.Text = supplier.Name;
            }
            catch (NotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
