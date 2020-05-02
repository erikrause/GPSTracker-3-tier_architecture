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
    public class LegalClientsController : Controller
    {
        readonly IClientService _clientService;
        readonly IUserService _userService;
        readonly IMapper _mapper;


        public LegalClientsController(IClientService clientService, IUserService userService)
        {
            _clientService = clientService;
            _userService = userService;
            _mapper = new MapperConfiguration(cfg => cfg.CreateMap<LegalClient, LegalClientViewModel>().ReverseMap()).CreateMapper();
        }
        // GET: LegalClients
        public async Task<ActionResult> Index()
        {
            var legalClients = await _clientService.GetLegalClients();
            return View(_mapper.Map<IEnumerable<LegalClientViewModel>>(legalClients));
        }

        // GET: LegalClients/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var legalCLient = await _clientService.GetLegalClient(id);
            return View(_mapper.Map < LegalClientViewModel > (legalCLient));
        }

        // GET: LegalClients/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: LegalClients/Create
        [HttpPost]
        public async Task<ActionResult> Create(LegalClientViewModel legalClientViewModel)
        {
            try
            {
                var legalClient = _mapper.Map<LegalClient>(legalClientViewModel);
                await _clientService.CreateLegalClient(legalClient);

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
            var legalClient = await _clientService.GetLegalClient(id);
            return View(_mapper.Map<LegalClientViewModel>(legalClient));
        }

        // POST: LegalClients/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, LegalClientViewModel legalClientViewModel)
        {
            try
            {
                var legalClient = _mapper.Map<LegalClient>(legalClientViewModel);
                await _clientService.UpdateLegalClient(legalClient);

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
            var legalClient = await _clientService.GetLegalClient(id);
            return View(_mapper.Map<LegalClientViewModel>(legalClient));
        }

        // POST: LegalClients/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, LegalClientViewModel legalClientViewModel)
        {
            try
            {
                await _clientService.DeleteLegalClient(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
