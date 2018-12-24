using System.Runtime.Serialization;

namespace WcfServicePoderosa.Contracts.Contracts
{
    [DataContract]
    public class ErrorInformation
    {
        public ErrorInformation(string message, MessageType messageType)
        {
            Message = message;
            MessageType = messageType;
        }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public MessageType MessageType { get; set; }
    }

    public enum MessageType
    {
        Error,
        Success,
        Information,
        Warning
    }
}
