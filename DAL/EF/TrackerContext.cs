using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GPSTracker.DAL.Entities;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using DAL.EFIdentity;

namespace GPSTracker.DAL.EF
{
    public class TrackerContext : IdentityDbContext<User, Role,
                                    int, UserLogin, UserRole, UserClaim>
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<IndividualClient> IndividualClients { get; set; }
        public DbSet<LegalClient> LegalClients { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Payment> Payments { get; set; }
        //public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<Tracker> Trackers { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        public TrackerContext()
        {

        }
        public TrackerContext(string connectionString) : base(connectionString)
        {
        }
    }
}
