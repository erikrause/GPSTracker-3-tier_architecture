using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WEB.Infrastructure;

namespace WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Ninject Bindings:
            NinjectModule serviceModule = new ServiceModule();
            NinjectModule repositoryModule = new RepositoryModule("DefaultConnection");//("GPSTrackerContext");
            var kernel = new StandardKernel(serviceModule, repositoryModule);
            kernel.Unbind<ModelValidatorProvider>();        // View validation bug (in create) without this unbind.
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
