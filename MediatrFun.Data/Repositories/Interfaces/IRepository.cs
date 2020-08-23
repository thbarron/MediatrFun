using System.Collections.Generic;
using System.Threading.Tasks;
using MediatrFun.Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MediatrFun.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<EntityEntry<Book>> Add(T item);
        Task<T> Update(T item);
    }
}