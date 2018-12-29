using System.ServiceModel;
using WcfServicePoderosa.Contracts.Contracts;

namespace ConsoleAppWCFNetTcpDemo.Services
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IPersonService
    {
        [OperationContract]
        Person GetPersonById(int id);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        bool Transfer1(Account desde, Account hacia, decimal monto);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        bool Transfer2(Account desde, Account hacia, decimal monto);
    }
}
