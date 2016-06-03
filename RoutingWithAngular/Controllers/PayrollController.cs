using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoutingWithAngular.Helpers;

namespace RoutingWithAngular.Controllers
{
    public class PayrollController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Payroll
        public PartialViewResult Employees(int id = 0)
        {
            return PartialView("_EmployeeView", new Models.Payroll.Employee());
        }

        // POST: Payroll/Create
        [HttpPost]
        public JsonResult SaveEmployee(Models.Payroll.Employee model)
        {
            return Json(new { onSuccessState = "state1" });
        }
    }
}
