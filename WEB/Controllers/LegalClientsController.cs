using ClientServiceBase;
using GPSTracker.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UserServiceBase;

namespace WEB.Controllers
{
    [Authorize]
    public class LegalClientsController : Controller
    {
        IClientService ClientService;
        IUserService UserService;

        public LegalClientsController(IClientService clientService, IUserService userService)
        {
            ClientService = clientService;
            UserService = userService;
        }
        // GET: LegalClients
        public async Task<ActionResult> Index()
        {
            return View(await ClientService.GetLegalClients());
        }

        // GET: LegalClients/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await ClientService.GetLegalClient(id));
        }

        // GET: LegalClients/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: LegalClients/Create
        [HttpPost]
        public async Task<ActionResult> Create(LegalClient legalClient)
        {
            try
            {
                User currentUser = await UserService.GetCurrent();
                await ClientService.CreateLegalClient(legalClient, currentUser);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LegalClients/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await ClientService.GetLegalClient(id));
        }

        // POST: LegalClients/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, LegalClient legalClient)
        {
            try
            {
                await ClientService.UpdateLegalClient(legalClient);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LegalClients/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            
            return View(await ClientService.GetLegalClient(id));
        }

        // POST: LegalClients/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, FormCollection collection)
        {
            try
            {
                await ClientService.DeleteLegalClient(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
