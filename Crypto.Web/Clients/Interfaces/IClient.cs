using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto.Web.Clients.Interfaces
{
    public interface IClient<T> where T : class
    {
        Task<IEnumerable<T>> GetAllItems();
        Task<T> GetAll();
        Task<T> GetById(int id);
        Task<bool> Create(T entity);
        Task<bool> Update(int entityId, T entity);
        Task<bool> Delete(int id);
        Task<IEnumerable<T>> GetCompositionByProduct(string name);
        Task<bool> Add_quantity(string product, int num, T entity); 
    }
}
