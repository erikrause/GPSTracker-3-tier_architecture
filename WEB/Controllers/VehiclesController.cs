using GPSTracker.DAL.Entities;
using ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using VehicleServiceBase;

namespace WEB.Controllers
{
    public class VehiclesController : Controller
    {
        //ICRUDService<Vehicle> VehicleService;
        IVehicleService VehicleService;
        public VehiclesController(IVehicleService vehicleService)
        {
            VehicleService = vehicleService;
        }
        // GET: Vehicle
        public async Task<ActionResult> Index()
        {
            return View(await VehicleService.GetAll());
        }

        // GET: Vehicle/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await VehicleService.Get(id));
        }

        // GET: Vehicle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vehicle/Create
        [HttpPost]
        public async Task<ActionResult> Create(Vehicle vehicle)
        {
            try
            {
                await VehicleService.Create(vehicle);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vehicle/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await VehicleService.Get(id));
        }

        // POST: Vehicle/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, Vehicle vehicle)
        {
            try
            {
                await VehicleService.Update(vehicle);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vehicle/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await VehicleService.Get(id));
        }

        // POST: Vehicle/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, Vehicle vehicle)
        {
            try
            {
                await VehicleService.Delete(vehicle);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
