using GE.BL.Entities;
using GE.BL.Exceptions;
using GE.BL.Helpers;
using GE.BL.Interfaces;
using GE.BL.Messages;
using Inventory_Management.Forms;
using Inventory_Management.Forms.Supplier;
using System.Text.RegularExpressions;

namespace Forms.Suppliers
{
    public partial class Frm_supplier : FormBase
    {
        private readonly ISupplierService _supplierService;
        private readonly IZipCodeService _zipCodeService;
        private readonly IAddressService _addressService;
        private Frm_supplier_mode _mode;
        public Frm_supplier(ISupplierService supplierService, IZipCodeService zipCodeService, IAddressService addressService)
        {
            InitializeComponent();
            _supplierService = supplierService;
            _zipCodeService = zipCodeService;
            _addressService = addressService;
        }

        public void SetFormMode(Frm_supplier_mode frmMode)
        {
            _mode = frmMode;
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
                if (_mode.Equals(Frm_supplier_mode.Frm_save))
                    _supplierService.Save(supplier);
                else if (_mode.Equals(Frm_supplier_mode.Frm_edit))
                    _supplierService.Update(supplier);

                MessageBox.Show(SuccessMessages.supplierSavedSuccess);
                ResetForm(this);
            }
            catch (ValidatorException ex)
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
            txt_supplierZipCode.Text = address.ZipCode;
            txt_supplierHouseNumber.Text = address.HouseNumber;
            txt_supplierStreet.Text = address.Street;
            txt_supplierCity.Text = address.City;
            txt_supplierBairro.Text = address.Neighborhood;
            cmb_supplierUf.Text = address.State;
        }

        private void Frm_supplier_Load(object sender, EventArgs e)
        {
            cmb_supplierUf.DataSource = _addressService.GetStateList();
        }

        private void txt_supplierCnpj_Leave(object sender, EventArgs e)
        {
            txt_supplierCnpj.Text = removeSpecialChar(txt_supplierCnpj.Text);
        }

        private static string removeSpecialChar(string str)
        {
            return Regex.Replace(str, "[^0-9]+", "", RegexOptions.Compiled);
        }

        private void Frm_supplier_search_Click(object sender, EventArgs e)
        {
            try
            {
                fillSupplierFields(_supplierService.GetSupplierByCnpj(txt_supplierCnpj.Text.Trim()));
                
            }catch(NotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillSupplierFields(Supplier supplier)
        {
            txt_supplierName.Text = supplier.Name;
            chk_supplierStatus.Checked = supplier.Status;
            txt_supplierEmail.Text = supplier.Contact.Email;
            txt_supplierPhone1.Text = supplier.Contact.Phone1;
            txt_supplierPhone2.Text = supplier.Contact.Phone2;
            fillAddressFields(supplier.Contact.Address);
        }
    }
}
