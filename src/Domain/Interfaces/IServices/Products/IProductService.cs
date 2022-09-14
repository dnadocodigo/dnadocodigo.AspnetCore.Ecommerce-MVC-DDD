using Entity.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IServices.Products
{
    public interface IProductService
    {
        //Custumizados
        Task ProductAdd(Product product);
        Task ProductUpdate(Product product);
    }
}
