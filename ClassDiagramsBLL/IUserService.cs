using GPSTracker.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace UserServiceBase
{
    public interface IUserService : IDisposable
    {
        Task<IOperationDetails> Create(User user, string password);
        Task<ClaimsIdentity> Authenticate(string email, string password);
        Task<User> GetCurrent();
        //Task SetInitialData(User admin, List<string> roles);
    }
}
