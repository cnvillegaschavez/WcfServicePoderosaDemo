using System.Runtime.Serialization;

namespace WcfServicePoderosa.Contracts.Contracts
{
    [DataContract]
    public class Account
    {
        [DataMember]
        public string Number { get; set; }
    }
}
