using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserServiceBase;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using System.Security.Claims;
using GPSTracker.DAL.Entities;
using UserServiceImplementation;
using WEB.Models.Identity;

namespace WEB.Controllers
{
    public class AccountController : Controller
    {
        private IUserService UserService
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<IUserService>();
            }
        }
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        public SignInManager<User, int> SignInManager
        {
            get
            {
                return HttpContext.GetOwinContext().Get<SignInManager<User, int>>();
            }
        }
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model)
        {
            //await SetInitialDataAsync();
            if (ModelState.IsValid)
            {
                /*
                User user = new User { Email = model.Email};
                ClaimsIdentity claim = await UserService.Authenticate(user, model.Password);
                if (claim == null)
                {
                    ModelState.AddModelError("", "Неверный логин или пароль.");
                }
                else
                {
                    AuthenticationManager.SignOut();
                    AuthenticationManager.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = true
                    }, claim);
                    return RedirectToAction("Index", "Home");
                }*/
                User user = new User { Email = model.Email };
                var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.IsPersistent, model.ShouldLockout);
                switch (result)
                {
                    case SignInStatus.Success:
                        return RedirectToAction("Index", "Home");
                    case SignInStatus.LockedOut:
                        return View("Lockout");
                    //case SignInStatus.RequiresVerification:
                    //    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                    case SignInStatus.Failure:
                    default:
                        ModelState.AddModelError("", "Неудачная попытка входа.");
                        return View(model);
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            //await SetInitialDataAsync();
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Email = model.Email,
                    UserName = model.Name
                };
                IOperationDetails operationDetails = await UserService.Create(user, model.Password);
                if (operationDetails.Succedeed)
                    return View("SuccessRegister");
                else
                    ModelState.AddModelError(operationDetails.Property, operationDetails.Message);
            }
            return View(model);
        }
        /*
        private async Task SetInitialDataAsync()
        {
            await UserService.SetInitialData(new User
            {
                Email = "erkinkamilov@mail.ru",
                UserName = "erkinkamilov@mail.ru",
                PasswordHash = "1324576",
                Name = "Камилов Эркин Махмуджанович",
                Address = "ул. Спортивная, д.30, кв.75",
                Role = "admin",
            }, new List<string> { "user", "admin" });
        }*/
    }
}