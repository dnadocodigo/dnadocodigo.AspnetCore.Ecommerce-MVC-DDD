using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Generics
{
    public interface IGenericApp
    { 
        //Crud
        Task Add(T obj);
        Task Update(T obj);
        Task Delete(T obj);

        //Pesquisa
        Task<T> GetEntityById(int Id);
        Task<List<T>> List();
    }
}
