using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSTracker.DAL.Entities;
using GPSTracker.DAL.Interfaces;
using Microsoft.AspNet.Identity;

namespace UserStoreImplementation
{
    public class UserStore : UserStore
    {
        IRepository Repo;
        public UserStore(IRepository repo)
        {
            Repo = repo;
        }

        public async Task CreateAsync(User user)
        {
            await Repo.Save(user);
        }

        public async Task DeleteAsync(User user)
        {
            await Repo.Remove(user);
        }

        public void Dispose()
        {
        }

        public async Task<User> FindByIdAsync(int userId)
        {
            return await Repo.Get<User>(userId); 
        }

        public async Task<User> FindByNameAsync(string userName)
        {
            return (await Repo.GetBy<User>(x => x.UserName == userName)).FirstOrDefault();
        }

        public async Task UpdateAsync(User user)
        {
            await Repo.Update(user);
        }
    }
}
