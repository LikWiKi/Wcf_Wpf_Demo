//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WcfDemoCRUD")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPerson", ReplyAction="http://tempuri.org/IService1/GetAllPersonResponse")]
        WpfApp.ServiceReference.Person[] GetAllPerson();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPerson", ReplyAction="http://tempuri.org/IService1/GetAllPersonResponse")]
        System.Threading.Tasks.Task<WpfApp.ServiceReference.Person[]> GetAllPersonAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPerson", ReplyAction="http://tempuri.org/IService1/InsertPersonResponse")]
        void InsertPerson(WpfApp.ServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPerson", ReplyAction="http://tempuri.org/IService1/InsertPersonResponse")]
        System.Threading.Tasks.Task InsertPersonAsync(WpfApp.ServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePerson", ReplyAction="http://tempuri.org/IService1/UpdatePersonResponse")]
        void UpdatePerson(WpfApp.ServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePerson", ReplyAction="http://tempuri.org/IService1/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(WpfApp.ServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePerson", ReplyAction="http://tempuri.org/IService1/DeletePersonResponse")]
        void DeletePerson(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePerson", ReplyAction="http://tempuri.org/IService1/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WpfApp.ServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WpfApp.ServiceReference.IService1>, WpfApp.ServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WpfApp.ServiceReference.Person[] GetAllPerson() {
            return base.Channel.GetAllPerson();
        }
        
        public System.Threading.Tasks.Task<WpfApp.ServiceReference.Person[]> GetAllPersonAsync() {
            return base.Channel.GetAllPersonAsync();
        }
        
        public void InsertPerson(WpfApp.ServiceReference.Person person) {
            base.Channel.InsertPerson(person);
        }
        
        public System.Threading.Tasks.Task InsertPersonAsync(WpfApp.ServiceReference.Person person) {
            return base.Channel.InsertPersonAsync(person);
        }
        
        public void UpdatePerson(WpfApp.ServiceReference.Person person) {
            base.Channel.UpdatePerson(person);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(WpfApp.ServiceReference.Person person) {
            return base.Channel.UpdatePersonAsync(person);
        }
        
        public void DeletePerson(int id) {
            base.Channel.DeletePerson(id);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(int id) {
            return base.Channel.DeletePersonAsync(id);
        }
    }
}
