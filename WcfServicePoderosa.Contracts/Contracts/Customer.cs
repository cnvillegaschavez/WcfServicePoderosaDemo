using System.Runtime.Serialization;

namespace WcfServicePoderosa.Contracts.Contracts
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
    }
}
