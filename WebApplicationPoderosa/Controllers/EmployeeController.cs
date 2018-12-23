using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationPoderosa.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var wsEmployee = new WSEmployeeService.EmployeeServiceClient();
            var employees = wsEmployee.GetAllEmployes();
            employees.ToList();
            return View();
        }
    }
}