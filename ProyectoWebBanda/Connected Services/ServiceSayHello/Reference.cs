﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoWebBanda.ServiceSayHello {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="helloRequest", Namespace="http://learnwebservices.com/services/hello")]
    [System.SerializableAttribute()]
    public partial class helloRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="helloResponse", Namespace="http://learnwebservices.com/services/hello")]
    [System.SerializableAttribute()]
    public partial class helloResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://learnwebservices.com/services/hello", ConfigurationName="ServiceSayHello.HelloEndpoint")]
    public interface HelloEndpoint {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloRequest del espacio de nombres http://learnwebservices.com/services/hello no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        ProyectoWebBanda.ServiceSayHello.SayHelloResponse SayHello(ProyectoWebBanda.ServiceSayHello.SayHello request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoWebBanda.ServiceSayHello.SayHelloResponse> SayHelloAsync(ProyectoWebBanda.ServiceSayHello.SayHello request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SayHello {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SayHello", Namespace="http://learnwebservices.com/services/hello", Order=0)]
        public ProyectoWebBanda.ServiceSayHello.SayHelloBody Body;
        
        public SayHello() {
        }
        
        public SayHello(ProyectoWebBanda.ServiceSayHello.SayHelloBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://learnwebservices.com/services/hello")]
    public partial class SayHelloBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoWebBanda.ServiceSayHello.helloRequest HelloRequest;
        
        public SayHelloBody() {
        }
        
        public SayHelloBody(ProyectoWebBanda.ServiceSayHello.helloRequest HelloRequest) {
            this.HelloRequest = HelloRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SayHelloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SayHelloResponse", Namespace="http://learnwebservices.com/services/hello", Order=0)]
        public ProyectoWebBanda.ServiceSayHello.SayHelloResponseBody Body;
        
        public SayHelloResponse() {
        }
        
        public SayHelloResponse(ProyectoWebBanda.ServiceSayHello.SayHelloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://learnwebservices.com/services/hello")]
    public partial class SayHelloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoWebBanda.ServiceSayHello.helloResponse HelloResponse;
        
        public SayHelloResponseBody() {
        }
        
        public SayHelloResponseBody(ProyectoWebBanda.ServiceSayHello.helloResponse HelloResponse) {
            this.HelloResponse = HelloResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HelloEndpointChannel : ProyectoWebBanda.ServiceSayHello.HelloEndpoint, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloEndpointClient : System.ServiceModel.ClientBase<ProyectoWebBanda.ServiceSayHello.HelloEndpoint>, ProyectoWebBanda.ServiceSayHello.HelloEndpoint {
        
        public HelloEndpointClient() {
        }
        
        public HelloEndpointClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloEndpointClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloEndpointClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloEndpointClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoWebBanda.ServiceSayHello.SayHelloResponse ProyectoWebBanda.ServiceSayHello.HelloEndpoint.SayHello(ProyectoWebBanda.ServiceSayHello.SayHello request) {
            return base.Channel.SayHello(request);
        }
        
        public ProyectoWebBanda.ServiceSayHello.helloResponse SayHello(ProyectoWebBanda.ServiceSayHello.helloRequest HelloRequest) {
            ProyectoWebBanda.ServiceSayHello.SayHello inValue = new ProyectoWebBanda.ServiceSayHello.SayHello();
            inValue.Body = new ProyectoWebBanda.ServiceSayHello.SayHelloBody();
            inValue.Body.HelloRequest = HelloRequest;
            ProyectoWebBanda.ServiceSayHello.SayHelloResponse retVal = ((ProyectoWebBanda.ServiceSayHello.HelloEndpoint)(this)).SayHello(inValue);
            return retVal.Body.HelloResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoWebBanda.ServiceSayHello.SayHelloResponse> ProyectoWebBanda.ServiceSayHello.HelloEndpoint.SayHelloAsync(ProyectoWebBanda.ServiceSayHello.SayHello request) {
            return base.Channel.SayHelloAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoWebBanda.ServiceSayHello.SayHelloResponse> SayHelloAsync(ProyectoWebBanda.ServiceSayHello.helloRequest HelloRequest) {
            ProyectoWebBanda.ServiceSayHello.SayHello inValue = new ProyectoWebBanda.ServiceSayHello.SayHello();
            inValue.Body = new ProyectoWebBanda.ServiceSayHello.SayHelloBody();
            inValue.Body.HelloRequest = HelloRequest;
            return ((ProyectoWebBanda.ServiceSayHello.HelloEndpoint)(this)).SayHelloAsync(inValue);
        }
    }
}