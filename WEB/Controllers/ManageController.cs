using ClientServiceBase;
using GPSTracker.DAL.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UserServiceBase;

namespace WEB.Controllers
{
    public class ManageController : Controller
    {
        private IUserService UserService
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<IUserService>();
            }
        }
        private IClientService ClientService;
        public ManageController(IClientService clientService)
        {
            ClientService = clientService;
        }
        // GET: Manage
        [Authorize]
        public async Task<ActionResult> Index()
        {
            User user = await UserService.GetCurrent();
            return View(user.Client);
        }
    }
}