using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;
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
            var obj = new DataContractJsonSerializer(typeof(CustomerModel));
            var resultStudent = obj.ReadObject(stream) as string;
            return View("View");
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View("Search");
        }

        [HttpPost]
        public async Task<ActionResult> Search(string code)
        {
            HttpClient client = new HttpClient();
            var basePath = ConfigurationManager.AppSettings["ServiceUrl"];
            var path =$"{basePath}/getbycodejson/{code}";
            HttpResponseMessage response = await client.GetAsync(path);
            var customer = string.Empty;
            if (response.IsSuccessStatusCode)
            {
                customer = await response.Content.ReadAsStringAsync();
            }
            var result = JsonConvert.DeserializeObject<CustomerResponse>(customer);

            var customers = new List<CustomerModel>();
            customers.Add(result.GetbyCodeJsonResult);
            return View("Search", customers);
        }

        
    }
}