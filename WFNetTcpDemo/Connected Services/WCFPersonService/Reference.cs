﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFNetTcpDemo.WCFPersonService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WcfServicePoderosa.Contracts.Contracts")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/WcfServicePoderosa.Contracts.Contracts")]
    [System.SerializableAttribute()]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFPersonService.IPersonService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersonById", ReplyAction="http://tempuri.org/IPersonService/GetPersonByIdResponse")]
        WFNetTcpDemo.WCFPersonService.Person GetPersonById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersonById", ReplyAction="http://tempuri.org/IPersonService/GetPersonByIdResponse")]
        System.Threading.Tasks.Task<WFNetTcpDemo.WCFPersonService.Person> GetPersonByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/Transfer1", ReplyAction="http://tempuri.org/IPersonService/Transfer1Response")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
        bool Transfer1(WFNetTcpDemo.WCFPersonService.Account desde, WFNetTcpDemo.WCFPersonService.Account hacia, decimal monto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/Transfer1", ReplyAction="http://tempuri.org/IPersonService/Transfer1Response")]
        System.Threading.Tasks.Task<bool> Transfer1Async(WFNetTcpDemo.WCFPersonService.Account desde, WFNetTcpDemo.WCFPersonService.Account hacia, decimal monto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/Transfer2", ReplyAction="http://tempuri.org/IPersonService/Transfer2Response")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        bool Transfer2(WFNetTcpDemo.WCFPersonService.Account desde, WFNetTcpDemo.WCFPersonService.Account hacia, decimal monto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/Transfer2", ReplyAction="http://tempuri.org/IPersonService/Transfer2Response")]
        System.Threading.Tasks.Task<bool> Transfer2Async(WFNetTcpDemo.WCFPersonService.Account desde, WFNetTcpDemo.WCFPersonService.Account hacia, decimal monto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : WFNetTcpDemo.WCFPersonService.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<WFNetTcpDemo.WCFPersonService.IPersonService>, WFNetTcpDemo.WCFPersonService.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WFNetTcpDemo.WCFPersonService.Person GetPersonById(int id) {
            return base.Channel.GetPersonById(id);
        }
        
        public System.Threading.Tasks.Task<WFNetTcpDemo.WCFPersonService.Person> GetPersonByIdAsync(int id) {
            return base.Channel.GetPersonByIdAsync(id);
        }
        
        public bool Transfer1(WFNetTcpDemo.WCFPersonService.Account desde, WFNetTcpDemo.WCFPersonService.Account hacia, decimal monto) {
            return base.Channel.Transfer1(desde, hacia, monto);
        }
        
        public System.Threading.Tasks.Task<bool> Transfer1Async(WFNetTcpDemo.WCFPersonService.Account desde, WFNetTcpDemo.WCFPersonService.Account hacia, decimal monto) {
            return base.Channel.Transfer1Async(desde, hacia, monto);
        }
        
        public bool Transfer2(WFNetTcpDemo.WCFPersonService.Account desde, WFNetTcpDemo.WCFPersonService.Account hacia, decimal monto) {
            return base.Channel.Transfer2(desde, hacia, monto);
        }
        
        public System.Threading.Tasks.Task<bool> Transfer2Async(WFNetTcpDemo.WCFPersonService.Account desde, WFNetTcpDemo.WCFPersonService.Account hacia, decimal monto) {
            return base.Channel.Transfer2Async(desde, hacia, monto);
        }
    }
}