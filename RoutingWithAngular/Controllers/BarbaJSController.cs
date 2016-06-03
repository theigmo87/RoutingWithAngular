using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingWithAngular.Controllers
{
    public class BarbaJSController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult State1()
        {
            return View();
        }

        public ActionResult State2(int? id)
        {
            ViewBag.testid = id.HasValue ? id.Value : -1;
            return View();
        }
    }
}