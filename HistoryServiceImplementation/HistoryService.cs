using CRUDServiceImplementation;
using GPSTracker.DAL.Entities;
using GPSTracker.DAL.Interfaces;
using HistoryServiceBase;
using System;
using System.Collections.Generic;
using System.Data.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryServiceImplementation
{
    public class HistoryService : CRUDService<History>, IHistoryService
    {
        public HistoryService(IRepository repo) : base(repo)
        {
        }
    }
}
