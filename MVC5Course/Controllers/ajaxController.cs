using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ajaxController : Controller
    {
        // GET: ajax
        public ActionResult Index()
        {
            return View();
        }

        public string getTime()
        {
            return DateTime.Now.ToString();
        }
    }
}