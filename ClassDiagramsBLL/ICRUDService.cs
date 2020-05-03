using GPSTracker.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBase
{
    /// <summary>
    /// Реализует CRUD-операции.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICRUDService<T> where T : IEntity
    {
        Task Create(T entity);
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetBy(Expression<Func<T, bool>> predicate);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
