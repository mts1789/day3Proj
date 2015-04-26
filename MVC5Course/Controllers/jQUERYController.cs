using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class jQUERYController : Controller
    {
        // GET: jQUERY
        public ActionResult file1()
        {

            return File(Server.MapPath("~\\Content\\Site.css"), "text/palin");
        }

        public ActionResult file2()
        {
            return File(Server.MapPath("~\\Content\\Site.css"), "text/html");
        }
        public ActionResult file3()
        {
            return File(Server.MapPath("~\\Content\\Site.css"), "text/palin","file6.aspx");
        }
        // public ActionResult file4()
        //{
        //    WebClient wc = new WebClient();
        //    var ff= wc.DownloadFile("https://t.kfs.io/upload_images/31696/miniASP_final_LOGO_cs4-02_promote.jpg", "fx.jpg");

        //    return File("https://t.kfs.io/upload_images/31696/miniASP_final_LOGO_cs4-02_promote.jpg", "image/png", "file6.aspx");
        //}
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult each()
        {
            return View();
        }
        // GET: jQUERY/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: jQUERY/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: jQUERY/Create
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

        // GET: jQUERY/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: jQUERY/Edit/5
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

        // GET: jQUERY/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: jQUERY/Delete/5
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
