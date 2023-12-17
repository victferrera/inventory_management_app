using GE.BL.Entities;
using GE.BL.Exceptions;
using GE.BL.Interfaces;
using GE.BL.Messages;
using Inventory_Management.Forms;

namespace Forms.Products.New
{
    public partial class Frm_product_new : FormBase
    {
        private readonly IProductService _productService;
        public Frm_product_new(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_novo_btn_salvar_Click(object sender, EventArgs e)
        {
            Product product = new(Guid.NewGuid(), txt_new_productName.Text.Trim(), txt_new_productDesc.Text.Trim());

            try
            {
                _productService.Save(product);
                MessageBox.Show(SuccessMessages.productSavedSuccess);
                ResetForm(this);
            }
            catch (ValidatorException ex)
            {
                MessageBox.Show(string.Join("\n", ex.errors));
            }
            catch (DataAlreadyExistsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
