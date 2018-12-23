using System.Runtime.Serialization;

namespace WcfServicePoderosa.Contracts.Contracts
{
    [DataContract]
    public class ErrorInformation
    {
        [DataMember]
        public string ErrorMessage { get; set; }
    }
}
