using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MISMVC.Web.Controllers
{
    public class CertController : Controller
    {
        // GET: Cert
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cert/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cert/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cert/Create
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

        // GET: Cert/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cert/Edit/5
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

        // GET: Cert/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cert/Delete/5
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
