using AutoMapper;
using GPSTracker.DAL.Interfaces;
using ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEB.Models;

namespace WEB.Controllers.Abstract
{
    public class CRUDController<T, U> : Controller where T : class, IEntity 
                                                   where U : class, IEntityViewModel
    {
        ICRUDService<T> CRUDService;
        IMapper Mapper;
        public CRUDController(ICRUDService<T> CRUDservice)
        {
            this.CRUDService = CRUDservice;
            Mapper = new MapperConfiguration(cfg => cfg.CreateMap<T, U>().ReverseMap()).CreateMapper();

        }
        // GET: CRUD
        public virtual async Task<ActionResult> Index()
        {
            IEnumerable<T> entities = await CRUDService.GetAll();
            var entitiesViewModel = Mapper.Map<IEnumerable<T>, IEnumerable<U>>(entities);
            //var prob = mapper.Map<IEnumerable<U>>(entities);
            //var prob2 = mapper.Map<IEnumerable<T>>(prob);
            return View(entitiesViewModel);
        }

        // GET: CRUD/Details/5
        public virtual async Task<ActionResult> Details(int id)
        {
            return View(Mapper.Map<U>(await CRUDService.Get(id)));
        }

        // GET: CRUD/Create
        public virtual async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: CRUD/Create
        [HttpPost]
        public virtual async Task<ActionResult> Create(U entityViewModel)
        {
            try
            {
                T entity = Mapper.Map<U, T>(entityViewModel);
                await CRUDService.Create(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CRUD/Edit/5
        public virtual async Task<ActionResult> Edit(int id)
        {
            return View(Mapper.Map<U>(await CRUDService.Get(id)));
        }

        // POST: CRUD/Edit/5
        [HttpPost]
        public virtual async Task<ActionResult> Edit(int id, U entityViewModel)
        {
            try
            {
                T entity = Mapper.Map<T>(entityViewModel);
                await CRUDService.Update(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CRUD/Delete/5
        public virtual async Task<ActionResult> Delete(int id)
        {
            return View(Mapper.Map<U>(await CRUDService.Get(id)));
        }

        // POST: CRUD/Delete/5
        [HttpPost]
        public virtual async Task<ActionResult> Delete(int id, U entityVievModel)
        {
            try
            {
                T entity = Mapper.Map<T>(entityVievModel);
                await CRUDService.Delete(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
