using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using RoutingWithAngular.Helpers;
using RoutingWithAngular.Extensions;

namespace RoutingWithAngular.API
{
    public class Employees : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            Models.Payroll.Employee e = new Models.Payroll.Employee();
            e.ID = 4;
            e.LastName = "Howard";
            e.FirstName = "Ben";
            e.MI = "L";
            PartialViewResult pvr = new PartialViewResult();
            return "";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}