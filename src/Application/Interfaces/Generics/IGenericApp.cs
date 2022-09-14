using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Generics
{
    /// <summary>
    /// Interface genérica 
    /// para definir os métodos
    /// que serão dispomibilizados
    /// para a aplicação
    /// </summary>
    public interface IGenericApp<T> where T : class
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
