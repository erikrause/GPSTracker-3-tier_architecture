using ClientServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UserServiceBase;

namespace WEB.Controllers
{
    public class ClientController : Controller
    {
        IClientService ClientService;
        IUserService UserService;
        public ClientController(IClientService clientService, IUserService userService)
        {
            ClientService = clientService;
            UserService = userService;
        }
        // GET: Client
        public async Task<ActionResult> Index()
        {
            var currentUser = await UserService.GetCurrent();
            if (currentUser.Client == null)
            {
                return RedirectToAction("Create");
            }
            else
            {
                if (currentUser.Client.IndividualClient != null)
                {
                    return RedirectToAction("Index", "IndividualClientsController");
                }
                else
                    return RedirectToAction("Index", "LegalClientsController");
            }
        }

        // GET: Client/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Client/Create
        //public ActionResult Create()
        //{
         //   return View();
        //}

        
    }
}
