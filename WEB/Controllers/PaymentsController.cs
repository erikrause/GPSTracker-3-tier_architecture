using GPSTracker.DAL.Entities;
using PaymentServiceBase;
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
        public PaymentsController(IPaymentService CRUDservice) : base(CRUDservice)
        {
        }
    }
}