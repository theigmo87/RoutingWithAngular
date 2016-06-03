using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingWithAngular.Extensions
{
    public static class PartialViewResultExtensions
    {
        public static string ConvertToString(this PartialViewResult partialView,
                                                    ControllerContext controllerContext)
        {
            using (var sw = new StringWriter())
            {
                partialView.View = ViewEngines.Engines
                    .FindPartialView(controllerContext, partialView.ViewName).View;

                var vc = new ViewContext(
                    controllerContext, partialView.View, partialView.ViewData, partialView.TempData, sw);
                partialView.View.Render(vc, sw);

                var partialViewString = sw.GetStringBuilder().ToString();

                return partialViewString;
            }
        }
    }
}