using GPSTracker.DAL.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFIdentity
{
    public class UserManager : UserManager<User, int>
    {
        public UserManager(UserStore<User, Role, int, UserLogin, UserRole, UserClaim> store) : base(store)   // TODO: bind to UserStore
        {
        }
    }
}
