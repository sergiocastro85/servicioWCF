﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPersona")]
    public interface IPersona {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersona/Consultar", ReplyAction="http://tempuri.org/IPersona/ConsultarResponse")]
        Wcftest.dtos.ContactoDTO[] Consultar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersona/Consultar", ReplyAction="http://tempuri.org/IPersona/ConsultarResponse")]
        System.Threading.Tasks.Task<Wcftest.dtos.ContactoDTO[]> ConsultarAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonaChannel : Cliente.ServiceReference1.IPersona, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonaClient : System.ServiceModel.ClientBase<Cliente.ServiceReference1.IPersona>, Cliente.ServiceReference1.IPersona {
        
        public PersonaClient() {
        }
        
        public PersonaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Wcftest.dtos.ContactoDTO[] Consultar() {
            return base.Channel.Consultar();
        }
        
        public System.Threading.Tasks.Task<Wcftest.dtos.ContactoDTO[]> ConsultarAsync() {
            return base.Channel.ConsultarAsync();
        }
    }
}