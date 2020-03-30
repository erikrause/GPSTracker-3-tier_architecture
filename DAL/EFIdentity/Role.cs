using DAL.EFIdentity;
using GPSTracker.DAL.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFIdentity
{
    public class Role : IdentityRole<int, UserRole>, IEntity
    {
        //public int Id { get; set; }
        public bool Archived { get; set; }
    }
}
