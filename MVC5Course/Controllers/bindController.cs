using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class bindController : Controller
    {
        // GET: bind
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Account)
        {
            return View("index");
        }

        
        public ActionResult Index2()
        {
            return View();
        }
        [RequireHttps]
        [HttpPost]
        public ActionResult Index2(abc model, abc aac)
        {
            return View("index2");
        }

        [HttpPost]
        public ActionResult ii6()
        {
            throw new Exception("iii");
            //return View();
        }
    }
}