using CRUDServiceImplementation;
using GPSTracker.DAL.Entities;
using GPSTracker.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerServiceBase;

namespace TrackerServiceImplementation
{
    public class TrackerService : CRUDService<Tracker>, ITrackerService
    {
        public TrackerService(IRepository repo) : base(repo)
        {
        }
    }
}
