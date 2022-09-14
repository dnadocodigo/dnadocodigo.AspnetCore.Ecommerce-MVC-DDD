using Domain.Interfaces.Generics;
using Entity.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Products
{
    public interface IProduct : IGeneric<Product>
    {
    }
}
