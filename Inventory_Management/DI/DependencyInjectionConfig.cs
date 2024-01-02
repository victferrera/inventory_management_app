using Forms.Inventory.Reports;
using Forms.Products.Edit;
using Forms.Products.New;
using Forms.Suppliers;
using GE.BL.Interfaces;
using GE.BL.Validators;
using GE.Repository.Addresss;
using GE.Repository.Contacts;
using GE.Repository.Inventory;
using GE.Repository.Products;
using GE.Repository.Suppliers;
using GE.Services.Addresss;
using GE.Services.Contacts;
using GE.Services.Products;
using GE.Services.Suppliers;
using GE.Services.ZipCode;
using Gerenciamento_Estoque.Services;
using Inventory_Management.Forms.Inventory;
using Inventory_Management.Forms.Report.Supplier;
using Microsoft.Extensions.DependencyInjection;

namespace Inventory_Management
{
    public class DependencyInjectionConfig
    {
        private static IServiceProvider serviceProvider;
        private static IServiceCollection services;

        private DependencyInjectionConfig() { }

        public static IServiceProvider GetServiceProviderInstance() {
            if (serviceProvider == null)
            {
                BuildServices();
            }

            return serviceProvider;
        }

        private static void BuildServices()
        {
            services = new ServiceCollection();

            services.AddTransient<Frm_main>();
            services.AddTransient<Frm_product_new>();
            services.AddTransient<Frm_product_edit>();
            services.AddTransient<Frm_supplier>();
            services.AddTransient<Frm_inventory_all_products>();
            services.AddTransient<Frm_supplier_all_suppliers>();
            services.AddTransient<Frm_inventory>();

            services.AddSingleton<IInventoryProductService, InventoryProductService>();
            services.AddSingleton<IInventoryProductRepository, InventoryProductRepository>();
            services.AddSingleton<ISupplierRepository, SupplierRepository>();
            services.AddSingleton<ISupplierService, SupplierService>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IContactRepository, ContactRepository>();
            services.AddSingleton<IContactService, ContactService>();
            services.AddSingleton<IZipCodeService, ZipCodeService>();
            services.AddSingleton<IAddressRepository, AddressRepository>();
            services.AddSingleton<IAddressService, AddressService>();
            services.AddSingleton<ProductValidator>();
            services.AddSingleton<AddressValidator>();
            services.AddSingleton<ContactValidator>();
            services.AddSingleton<SupplierValidator>();

            serviceProvider = services.BuildServiceProvider();
        }
    }
}
