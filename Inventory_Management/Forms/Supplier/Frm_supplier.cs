using GE.BL.Entities;
using GE.BL.Interfaces;

namespace Forms.Suppliers
{
    public partial class Frm_supplier : Form
    {
        private readonly ISupplierService _supplierService;
        private readonly IZipCodeService _zipCodeService;
        private readonly IAddressService _addressService;
        public Frm_supplier(ISupplierService supplierService, IZipCodeService zipCodeService, IAddressService addressService)
        {
            InitializeComponent();
            _supplierService = supplierService;
            _zipCodeService = zipCodeService;
            _addressService = addressService;
        }

        private void Frm_supplier_saveBtn_Click(object sender, EventArgs e)
        {

        }

        private void Frm_supplier_SearchZipCodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var response = _zipCodeService.GetZipCodeInfo(txt_supplierZipCode.Text.Trim());
                fillAddressFields(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillAddressFields(Address address)
        {
            txt_supplierStreet.Text = address.Street;
            txt_supplierCity.Text = address.City;
            txt_supplierBairro.Text = address.Neighborhood;
            cmb_supplierUf.Text = address.State;
        }

        private void Frm_supplier_Load(object sender, EventArgs e)
        {
            cmb_supplierUf.DataSource = _addressService.GetStateList();
        }
    }
}
