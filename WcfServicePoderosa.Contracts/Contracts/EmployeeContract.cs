using System.ServiceModel;

namespace WcfServicePoderosa.Contracts.Contracts
{
    [MessageContract(WrapperName = "EmployeeContract")]
    public class EmployeeContract
    {
        [MessageHeader]
        public string Name { get; set; }

        [MessageBodyMember]
        public int Age { get; set; }
    }
}
