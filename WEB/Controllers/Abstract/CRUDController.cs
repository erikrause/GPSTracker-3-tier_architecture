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
    public class CRUDController<TEntity, TEntityViewModel> : Controller where TEntity : class, IEntity 
                                                   where TEntityViewModel : class, IEntityViewModel
    {
        ICRUDService<TEntity> CRUDService;
        IMapper Mapper;
        public CRUDController(ICRUDService<TEntity> CRUDservice)
        {
            this.CRUDService = CRUDservice;
            Mapper = new MapperConfiguration(cfg => cfg.CreateMap<TEntity, TEntityViewModel>().ReverseMap()).CreateMapper();

        }
        // GET: CRUD
        public virtual async Task<ActionResult> Index()
        {
            IEnumerable<TEntity> entities = await CRUDService.GetAll();
            var entitiesViewModel = Mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityViewModel>>(entities);
            //var prob = mapper.Map<IEnumerable<U>>(entities);
            //var prob2 = mapper.Map<IEnumerable<T>>(prob);
            return View(entitiesViewModel);
        }

        // GET: CRUD/Details/5
        public virtual async Task<ActionResult> Details(int id)
        {
            return View(Mapper.Map<TEntityViewModel>(await CRUDService.Get(id)));
        }

        // GET: CRUD/Create
        public virtual async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: CRUD/Create
        [HttpPost]
        public virtual async Task<ActionResult> Create(TEntityViewModel entityViewModel)
        {
            try
            {
                TEntity entity = Mapper.Map<TEntityViewModel, TEntity>(entityViewModel);
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
            return View(Mapper.Map<TEntityViewModel>(await CRUDService.Get(id)));
        }

        // POST: CRUD/Edit/5
        [HttpPost]
        public virtual async Task<ActionResult> Edit(int id, TEntityViewModel entityViewModel)
        {
            try
            {
                TEntity entity = Mapper.Map<TEntity>(entityViewModel);
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
            return View(Mapper.Map<TEntityViewModel>(await CRUDService.Get(id)));
        }

        // POST: CRUD/Delete/5
        [HttpPost]
        public virtual async Task<ActionResult> Delete(int id, TEntityViewModel entityVievModel)
        {
            try
            {
                TEntity entity = Mapper.Map<TEntity>(entityVievModel);
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
