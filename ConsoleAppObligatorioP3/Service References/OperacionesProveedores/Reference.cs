﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppObligatorioP3.OperacionesProveedores {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OperacionesProveedores.IOperacionesProveedores")]
    public interface IOperacionesProveedores {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/RetornarProveedores", ReplyAction="http://tempuri.org/IOperacionesProveedores/RetornarProveedoresResponse")]
        ServiciosObligatorioWCF.DTOProveedor[] RetornarProveedores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/RetornarProveedores", ReplyAction="http://tempuri.org/IOperacionesProveedores/RetornarProveedoresResponse")]
        System.Threading.Tasks.Task<ServiciosObligatorioWCF.DTOProveedor[]> RetornarProveedoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/RetornarProveedorPorRut", ReplyAction="http://tempuri.org/IOperacionesProveedores/RetornarProveedorPorRutResponse")]
        ServiciosObligatorioWCF.DTOProveedor RetornarProveedorPorRut(string unRut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/RetornarProveedorPorRut", ReplyAction="http://tempuri.org/IOperacionesProveedores/RetornarProveedorPorRutResponse")]
        System.Threading.Tasks.Task<ServiciosObligatorioWCF.DTOProveedor> RetornarProveedorPorRutAsync(string unRut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/ModificarArancelProveedor", ReplyAction="http://tempuri.org/IOperacionesProveedores/ModificarArancelProveedorResponse")]
        bool ModificarArancelProveedor(double unArancel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/ModificarArancelProveedor", ReplyAction="http://tempuri.org/IOperacionesProveedores/ModificarArancelProveedorResponse")]
        System.Threading.Tasks.Task<bool> ModificarArancelProveedorAsync(double unArancel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/ModificarPorcentajeVip", ReplyAction="http://tempuri.org/IOperacionesProveedores/ModificarPorcentajeVipResponse")]
        bool ModificarPorcentajeVip(double unPorcentajeVip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/ModificarPorcentajeVip", ReplyAction="http://tempuri.org/IOperacionesProveedores/ModificarPorcentajeVipResponse")]
        System.Threading.Tasks.Task<bool> ModificarPorcentajeVipAsync(double unPorcentajeVip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/DesactivarProveedor", ReplyAction="http://tempuri.org/IOperacionesProveedores/DesactivarProveedorResponse")]
        bool DesactivarProveedor(string unRut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/DesactivarProveedor", ReplyAction="http://tempuri.org/IOperacionesProveedores/DesactivarProveedorResponse")]
        System.Threading.Tasks.Task<bool> DesactivarProveedorAsync(string unRut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/RetornarProveedoresActivos", ReplyAction="http://tempuri.org/IOperacionesProveedores/RetornarProveedoresActivosResponse")]
        ServiciosObligatorioWCF.DTOProveedor[] RetornarProveedoresActivos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/RetornarProveedoresActivos", ReplyAction="http://tempuri.org/IOperacionesProveedores/RetornarProveedoresActivosResponse")]
        System.Threading.Tasks.Task<ServiciosObligatorioWCF.DTOProveedor[]> RetornarProveedoresActivosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/AltaProveedor", ReplyAction="http://tempuri.org/IOperacionesProveedores/AltaProveedorResponse")]
        bool AltaProveedor(string unNombreUsuario, string unaContrasena, string unRut, string unNomFantasia, string unEmail, string unTelefono, bool esVip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/AltaProveedor", ReplyAction="http://tempuri.org/IOperacionesProveedores/AltaProveedorResponse")]
        System.Threading.Tasks.Task<bool> AltaProveedorAsync(string unNombreUsuario, string unaContrasena, string unRut, string unNomFantasia, string unEmail, string unTelefono, bool esVip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/DevolverArancelActual", ReplyAction="http://tempuri.org/IOperacionesProveedores/DevolverArancelActualResponse")]
        double DevolverArancelActual();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/DevolverArancelActual", ReplyAction="http://tempuri.org/IOperacionesProveedores/DevolverArancelActualResponse")]
        System.Threading.Tasks.Task<double> DevolverArancelActualAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/DevolverPorcentajeVipActual", ReplyAction="http://tempuri.org/IOperacionesProveedores/DevolverPorcentajeVipActualResponse")]
        double DevolverPorcentajeVipActual();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperacionesProveedores/DevolverPorcentajeVipActual", ReplyAction="http://tempuri.org/IOperacionesProveedores/DevolverPorcentajeVipActualResponse")]
        System.Threading.Tasks.Task<double> DevolverPorcentajeVipActualAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOperacionesProveedoresChannel : ConsoleAppObligatorioP3.OperacionesProveedores.IOperacionesProveedores, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OperacionesProveedoresClient : System.ServiceModel.ClientBase<ConsoleAppObligatorioP3.OperacionesProveedores.IOperacionesProveedores>, ConsoleAppObligatorioP3.OperacionesProveedores.IOperacionesProveedores {
        
        public OperacionesProveedoresClient() {
        }
        
        public OperacionesProveedoresClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OperacionesProveedoresClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OperacionesProveedoresClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OperacionesProveedoresClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiciosObligatorioWCF.DTOProveedor[] RetornarProveedores() {
            return base.Channel.RetornarProveedores();
        }
        
        public System.Threading.Tasks.Task<ServiciosObligatorioWCF.DTOProveedor[]> RetornarProveedoresAsync() {
            return base.Channel.RetornarProveedoresAsync();
        }
        
        public ServiciosObligatorioWCF.DTOProveedor RetornarProveedorPorRut(string unRut) {
            return base.Channel.RetornarProveedorPorRut(unRut);
        }
        
        public System.Threading.Tasks.Task<ServiciosObligatorioWCF.DTOProveedor> RetornarProveedorPorRutAsync(string unRut) {
            return base.Channel.RetornarProveedorPorRutAsync(unRut);
        }
        
        public bool ModificarArancelProveedor(double unArancel) {
            return base.Channel.ModificarArancelProveedor(unArancel);
        }
        
        public System.Threading.Tasks.Task<bool> ModificarArancelProveedorAsync(double unArancel) {
            return base.Channel.ModificarArancelProveedorAsync(unArancel);
        }
        
        public bool ModificarPorcentajeVip(double unPorcentajeVip) {
            return base.Channel.ModificarPorcentajeVip(unPorcentajeVip);
        }
        
        public System.Threading.Tasks.Task<bool> ModificarPorcentajeVipAsync(double unPorcentajeVip) {
            return base.Channel.ModificarPorcentajeVipAsync(unPorcentajeVip);
        }
        
        public bool DesactivarProveedor(string unRut) {
            return base.Channel.DesactivarProveedor(unRut);
        }
        
        public System.Threading.Tasks.Task<bool> DesactivarProveedorAsync(string unRut) {
            return base.Channel.DesactivarProveedorAsync(unRut);
        }
        
        public ServiciosObligatorioWCF.DTOProveedor[] RetornarProveedoresActivos() {
            return base.Channel.RetornarProveedoresActivos();
        }
        
        public System.Threading.Tasks.Task<ServiciosObligatorioWCF.DTOProveedor[]> RetornarProveedoresActivosAsync() {
            return base.Channel.RetornarProveedoresActivosAsync();
        }
        
        public bool AltaProveedor(string unNombreUsuario, string unaContrasena, string unRut, string unNomFantasia, string unEmail, string unTelefono, bool esVip) {
            return base.Channel.AltaProveedor(unNombreUsuario, unaContrasena, unRut, unNomFantasia, unEmail, unTelefono, esVip);
        }
        
        public System.Threading.Tasks.Task<bool> AltaProveedorAsync(string unNombreUsuario, string unaContrasena, string unRut, string unNomFantasia, string unEmail, string unTelefono, bool esVip) {
            return base.Channel.AltaProveedorAsync(unNombreUsuario, unaContrasena, unRut, unNomFantasia, unEmail, unTelefono, esVip);
        }
        
        public double DevolverArancelActual() {
            return base.Channel.DevolverArancelActual();
        }
        
        public System.Threading.Tasks.Task<double> DevolverArancelActualAsync() {
            return base.Channel.DevolverArancelActualAsync();
        }
        
        public double DevolverPorcentajeVipActual() {
            return base.Channel.DevolverPorcentajeVipActual();
        }
        
        public System.Threading.Tasks.Task<double> DevolverPorcentajeVipActualAsync() {
            return base.Channel.DevolverPorcentajeVipActualAsync();
        }
    }
}
