using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using GPSTracker.DAL.Interfaces;

namespace GPSTracker.DAL.Interfaces
{
    public interface IRepository
    {
        Task<T> Get<T>(int id) where T : class, IEntity;
        Task Save<T>(T entity) where T : class, IEntity;
        Task<IEnumerable<T>> GetAll<T>() where T : class, IEntity;
        Task Remove<T>(T entity) where T : class, IEntity;
        Task<IEnumerable<T>> GetBy<T>(Expression<Func<T,bool>> predicate) where T : class, IEntity;
        Task Update<T>(T entity);
    }
}
