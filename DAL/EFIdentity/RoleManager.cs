using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFIdentity
{
    public class RoleManager : RoleManager<Role, int>
    {
        public RoleManager(IRoleStore<Role, int> store) : base(store)    //TODO: bind to RoleStore
        {
        }
    }
}
