using Domain.Interfaces.IServices.Products;
using Domain.Interfaces.Products;
using Entity.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProduct _Iproduct;

        public ProductService(IProduct Iproduct)
        {
            _Iproduct = Iproduct;
        }

        public async Task ProductAdd(Product product)
        {
            var validateName = product.StringPropertyValidations(product.Name, "Name");
            var validateValues = product.DecimalPropertyValidations(product.Value, "Value");
            var validateQauntityStock = product.IntPropertyValidations(product.QuantityStock, "QuantityStock");

            if (validateName && validateValues && validateQauntityStock)
            {
                product.RegistrationDate = DateTime.Now;
                product.ChangeDate = DateTime.Now;
                product.Status = true;
                await _Iproduct.Add(product);
            }
        }

        public async Task ProductUpdate(Product product)
        {
            var validateName = product.StringPropertyValidations(product.Name, "Name");
            var validateValues = product.DecimalPropertyValidations(product.Value, "Value");
            var validateQauntityStock = product.IntPropertyValidations(product.QuantityStock, "QuantityStock");

            if (validateName && validateValues && validateQauntityStock)
            {
                product.ChangeDate = DateTime.Now;
                await _Iproduct.Update(product);
            }
        }

        public async Task<List<Product>> ProductsListWithStock()
        {
            return await _Iproduct.ProductsList(p => p.QuantityStock > 0);
        }
    }
}