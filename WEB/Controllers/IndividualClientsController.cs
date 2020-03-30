using ClientServiceBase;
using GPSTracker.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WEB.Controllers
{
    public class IndividualClientsController : Controller
    {
        IClientService ClientService;
        public IndividualClientsController(IClientService clientService)
        {
            ClientService = clientService;
        }
        // GET: IndividualClients
        public async Task<ActionResult> Index()
        {
            return View(await ClientService.GetIndividualClients());
        }

        // GET: IndividualClients/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await ClientService.GetIndividualClient(id));
        }

        // GET: IndividualClients/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: IndividualClients/Create
        [HttpPost]
        public async Task<ActionResult> Create(IndividualClient individualClient)
        {
            try
            {
                await ClientService.CreateIndividualClient(individualClient);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: IndividualClients/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await ClientService.GetIndividualClient(id));
        }

        // POST: IndividualClients/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, IndividualClient individualClient)
        {
            try
            {
                await ClientService.UpdateIndividualClient(individualClient);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: IndividualClients/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await ClientService.GetLegalClient(id));
        }

        // POST: IndividualClients/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, FormCollection collection)
        {
            try
            {
                await ClientService.DeleteIndividualClient(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
