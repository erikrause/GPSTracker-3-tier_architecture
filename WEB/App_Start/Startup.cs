using DAL.EFIdentity;
using GPSTracker.DAL.EF;
using GPSTracker.DAL.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
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
            //app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);
            //app.CreatePerOwinContext()
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
        // Configure the application sign-in manager which is used in this application.
        /*
        public class ApplicationSignInManager : SignInManager<User, int>
        {
            public ApplicationSignInManager(UserManager userManager, IAuthenticationManager authenticationManager)
                : base(userManager, authenticationManager)
            {
            }

            //public override Task<ClaimsIdentity> CreateUserIdentityAsync(User user)
            //{
            //    return user.GenerateUserIdentityAsync((UserManager)UserManager);
            //}

            public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
            {
                return new ApplicationSignInManager(context.GetUserManager<UserManager>(), context.Authentication);
            }
        }*/
    }
}