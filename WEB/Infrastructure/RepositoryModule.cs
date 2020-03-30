using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GPSTracker.DAL.Interfaces;
using GPSTracker.DAL.EF;

namespace WEB.Infrastructure
{
    public class RepositoryModule : NinjectModule
    {
        protected string ConnectionString;
        public RepositoryModule(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public override void Load()
        {
            Bind<IRepository>().To<RepositorySQL>().WithConstructorArgument(ConnectionString);
        }
    }
}