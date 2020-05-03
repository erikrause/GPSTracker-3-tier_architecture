using CRUDServiceImplementation;
using GPSTracker.DAL.Entities;
using GPSTracker.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleServiceBase;

namespace VehicleServiceImplementation
{
    public class VehicleService : CRUDService<Vehicle>, IVehicleService
    {
        public VehicleService(IRepository repo) : base(repo)
        {
        }
    }
}
