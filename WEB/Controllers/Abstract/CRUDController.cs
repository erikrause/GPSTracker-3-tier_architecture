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
    [Authorize]
    public class CRUDController<TEntity, TEntityViewModel> : Controller where TEntity : class, IEntity 
                                                                        where TEntityViewModel : class, IEntityViewModel
    {
        ICRUDService<TEntity> _CRUDService;
        IMapper _mapper;
        public CRUDController(ICRUDService<TEntity> CRUDservice)
        {
            this._CRUDService = CRUDservice;
            _mapper = new MapperConfiguration(cfg => cfg.CreateMap<TEntity, TEntityViewModel>().ReverseMap()).CreateMapper();

        }
        // GET: CRUD
        public virtual async Task<ActionResult> Index()
        {
            IEnumerable<TEntity> entities = await _CRUDService.GetAll();
            var entitiesViewModel = _mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityViewModel>>(entities);
            //var prob = mapper.Map<IEnumerable<U>>(entities);
            //var prob2 = mapper.Map<IEnumerable<T>>(prob);
            return View(entitiesViewModel);
        }

        // GET: CRUD/Details/5
        public virtual async Task<ActionResult> Details(int id)
        {
            return View(_mapper.Map<TEntityViewModel>(await _CRUDService.Get(id)));
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
                TEntity entity = _mapper.Map<TEntityViewModel, TEntity>(entityViewModel);
                await _CRUDService.Create(entity);
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
            return View(_mapper.Map<TEntityViewModel>(await _CRUDService.Get(id)));
        }

        // POST: CRUD/Edit/5
        [HttpPost]
        public virtual async Task<ActionResult> Edit(int id, TEntityViewModel entityViewModel)
        {
            try
            {
                TEntity entity = _mapper.Map<TEntity>(entityViewModel);
                await _CRUDService.Update(entity);
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
            return View(_mapper.Map<TEntityViewModel>(await _CRUDService.Get(id)));
        }

        // POST: CRUD/Delete/5
        [HttpPost]
        public virtual async Task<ActionResult> Delete(int id, TEntityViewModel entityVievModel)
        {
            try
            {
                TEntity entity = _mapper.Map<TEntity>(entityVievModel);
                await _CRUDService.Delete(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
