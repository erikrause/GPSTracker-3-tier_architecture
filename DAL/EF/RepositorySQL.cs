using DAL.EFIdentity;
using GPSTracker.DAL.Entities;
using GPSTracker.DAL.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GPSTracker.DAL.EF
{
    public class RepositorySQL : IRepository
    {
        TrackerContext db;
        public UserManager UserManager { get; private set; }
        public RoleManager RoleManager { get; private set; }
        public RepositorySQL(string connectionString)
        {
            db = new TrackerContext(connectionString);
            UserManager = new UserManager(new UserStore<User, Role, int, UserLogin, UserRole, UserClaim>(db));
            RoleManager = new RoleManager(new RoleStore<Role, int, UserRole>(db));
        }
        public async Task<T> Get<T>(int id) where T : class, IEntity
        {
            return await db.Set<T>().SingleOrDefaultAsync(t => t.Id == id);
        }
        public async Task Save<T>(T entity) where T : class, IEntity
        {
            if (entity.Id < 1)
            {
                db.Set<T>().Add(entity);
                await db.SaveChangesAsync();
            }
            else
            {
                var cache = db.Set<T>().Find(entity.Id);
                db.Entry<T>(cache).CurrentValues.SetValues(entity);
                await db.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<T>> GetAll<T>() where T : class, IEntity
        {
            //return await db.Set<T>().OrderBy(t => t.Id).ToListAsync();//.AsQueryable(); // спросить у Егорова
            var result = await db.Set<T>().OrderBy(t => t.Id).ToListAsync();
            return result.AsQueryable();    // спросить у егорова
        }
        public async Task Remove<T>(T entity) where T : class, IEntity
        {
            var cache = await db.Set<T>().FindAsync(entity.Id);    //Todo
            //db.Set<T>().Remove(cache);
            cache.Archived = true;
            db.Entry(cache).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
        public async Task<IEnumerable<T>> GetBy<T>(Expression<Func<T, bool>> predicate) where T : class, IEntity
        {
            var result = await db.Set<T>().Where(predicate).ToListAsync();
            return result;
            //return result.AsQueryable();
        }

        public async Task Update<T>(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
        public void Dispose()     // Async?
        {
            db.Dispose();
        }
    }
}
