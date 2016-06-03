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

        public ActionResult _Home()
        {
            return PartialView();
        }

        public PartialViewResult _State1()
        {
            return PartialView();
        }

        public PartialViewResult _State2(int? id)
        {
            ViewBag.testid = id.HasValue ? id.Value : -1;
            return PartialView();
        }
    }
}