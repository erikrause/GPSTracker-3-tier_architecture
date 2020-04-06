using ClientServiceImplementation;
using ClientServiceBase;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceBase;
using CRUDService;

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