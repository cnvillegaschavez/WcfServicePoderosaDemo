using System.Collections.Generic;
using System.ServiceModel;
using WcfServicePoderosa.Contracts.Contracts;

namespace WcfServicePoderosaDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICustomerService" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        bool Create(CustomerCreate customerCreate);

        [OperationContract]
        List<Customer> GetCustomers();
    }
}
