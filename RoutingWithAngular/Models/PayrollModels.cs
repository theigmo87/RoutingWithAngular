using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoutingWithAngular.Models.Payroll
{
    public class Employee
    {
        public Employee()
        {
            ID = 0;
            FirstName = String.Empty;
            MI = String.Empty;
            LastName = String.Empty;
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MI { get; set; }
        public string LastName { get; set; }
        public string Name
        {
            get
            {
                return String.IsNullOrEmpty(MI) ? String.Format("{0} {1}", FirstName, LastName) : String.Format("{0} {1}. {2}", FirstName, MI, LastName);
            }
        }
    }
}