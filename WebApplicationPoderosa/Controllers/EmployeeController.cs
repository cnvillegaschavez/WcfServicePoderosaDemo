using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationPoderosa.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public async Task<ActionResult> Index()
        {
            ViewBag.ValidationMessage = string.Empty;
            var wsEmployee = new WSEmployeeService.EmployeeServiceClient();
            var employeeRequest = new WSEmployeeService.EmployeeRequest
            {
                LicenseKey = "1",
                EmployeeId = 5
            };

            WSEmployeeService.EmployeeInfo employee = null;
            try
            {
                employee = await wsEmployee.GetEmployeeAsync(employeeRequest);
            }
            catch (FaultException<WSEmployeeService.ErrorInformation> error)
            {
                ViewBag.ValidationMessage = error.Detail.Message;
            }
            return View(employee);
        }
    }
}