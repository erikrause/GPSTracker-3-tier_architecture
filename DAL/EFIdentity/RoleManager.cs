using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFIdentity
{
    public class RoleManager : RoleManager<Role, int>
    {
        public RoleManager(RoleStore<Role, int, UserRole> store) : base(store)    //TODO: bind to RoleStore
        {
        }
    }
}
