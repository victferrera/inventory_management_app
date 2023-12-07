using GE.BL.Entities;
using GE.BL.Exceptions;
using GE.BL.Helpers;
using GE.BL.Interfaces;

namespace Forms.Products.Edit
{
    public partial class Frm_product_edit : Form
    {
        private readonly IProductService _productService;
        public Frm_product_edit(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void btn_frmedit_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product(GuidHelper.TryParse(txt_edit_productId.Text.Trim()), txt_edit_name.Text.Trim(), txt_edit_desc.Text.Trim());

                _productService.Update(product);
            }
            catch(NotFoundException ex)
            {
                MessageBox.Show(String.Join("\n", ex.Message));
            }
            catch (GuidParseException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_frmedit_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                var product = _productService.GetProductById(GuidHelper.TryParse(txt_edit_productId.Text.Trim()));
                fillFields(product);
            }catch(NotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (GuidParseException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_frmedit_remover_Click(object sender, EventArgs e)
        {
               
        }

        private void fillFields(Product product)
        {
            txt_edit_name.Text = product.Name;
            txt_edit_desc.Text = product.Description;
            txt_edit_productId.Text = product.Id.ToString();
        }
    }
}
