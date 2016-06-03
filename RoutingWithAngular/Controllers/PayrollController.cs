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

        // GET: Payroll/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Payroll/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Payroll/Create
        [HttpPost]
        public JsonResult SaveEmployee(Models.Payroll.Employee model)
        {
            return Json(new { onSuccessState = "state1" });
        }

        // GET: Payroll/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Payroll/Edit/5
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

        // GET: Payroll/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Payroll/Delete/5
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
