﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebTrasladista_consumeWCF.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        WebTrasladista_consumeWCF.ServiceReference1.LoginResponse Login(WebTrasladista_consumeWCF.ServiceReference1.LoginRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.LoginResponse> LoginAsync(WebTrasladista_consumeWCF.ServiceReference1.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenOperador", ReplyAction="http://tempuri.org/IService1/ObtenOperadorResponse")]
        WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorResponse ObtenOperador(WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenOperador", ReplyAction="http://tempuri.org/IService1/ObtenOperadorResponse")]
        System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorResponse> ObtenOperadorAsync(WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenVehiculo", ReplyAction="http://tempuri.org/IService1/ObtenVehiculoResponse")]
        WebTrasladista_consumeWCF.ServiceReference1.ObtenVehiculoResponse ObtenVehiculo(WebTrasladista_consumeWCF.ServiceReference1.ObtenVehiculoRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenVehiculo", ReplyAction="http://tempuri.org/IService1/ObtenVehiculoResponse")]
        System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.ObtenVehiculoResponse> ObtenVehiculoAsync(WebTrasladista_consumeWCF.ServiceReference1.ObtenVehiculoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenAgencia", ReplyAction="http://tempuri.org/IService1/ObtenAgenciaResponse")]
        WebTrasladista_consumeWCF.ServiceReference1.ObtenAgenciaResponse ObtenAgencia(WebTrasladista_consumeWCF.ServiceReference1.ObtenAgenciaRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenAgencia", ReplyAction="http://tempuri.org/IService1/ObtenAgenciaResponse")]
        System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.ObtenAgenciaResponse> ObtenAgenciaAsync(WebTrasladista_consumeWCF.ServiceReference1.ObtenAgenciaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertaUsuario", ReplyAction="http://tempuri.org/IService1/InsertaUsuarioResponse")]
        WebTrasladista_consumeWCF.ServiceReference1.InsertaUsuarioResponse InsertaUsuario(WebTrasladista_consumeWCF.ServiceReference1.InsertaUsuarioRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertaUsuario", ReplyAction="http://tempuri.org/IService1/InsertaUsuarioResponse")]
        System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.InsertaUsuarioResponse> InsertaUsuarioAsync(WebTrasladista_consumeWCF.ServiceReference1.InsertaUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertaGasto", ReplyAction="http://tempuri.org/IService1/InsertaGastoResponse")]
        WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoResponse InsertaGasto(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertaGasto", ReplyAction="http://tempuri.org/IService1/InsertaGastoResponse")]
        System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoResponse> InsertaGastoAsync(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertaGastoVehiculo", ReplyAction="http://tempuri.org/IService1/InsertaGastoVehiculoResponse")]
        WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoResponse InsertaGastoVehiculo(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertaGastoVehiculo", ReplyAction="http://tempuri.org/IService1/InsertaGastoVehiculoResponse")]
        System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoResponse> InsertaGastoVehiculoAsync(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertaServicio", ReplyAction="http://tempuri.org/IService1/InsertaServicioResponse")]
        WebTrasladista_consumeWCF.ServiceReference1.InsertaServicioResponse InsertaServicio(WebTrasladista_consumeWCF.ServiceReference1.InsertaServicioRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertaServicio", ReplyAction="http://tempuri.org/IService1/InsertaServicioResponse")]
        System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.InsertaServicioResponse> InsertaServicioAsync(WebTrasladista_consumeWCF.ServiceReference1.InsertaServicioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Login", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string msj;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string email;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public bool valida;
        
        public LoginRequest() {
        }
        
        public LoginRequest(string msj, string email, string password, bool valida) {
            this.msj = msj;
            this.email = email;
            this.password = password;
            this.valida = valida;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoginResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool LoginResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string msj;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public bool valida;
        
        public LoginResponse() {
        }
        
        public LoginResponse(bool LoginResult, string msj, bool valida) {
            this.LoginResult = LoginResult;
            this.msj = msj;
            this.valida = valida;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenOperador", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ObtenOperadorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string msj;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public System.Collections.Generic.List<int> ids;
        
        public ObtenOperadorRequest() {
        }
        
        public ObtenOperadorRequest(string msj, System.Collections.Generic.List<int> ids) {
            this.msj = msj;
            this.ids = ids;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenOperadorResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ObtenOperadorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Collections.Generic.List<string> ObtenOperadorResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string msj;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public System.Collections.Generic.List<int> ids;
        
        public ObtenOperadorResponse() {
        }
        
        public ObtenOperadorResponse(System.Collections.Generic.List<string> ObtenOperadorResult, string msj, System.Collections.Generic.List<int> ids) {
            this.ObtenOperadorResult = ObtenOperadorResult;
            this.msj = msj;
            this.ids = ids;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenVehiculo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ObtenVehiculoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string msj;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public System.Collections.Generic.List<int> ids;
        
        public ObtenVehiculoRequest() {
        }
        
        public ObtenVehiculoRequest(string msj, System.Collections.Generic.List<int> ids) {
            this.msj = msj;
            this.ids = ids;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenVehiculoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ObtenVehiculoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Collections.Generic.List<string> ObtenVehiculoResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string msj;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public System.Collections.Generic.List<int> ids;
        
        public ObtenVehiculoResponse() {
        }
        
        public ObtenVehiculoResponse(System.Collections.Generic.List<string> ObtenVehiculoResult, string msj, System.Collections.Generic.List<int> ids) {
            this.ObtenVehiculoResult = ObtenVehiculoResult;
            this.msj = msj;
            this.ids = ids;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenAgencia", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ObtenAgenciaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string msj;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public System.Collections.Generic.List<int> ids;
        
        public ObtenAgenciaRequest() {
        }
        
        public ObtenAgenciaRequest(string msj, System.Collections.Generic.List<int> ids) {
            this.msj = msj;
            this.ids = ids;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenAgenciaResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ObtenAgenciaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Collections.Generic.List<string> ObtenAgenciaResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string msj;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public System.Collections.Generic.List<int> ids;
        
        public ObtenAgenciaResponse() {
        }
        
        public ObtenAgenciaResponse(System.Collections.Generic.List<string> ObtenAgenciaResult, string msj, System.Collections.Generic.List<int> ids) {
            this.ObtenAgenciaResult = ObtenAgenciaResult;
            this.msj = msj;
            this.ids = ids;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertaUsuario", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertaUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Nombre;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string Paterno;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string Materno;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int Edad;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string Rfc;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public string Email;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string Pass;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        public int fk_rol;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=8)]
        public string mensaje;
        
        public InsertaUsuarioRequest() {
        }
        
        public InsertaUsuarioRequest(string Nombre, string Paterno, string Materno, int Edad, string Rfc, string Email, string Pass, int fk_rol, string mensaje) {
            this.Nombre = Nombre;
            this.Paterno = Paterno;
            this.Materno = Materno;
            this.Edad = Edad;
            this.Rfc = Rfc;
            this.Email = Email;
            this.Pass = Pass;
            this.fk_rol = fk_rol;
            this.mensaje = mensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertaUsuarioResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertaUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string mensaje;
        
        public InsertaUsuarioResponse() {
        }
        
        public InsertaUsuarioResponse(string mensaje) {
            this.mensaje = mensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertaGasto", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertaGastoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string restriccion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string necesidad;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public double km;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int tiempo_trans;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public double costo_casetas;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public double total;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string mensaje;
        
        public InsertaGastoRequest() {
        }
        
        public InsertaGastoRequest(string restriccion, string necesidad, double km, int tiempo_trans, double costo_casetas, double total, string mensaje) {
            this.restriccion = restriccion;
            this.necesidad = necesidad;
            this.km = km;
            this.tiempo_trans = tiempo_trans;
            this.costo_casetas = costo_casetas;
            this.total = total;
            this.mensaje = mensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertaGastoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertaGastoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int InsertaGastoResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensaje;
        
        public InsertaGastoResponse() {
        }
        
        public InsertaGastoResponse(int InsertaGastoResult, string mensaje) {
            this.InsertaGastoResult = InsertaGastoResult;
            this.mensaje = mensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertaGastoVehiculo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertaGastoVehiculoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int cantidad;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public double precio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public double total;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int fkgasto;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public int fkvehiculo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public string mensaje;
        
        public InsertaGastoVehiculoRequest() {
        }
        
        public InsertaGastoVehiculoRequest(int cantidad, double precio, double total, int fkgasto, int fkvehiculo, string mensaje) {
            this.cantidad = cantidad;
            this.precio = precio;
            this.total = total;
            this.fkgasto = fkgasto;
            this.fkvehiculo = fkvehiculo;
            this.mensaje = mensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertaGastoVehiculoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertaGastoVehiculoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string mensaje;
        
        public InsertaGastoVehiculoResponse() {
        }
        
        public InsertaGastoVehiculoResponse(string mensaje) {
            this.mensaje = mensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertaServicio", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertaServicioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string tipo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string estado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int fkuusuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int fkgasto;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public int fkagenciaorigen;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public int fkagenciadestino;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string mensaje;
        
        public InsertaServicioRequest() {
        }
        
        public InsertaServicioRequest(string tipo, string estado, int fkuusuario, int fkgasto, int fkagenciaorigen, int fkagenciadestino, string mensaje) {
            this.tipo = tipo;
            this.estado = estado;
            this.fkuusuario = fkuusuario;
            this.fkgasto = fkgasto;
            this.fkagenciaorigen = fkagenciaorigen;
            this.fkagenciadestino = fkagenciadestino;
            this.mensaje = mensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertaServicioResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class InsertaServicioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string mensaje;
        
        public InsertaServicioResponse() {
        }
        
        public InsertaServicioResponse(string mensaje) {
            this.mensaje = mensaje;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebTrasladista_consumeWCF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebTrasladista_consumeWCF.ServiceReference1.IService1>, WebTrasladista_consumeWCF.ServiceReference1.IService1 {
        
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
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebTrasladista_consumeWCF.ServiceReference1.LoginResponse WebTrasladista_consumeWCF.ServiceReference1.IService1.Login(WebTrasladista_consumeWCF.ServiceReference1.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public bool Login(ref string msj, string email, string password, ref bool valida) {
            WebTrasladista_consumeWCF.ServiceReference1.LoginRequest inValue = new WebTrasladista_consumeWCF.ServiceReference1.LoginRequest();
            inValue.msj = msj;
            inValue.email = email;
            inValue.password = password;
            inValue.valida = valida;
            WebTrasladista_consumeWCF.ServiceReference1.LoginResponse retVal = ((WebTrasladista_consumeWCF.ServiceReference1.IService1)(this)).Login(inValue);
            msj = retVal.msj;
            valida = retVal.valida;
            return retVal.LoginResult;
        }
        
        public System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.LoginResponse> LoginAsync(WebTrasladista_consumeWCF.ServiceReference1.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorResponse WebTrasladista_consumeWCF.ServiceReference1.IService1.ObtenOperador(WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorRequest request) {
            return base.Channel.ObtenOperador(request);
        }
        
        public System.Collections.Generic.List<string> ObtenOperador(ref string msj, ref System.Collections.Generic.List<int> ids) {
            WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorRequest inValue = new WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorRequest();
            inValue.msj = msj;
            inValue.ids = ids;
            WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorResponse retVal = ((WebTrasladista_consumeWCF.ServiceReference1.IService1)(this)).ObtenOperador(inValue);
            msj = retVal.msj;
            ids = retVal.ids;
            return retVal.ObtenOperadorResult;
        }
        
        public System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorResponse> ObtenOperadorAsync(WebTrasladista_consumeWCF.ServiceReference1.ObtenOperadorRequest request) {
            return base.Channel.ObtenOperadorAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebTrasladista_consumeWCF.ServiceReference1.ObtenVehiculoResponse WebTrasladista_consumeWCF.ServiceReference1.IService1.ObtenVehiculo(WebTrasladista_consumeWCF.ServiceReference1.ObtenVehiculoRequest request) {
            return base.Channel.ObtenVehiculo(request);
        }
        
        public System.Collections.Generic.List<string> ObtenVehiculo(ref string msj, ref System.Collections.Generic.List<int> ids) {
            WebTrasladista_consumeWCF.ServiceReference1.ObtenVehiculoRequest inValue = new WebTrasladista_consumeWCF.ServiceReference1.ObtenVehiculoRequest();
            inValue.msj = msj;
            inValue.ids = ids;
            WebTrasladista_consumeWCF.ServiceReference1.ObtenVehiculoResponse retVal = ((WebTrasladista_consumeWCF.ServiceReference1.IService1)(this)).ObtenVehiculo(inValue);
            msj = retVal.msj;
            ids = retVal.ids;
            return retVal.ObtenVehiculoResult;
        }
        
        public System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.ObtenVehiculoResponse> ObtenVehiculoAsync(WebTrasladista_consumeWCF.ServiceReference1.ObtenVehiculoRequest request) {
            return base.Channel.ObtenVehiculoAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebTrasladista_consumeWCF.ServiceReference1.ObtenAgenciaResponse WebTrasladista_consumeWCF.ServiceReference1.IService1.ObtenAgencia(WebTrasladista_consumeWCF.ServiceReference1.ObtenAgenciaRequest request) {
            return base.Channel.ObtenAgencia(request);
        }
        
        public System.Collections.Generic.List<string> ObtenAgencia(ref string msj, ref System.Collections.Generic.List<int> ids) {
            WebTrasladista_consumeWCF.ServiceReference1.ObtenAgenciaRequest inValue = new WebTrasladista_consumeWCF.ServiceReference1.ObtenAgenciaRequest();
            inValue.msj = msj;
            inValue.ids = ids;
            WebTrasladista_consumeWCF.ServiceReference1.ObtenAgenciaResponse retVal = ((WebTrasladista_consumeWCF.ServiceReference1.IService1)(this)).ObtenAgencia(inValue);
            msj = retVal.msj;
            ids = retVal.ids;
            return retVal.ObtenAgenciaResult;
        }
        
        public System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.ObtenAgenciaResponse> ObtenAgenciaAsync(WebTrasladista_consumeWCF.ServiceReference1.ObtenAgenciaRequest request) {
            return base.Channel.ObtenAgenciaAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebTrasladista_consumeWCF.ServiceReference1.InsertaUsuarioResponse WebTrasladista_consumeWCF.ServiceReference1.IService1.InsertaUsuario(WebTrasladista_consumeWCF.ServiceReference1.InsertaUsuarioRequest request) {
            return base.Channel.InsertaUsuario(request);
        }
        
        public void InsertaUsuario(string Nombre, string Paterno, string Materno, int Edad, string Rfc, string Email, string Pass, int fk_rol, ref string mensaje) {
            WebTrasladista_consumeWCF.ServiceReference1.InsertaUsuarioRequest inValue = new WebTrasladista_consumeWCF.ServiceReference1.InsertaUsuarioRequest();
            inValue.Nombre = Nombre;
            inValue.Paterno = Paterno;
            inValue.Materno = Materno;
            inValue.Edad = Edad;
            inValue.Rfc = Rfc;
            inValue.Email = Email;
            inValue.Pass = Pass;
            inValue.fk_rol = fk_rol;
            inValue.mensaje = mensaje;
            WebTrasladista_consumeWCF.ServiceReference1.InsertaUsuarioResponse retVal = ((WebTrasladista_consumeWCF.ServiceReference1.IService1)(this)).InsertaUsuario(inValue);
            mensaje = retVal.mensaje;
        }
        
        public System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.InsertaUsuarioResponse> InsertaUsuarioAsync(WebTrasladista_consumeWCF.ServiceReference1.InsertaUsuarioRequest request) {
            return base.Channel.InsertaUsuarioAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoResponse WebTrasladista_consumeWCF.ServiceReference1.IService1.InsertaGasto(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoRequest request) {
            return base.Channel.InsertaGasto(request);
        }
        
        public int InsertaGasto(string restriccion, string necesidad, double km, int tiempo_trans, double costo_casetas, double total, ref string mensaje) {
            WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoRequest inValue = new WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoRequest();
            inValue.restriccion = restriccion;
            inValue.necesidad = necesidad;
            inValue.km = km;
            inValue.tiempo_trans = tiempo_trans;
            inValue.costo_casetas = costo_casetas;
            inValue.total = total;
            inValue.mensaje = mensaje;
            WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoResponse retVal = ((WebTrasladista_consumeWCF.ServiceReference1.IService1)(this)).InsertaGasto(inValue);
            mensaje = retVal.mensaje;
            return retVal.InsertaGastoResult;
        }
        
        public System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoResponse> InsertaGastoAsync(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoRequest request) {
            return base.Channel.InsertaGastoAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoResponse WebTrasladista_consumeWCF.ServiceReference1.IService1.InsertaGastoVehiculo(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoRequest request) {
            return base.Channel.InsertaGastoVehiculo(request);
        }
        
        public void InsertaGastoVehiculo(int cantidad, double precio, double total, int fkgasto, int fkvehiculo, ref string mensaje) {
            WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoRequest inValue = new WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoRequest();
            inValue.cantidad = cantidad;
            inValue.precio = precio;
            inValue.total = total;
            inValue.fkgasto = fkgasto;
            inValue.fkvehiculo = fkvehiculo;
            inValue.mensaje = mensaje;
            WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoResponse retVal = ((WebTrasladista_consumeWCF.ServiceReference1.IService1)(this)).InsertaGastoVehiculo(inValue);
            mensaje = retVal.mensaje;
        }
        
        public System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoResponse> InsertaGastoVehiculoAsync(WebTrasladista_consumeWCF.ServiceReference1.InsertaGastoVehiculoRequest request) {
            return base.Channel.InsertaGastoVehiculoAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebTrasladista_consumeWCF.ServiceReference1.InsertaServicioResponse WebTrasladista_consumeWCF.ServiceReference1.IService1.InsertaServicio(WebTrasladista_consumeWCF.ServiceReference1.InsertaServicioRequest request) {
            return base.Channel.InsertaServicio(request);
        }
        
        public void InsertaServicio(string tipo, string estado, int fkuusuario, int fkgasto, int fkagenciaorigen, int fkagenciadestino, ref string mensaje) {
            WebTrasladista_consumeWCF.ServiceReference1.InsertaServicioRequest inValue = new WebTrasladista_consumeWCF.ServiceReference1.InsertaServicioRequest();
            inValue.tipo = tipo;
            inValue.estado = estado;
            inValue.fkuusuario = fkuusuario;
            inValue.fkgasto = fkgasto;
            inValue.fkagenciaorigen = fkagenciaorigen;
            inValue.fkagenciadestino = fkagenciadestino;
            inValue.mensaje = mensaje;
            WebTrasladista_consumeWCF.ServiceReference1.InsertaServicioResponse retVal = ((WebTrasladista_consumeWCF.ServiceReference1.IService1)(this)).InsertaServicio(inValue);
            mensaje = retVal.mensaje;
        }
        
        public System.Threading.Tasks.Task<WebTrasladista_consumeWCF.ServiceReference1.InsertaServicioResponse> InsertaServicioAsync(WebTrasladista_consumeWCF.ServiceReference1.InsertaServicioRequest request) {
            return base.Channel.InsertaServicioAsync(request);
        }
    }
}
