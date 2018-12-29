using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using WcfServicePoderosa.Contracts.Contracts;

namespace ConsoleAppWCFNetTcpDemo.Services
{
    [ServiceBehavior(
        TransactionAutoCompleteOnSessionClose = true,
        ReleaseServiceInstanceOnTransactionComplete = true)]
    public class PersonService : IPersonService
    {
        public Person GetPersonById(int id)
        {
            return GetAllPersons().FirstOrDefault(p => p.Id == id);
        }

        [OperationBehavior(TransactionScopeRequired = true,
                           TransactionAutoComplete = true)]
        public bool Transfer1(Account desde, Account hacia, decimal monto)
        {
            return true;
        }

        [OperationBehavior(TransactionScopeRequired = true,
                           TransactionAutoComplete = false)]
        public bool Transfer2(Account desde, Account hacia, decimal monto)
        {
            return true;
        }

        private List<Person> GetAllPersons()
        {
            var persons = new List<Person> {
                new Person { Id= 1, Name = "Oscar", Address="Av." },
                new Person { Id= 2 , Name = "Cristian", Address="Av." },
                new Person { Id = 3, Name = "Reynaldo", Address="Av." },
            };
            return persons;
        }
    }
}
