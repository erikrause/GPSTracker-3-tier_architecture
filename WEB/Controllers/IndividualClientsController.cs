using AutoMapper;
using ClientServiceBase;
using GPSTracker.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UserServiceBase;
using WEB.Models;

namespace WEB.Controllers
{
    [Authorize]
    public class IndividualClientsController : Controller
    {
        IClientService ClientService;
        IUserService UserService;
        IMapper _mapper;
        public IndividualClientsController(IClientService clientService, IUserService userService)
        {
            ClientService = clientService;
            UserService = userService;
            _mapper = new MapperConfiguration(cfg => cfg.CreateMap<IndividualClient, IndividualClientViewModel>().ReverseMap()).CreateMapper();
        }
        // GET: IndividualClients
        public async Task<ActionResult> Index()
        {
            var individualClients = await ClientService.GetIndividualClients();
            var individualClientsViewModel = _mapper.Map < IEnumerable < IndividualClientViewModel >> (individualClients);

            return View(individualClientsViewModel);
        }

        // GET: IndividualClients/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var individualClient = await ClientService.GetIndividualClient(id);

            return View(_mapper.Map<IndividualClientViewModel>(individualClient));
        }

        // GET: IndividualClients/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: IndividualClients/Create
        [HttpPost]
        public async Task<ActionResult> Create(IndividualClientViewModel individualClientViewModel)
        {
            try
            {
                var individualClient = _mapper.Map<IndividualClient>(individualClientViewModel);
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
            var individualClient = await ClientService.GetIndividualClient(id);

            return View(_mapper.Map<IndividualClientViewModel>(individualClient));
        }

        // POST: IndividualClients/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, IndividualClientViewModel individualClientViewModel)
        {
            try
            {
                var individualClient = _mapper.Map<IndividualClient>(individualClientViewModel);
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
            var individualCLient = await ClientService.GetLegalClient(id);
            return View(_mapper.Map<IndividualClientViewModel>(individualCLient));
        }

        // POST: IndividualClients/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, IndividualClientViewModel individualClientViewModel)
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
