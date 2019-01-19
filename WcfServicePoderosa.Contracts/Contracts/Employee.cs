using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServicePoderosa.Contracts.Contracts
{
    [MessageContract(IsWrapped = true, WrapperName = "EmployeeRequestObject", WrapperNamespace = "http://podera.com/employee")]
    public class EmployeeRequest
    {
        [MessageHeader(Namespace = "http://podera.com/employee")]
        public string LicenseKey { get; set; }

        [MessageBodyMember]
        public int EmployeeId { get; set; }
    }

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeInfoObject", WrapperNamespace = "http://podera.com/employee")]
    public class EmployeeInfo
    {
        public EmployeeInfo()
        {
        }

        public EmployeeInfo(Employee employee)
        {
            EmployeeId = employee.EmployeeId;
            Name = employee.Name;
            Address = employee.Address;
        }

        [MessageBodyMember(Order = 1, Namespace = "http://podera.com/employee")]
        public int EmployeeId { get; set; }

        [MessageBodyMember(Order = 2, Namespace = "http://podera.com/employee")]
        public string Name { get; set; }

        [MessageBodyMember(Order = 3, Namespace = "http://podera.com/employee")]
        public string Address { get; set; }
    }

    [DataContract(Namespace = "http://poderosa.com/employee")]
    public class Employee
    {
        [DataMember]
        public int EmployeeId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }
    }
}
