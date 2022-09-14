using Application.Interfaces.Products;
using Domain.Interfaces.IServices.Products;
using Domain.Interfaces.Products;
using Entity.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.OpenApp.Products
{
    public class ProductApp : IProductApp
    {
        private readonly IProduct _product;
        private readonly IProductService _productService;
        public ProductApp(IProduct product, IProductService productService)
        {
            _product = product;
            _productService = productService;
        }
        public async Task Add(Product obj)
        {
            await _product.Add(obj);
        }

        public async Task Delete(Product obj)
        {
            await _product.Delete(obj);
        }

        public async Task Update(Product obj)
        {
            await _product.Update(obj);
        }

        //Pesquisa
        public async Task<Product> GetEntityById(int Id)
        {
            return await _product.GetEntityById(Id);
        }

        public async Task<List<Product>> List()
        {

            return await _product.List();
        }


        //Custumizados
        public async Task ProductAdd(Product product)
        {
            await _productService.ProductAdd(product);
        }

        public async Task ProductUpdate(Product product)
        {
            await _productService.ProductUpdate(product);
        }

    }
}
