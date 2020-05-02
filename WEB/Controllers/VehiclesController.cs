using GPSTracker.DAL.Entities;
using ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using VehicleServiceBase;
using WEB.Controllers.Abstract;
using WEB.Models;

namespace WEB.Controllers
{
    public class VehiclesController : CRUDController<Vehicle, VehicleViewModel>
    {
        public VehiclesController(IVehicleService CRUDservice) : base(CRUDservice)
        {
        }
    }
}
