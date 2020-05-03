using CRUDServiceImplementation;
using GPSTracker.DAL.Entities;
using ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerServiceBase
{
    public interface ITrackerService : ICRUDService<Tracker>
    {
    }
}
