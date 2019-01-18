using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplicationPoderosa.Models;

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

        [HttpGet]
        public ActionResult Create()
        {
            return View("View");
        }

        [HttpPost]
        public ActionResult Create(CustomerModel customer)
        {
            WebClient Proxy1 = new WebClient();
            Proxy1.Headers["Content-type"] = "application/json";
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer serializerToUplaod = new DataContractJsonSerializer(typeof(CustomerModel));
            serializerToUplaod.WriteObject(ms, customer);
            var data = Proxy1.UploadData("http://localhost:1421/CustomerService.svc/createjson", "POST", ms.ToArray());
            var stream = new MemoryStream(data);
             var  obj = new DataContractJsonSerializer(typeof(CustomerModel));
            var resultStudent = obj.ReadObject(stream) as string;

            return View("View");
        }
    }
}