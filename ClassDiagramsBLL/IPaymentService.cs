using GPSTracker.DAL.Entities;
using ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceBase
{
    public interface IPaymentService : ICRUDService<Payment>
    {
    }
}
