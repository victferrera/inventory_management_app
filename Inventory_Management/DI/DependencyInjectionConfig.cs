using Forms.Inventory.Reports;
using Forms.Products.Edit;
using Forms.Products.New;
using Froms.Supplier;
using GE.BL.Interfaces;
using GE.BL.Validators;
using GE.Repository.Inventory;
using GE.Repository.Products;
using GE.Repository.Suppliers;
using GE.Services.Products;
using GE.Services.Suppliers;
using Gerenciamento_Estoque.Services;
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
            services.AddTransient<Frm_supplier_new>();
            services.AddTransient<Frm_inventory_all_products>();

            services.AddSingleton<IInventoryProductService, InventoryProductService>();
            services.AddSingleton<IInventoryProductRepository, InventoryProductRepository>();
            services.AddSingleton<ISupplierRepository, SupplierRepository>();
            services.AddSingleton<ISupplierService, SupplierService>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<ProductValidator>();

            serviceProvider = services.BuildServiceProvider();
        }
    }
}
