using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
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
