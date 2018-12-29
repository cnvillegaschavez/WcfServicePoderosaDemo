using System.Runtime.Serialization;

namespace WcfServicePoderosa.Contracts.Contracts
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }
    }
}
