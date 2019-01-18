using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using WcfServicePoderosa.Contracts.Contracts;

namespace WcfServicePoderosaDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CustomerService.svc or CustomerService.svc.cs at the Solution Explorer and start debugging.

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class CustomerService : ICustomerService
    {
        public bool Create(CustomerCreate customerCreate)
        {
            //Mapping customerDto = customerCreate; 
            //Insert(CustomerDto)
            return true;
        }

        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id="1",  Code="001", Name="PODEROSA" },
                new Customer { Id="2",  Code="002", Name="LAS BAMBAS" }
            };
            return customers;
        }

        public Customer GetbyCodeJson(string code)
        {
            var customer = GetCustomers().FirstOrDefault(a => a.Code == code);
            return customer;
        }

        public Customer GetbyCodeXml(string code)
        {
            var customer = GetCustomers().FirstOrDefault(a => a.Code == code);
            return customer;
        }

        public string CreateJson(CustomerCreate customerCreate)
        {
            return Guid.NewGuid().ToString(); 
        }
    }
}
