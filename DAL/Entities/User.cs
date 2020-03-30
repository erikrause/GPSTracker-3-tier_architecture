using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GPSTracker.DAL.Interfaces;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using DAL.EFIdentity;

namespace GPSTracker.DAL.Entities
{
    public class User : IdentityUser<int, UserLogin, UserRole, UserClaim>, IEntity
    {

        [MaxLength(255)]
        //public string UserName { get; set; }

        //[MaxLength(255)]
        //public string PasswordHash { get; set; }
        public int ClientId { get; set; }

        public Client Client { get; set; }
        public bool Archived { get; set; }

        // public Tariff Tariff { get; set; }
    }
}
