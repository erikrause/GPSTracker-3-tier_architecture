using CRUDServiceImplementation;
using GPSTracker.DAL.Entities;
using GPSTracker.DAL.Interfaces;
using PaymentServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceImplementation
{
    public class PaymentService : CRUDService<Payment>, IPaymentService
    {
        public PaymentService(IRepository repo) : base(repo)
        {
        }
    }
}
