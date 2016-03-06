using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MISMVC.Web.Controllers
{
    public class SoftwareGroupController : Controller
    {
        // GET: SoftwareGroup
        public ActionResult Index()
        {
            return View();
        }

        // GET: SoftwareGroup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SoftwareGroup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SoftwareGroup/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SoftwareGroup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SoftwareGroup/Edit/5
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

        // GET: SoftwareGroup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SoftwareGroup/Delete/5
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
