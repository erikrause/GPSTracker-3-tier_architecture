using GPSTracker.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace UserServiceBase
{
    public interface IUserService
    {
        Task<IOperationDetails> Create(User userDto);
        Task<ClaimsIdentity> Authenticate(User userDto);
        Task SetInitialData(User adminDto, List<string> roles);
    }
}
