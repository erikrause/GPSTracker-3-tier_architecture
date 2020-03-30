using ClientServiceImplementation;
using ClientServiceBase;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IClientService>().To<ClientService>();
        }
    }
}