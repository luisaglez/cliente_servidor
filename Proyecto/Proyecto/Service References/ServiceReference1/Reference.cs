﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGuardar")]
    public interface IGuardar {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuardar/guardar", ReplyAction="http://tempuri.org/IGuardar/guardarResponse")]
        void guardar(int a, string b, string c, string d, int e, string f);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuardar/guardar", ReplyAction="http://tempuri.org/IGuardar/guardarResponse")]
        System.Threading.Tasks.Task guardarAsync(int a, string b, string c, string d, int e, string f);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuardar/buscar", ReplyAction="http://tempuri.org/IGuardar/buscarResponse")]
        string[] buscar(int cla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuardar/buscar", ReplyAction="http://tempuri.org/IGuardar/buscarResponse")]
        System.Threading.Tasks.Task<string[]> buscarAsync(int cla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuardar/mostrar", ReplyAction="http://tempuri.org/IGuardar/mostrarResponse")]
        string[] mostrar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuardar/mostrar", ReplyAction="http://tempuri.org/IGuardar/mostrarResponse")]
        System.Threading.Tasks.Task<string[]> mostrarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuardar/obtener", ReplyAction="http://tempuri.org/IGuardar/obtenerResponse")]
        string obtener(int con);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuardar/obtener", ReplyAction="http://tempuri.org/IGuardar/obtenerResponse")]
        System.Threading.Tasks.Task<string> obtenerAsync(int con);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuardar/num", ReplyAction="http://tempuri.org/IGuardar/numResponse")]
        string num(string n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuardar/num", ReplyAction="http://tempuri.org/IGuardar/numResponse")]
        System.Threading.Tasks.Task<string> numAsync(string n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuardar/toText", ReplyAction="http://tempuri.org/IGuardar/toTextResponse")]
        string toText(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuardar/toText", ReplyAction="http://tempuri.org/IGuardar/toTextResponse")]
        System.Threading.Tasks.Task<string> toTextAsync(double value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGuardarChannel : Proyecto.ServiceReference1.IGuardar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GuardarClient : System.ServiceModel.ClientBase<Proyecto.ServiceReference1.IGuardar>, Proyecto.ServiceReference1.IGuardar {
        
        public GuardarClient() {
        }
        
        public GuardarClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GuardarClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GuardarClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GuardarClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void guardar(int a, string b, string c, string d, int e, string f) {
            base.Channel.guardar(a, b, c, d, e, f);
        }
        
        public System.Threading.Tasks.Task guardarAsync(int a, string b, string c, string d, int e, string f) {
            return base.Channel.guardarAsync(a, b, c, d, e, f);
        }
        
        public string[] buscar(int cla) {
            return base.Channel.buscar(cla);
        }
        
        public System.Threading.Tasks.Task<string[]> buscarAsync(int cla) {
            return base.Channel.buscarAsync(cla);
        }
        
        public string[] mostrar() {
            return base.Channel.mostrar();
        }
        
        public System.Threading.Tasks.Task<string[]> mostrarAsync() {
            return base.Channel.mostrarAsync();
        }
        
        public string obtener(int con) {
            return base.Channel.obtener(con);
        }
        
        public System.Threading.Tasks.Task<string> obtenerAsync(int con) {
            return base.Channel.obtenerAsync(con);
        }
        
        public string num(string n) {
            return base.Channel.num(n);
        }
        
        public System.Threading.Tasks.Task<string> numAsync(string n) {
            return base.Channel.numAsync(n);
        }
        
        public string toText(double value) {
            return base.Channel.toText(value);
        }
        
        public System.Threading.Tasks.Task<string> toTextAsync(double value) {
            return base.Channel.toTextAsync(value);
        }
    }
}
