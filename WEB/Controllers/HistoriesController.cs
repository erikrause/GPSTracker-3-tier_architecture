using GPSTracker.DAL.Entities;
using HistoryServiceBase;
using ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB.Controllers.Abstract;
using WEB.Models;

namespace WEB.Controllers
{
    public class HistoriesController : CRUDController<History, HistoryViewModel>
    {
        public HistoriesController(IHistoryService CRUDservice) : base(CRUDservice)
        {
        }
    }
}