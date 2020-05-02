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
    public class PaymentsController : CRUDController<Payment, PaymentViewModel>
    {
        public PaymentsController(ICRUDService<Payment> CRUDservice) : base(CRUDservice)
        {
        }

        // GET: Payments
        public ActionResult Index()
        {
            return View();
        }
    }
}