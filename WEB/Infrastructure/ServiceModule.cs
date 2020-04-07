using ClientServiceImplementation;
using ClientServiceBase;
using Ninject.Modules;
using ServiceBase;
using CRUDServiceImplementation;
using VehicleServiceBase;
using VehicleServiceImplementation;
using TrackerServiceBase;
using TrackerServiceImplementation;
using PaymentServiceImplementation;
using PaymentServiceBase;
using ContractServiceBase;
using ContractServiceImplementation;

namespace WEB.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IClientService>().To<ClientService>();
            //Bind(typeof(ICRUDService<>)).To(typeof(CRUDService<>));
            Bind<IVehicleService>().To<VehicleService>();
            Bind<ITrackerService>().To<TrackerService>();
            Bind<IPaymentService>().To<PaymentService>();
            Bind<IContractService>().To<ContractService>();
        }
    }
}