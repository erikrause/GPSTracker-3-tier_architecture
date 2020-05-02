using GPSTracker.DAL.Entities;
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
    public class ContractsController : CRUDController<Contract, ContractViewModel>
    {
        public ContractsController(ICRUDService<Contract> CRUDservice) : base(CRUDservice)
        {
        }

        // GET: Contracts
        public ActionResult Index()
        {
            return View();
        }
    }
}