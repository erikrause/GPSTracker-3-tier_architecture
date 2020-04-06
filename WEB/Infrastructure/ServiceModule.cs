using ClientServiceImplementation;
using ClientServiceBase;
using Ninject.Modules;
using ServiceBase;
using CRUDServiceImplementation;

namespace WEB.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IClientService>().To<ClientService>();
            Bind(typeof(ICRUDService<>)).To(typeof(CRUDService<>));
        }
    }
}