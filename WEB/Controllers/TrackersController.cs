using GPSTracker.DAL.Entities;
using ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackerServiceBase;
using WEB.Controllers.Abstract;
using WEB.Models;

namespace WEB.Controllers
{
    public class TrackersController : CRUDController<Tracker, TrackerViewModel>
    {
        public TrackersController(ITrackerService CRUDservice) : base(CRUDservice)
        {
        }
    }
}