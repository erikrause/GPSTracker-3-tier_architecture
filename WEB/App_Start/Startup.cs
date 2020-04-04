using DAL.EFIdentity;
using GPSTracker.DAL.EF;
using GPSTracker.DAL.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserServiceBase;
using UserServiceImplementation;

[assembly: OwinStartup(typeof(WEB.App_Start.Startup))]

namespace WEB.App_Start
{
    public class Startup
    {
        IServiceCreator ServiceCreator = new ServiceCreator();
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<IUserService>(CreateUserService);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }
        private IUserService CreateUserService()
        {
            return ServiceCreator.CreateUserService("DefaultConnection");
        }
    }
}