using GE.BL.Entities;
using GE.BL.Exceptions;
using GE.BL.Interfaces;
using GE.BL.Messages;

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
            var supplier = new Supplier
            {
                Name = txt_supplierName.Text.Trim(),
                Cnpj = txt_supplierCnpj.Text.Trim(),
                Status = chk_supplierStatus.Checked,
                Contact = new Contact
                {
                    Email = txt_supplierEmail.Text.Trim(),
                    Phone1 = txt_supplierPhone1.Text.Trim(),
                    Phone2 = txt_supplierPhone2.Text.Trim(),
                    Address = new Address
                    {
                        ZipCode = txt_supplierZipCode.Text.Trim(),
                        Street = txt_supplierStreet.Text.Trim(),
                        Neighborhood = txt_supplierBairro.Text.Trim(),
                        HouseNumber = txt_supplierHouseNumber.Text.Trim(),
                        City = txt_supplierCity.Text.Trim(),
                        State = cmb_supplierUf.Text.Trim()
                    }
                }
            };

            try
            {
                _supplierService.Save(supplier);
                MessageBox.Show(SuccessMessages.supplierSavedSuccess);
            }catch(ValidatorException ex)
            {
                MessageBox.Show(String.Join("\n", ex.errors));
            }
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
