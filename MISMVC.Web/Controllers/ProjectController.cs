using MISMVC.DAO.Model;
using MISMVC.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MISMVC.Web.Controllers
{
    public class ProjectController : Controller
    {
		private IProjectService service;

		public ProjectController( IProjectService service ) {
			this.service = service;
		}

        // GET: Project
        public ActionResult Index()
        {
			var list = service.Find( p => p.ID > 0,true,p=>p.ID );
            return View(list);
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
				// TODO: Add insert logic here
				if( ModelState.IsValid ) {
					Project project = new Project( );
					TryUpdateModel( project , collection );
					project.Creator = "Admin";
					project.CreateDate = DateTime.Now;
					service.Add( project );
					return RedirectToAction( "Index" );
				} else {
					return View( );
				}
            }
            catch(Exception ex)
            {
				ViewBag.Error = ex.Message;
                return View();
            }
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Project/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Project/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
