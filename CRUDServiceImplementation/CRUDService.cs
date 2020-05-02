using ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSTracker.DAL.Entities;
using GPSTracker.DAL.Interfaces;
using System.Linq.Expressions;

namespace CRUDServiceImplementation
{
    public class CRUDService<T> : ICRUDService<T> where T : class, IEntity
    {
        IRepository Repo;
        public CRUDService(IRepository repo)
        {
            Repo = repo;
        }
        public virtual async Task Create(T entity)
        {
            await Repo.Save(entity);
        }

        public virtual async Task Delete(T entity)
        {
            await Repo.Remove(entity);
        }

        public virtual async Task<T> Get(int id)
        {
            return await Repo.Get<T>(id);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await Repo.GetAll<T>();
        }

        public virtual async Task<IEnumerable<T>> GetBy(Expression<Func<T, bool>> predicate)
        {
            return await Repo.GetBy(predicate);
        }

        public virtual async Task Update(T entity)
        {
            await Repo.Update(entity);
        }
    }
}
