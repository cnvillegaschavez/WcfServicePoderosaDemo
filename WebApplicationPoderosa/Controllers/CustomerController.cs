using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebApplicationPoderosa.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public async Task<ActionResult> Index()
        {
            var wsCustomer = new WSPoderosaService.CustomerServiceClient();
            var customers = await wsCustomer.GetCustomersAsync();
            return View(customers.ToList());
        }
    }
}