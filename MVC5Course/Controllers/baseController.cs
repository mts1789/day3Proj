using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class baseController : Controller
    {
#if DEBUG
        // GET: base
        public ActionResult Index()
        {
            return View();
        }

        // GET: base/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: base/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: base/Create
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

        // GET: base/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: base/Edit/5
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

        // GET: base/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: base/Delete/5
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
#endif
    }
}
