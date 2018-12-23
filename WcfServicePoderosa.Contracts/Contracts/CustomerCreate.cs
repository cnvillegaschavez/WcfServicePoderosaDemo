using System.Runtime.Serialization;

namespace WcfServicePoderosa.Contracts.Contracts
{
    [DataContract]
    public class CustomerCreate
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
    }
}
