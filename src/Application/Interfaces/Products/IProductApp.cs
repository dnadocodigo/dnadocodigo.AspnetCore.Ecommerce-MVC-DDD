using Application.Interfaces.Generics;
using Entity.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Products
{
    public interface IProductApp : IGenericApp<Product>
    {
        //Custumizados
        Task ProductAdd(Product product);
        Task ProductUpdate(Product product);
    }
}
