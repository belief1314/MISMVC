using MISMVC.DAO.Model;
using MISMVC.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MISMVC.Web.Controllers
{
    public class DocumentController : Controller
    {
		private IDocumentService service;

		public DocumentController(IDocumentService service ) {
			this.service = service;
		}
        // GET: Document
        public ActionResult Index()
        {
			var list = service.Find( d => d.ID > 0,true,d=>d.ID );
			return View(list);
        }

        // GET: Document/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Document/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
				// TODO: Add insert logic here
				if( ModelState.IsValid ) {
					Document document = new Document( );
					TryUpdateModel( document , collection );
					document.Creator = "Admin";
					document.CreateDate = DateTime.Now;
					service.Add( document );
					return RedirectToAction( "Index" );
				} else {
					return View( );
				}
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Document/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Document/Edit/5
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

        // GET: Document/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Document/Delete/5
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
