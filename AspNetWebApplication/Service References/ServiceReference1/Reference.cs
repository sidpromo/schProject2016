﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetWebApplication.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ValidateEACCookie", ReplyAction="http://tempuri.org/IService1/ValidateEACCookieResponse")]
        bool ValidateEACCookie(string url, string IASID, string userAccount, string cookie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ValidateEACCookie", ReplyAction="http://tempuri.org/IService1/ValidateEACCookieResponse")]
        System.Threading.Tasks.Task<bool> ValidateEACCookieAsync(string url, string IASID, string userAccount, string cookie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Logout", ReplyAction="http://tempuri.org/IService1/LogoutResponse")]
        bool Logout(string cookieName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Logout", ReplyAction="http://tempuri.org/IService1/LogoutResponse")]
        System.Threading.Tasks.Task<bool> LogoutAsync(string cookieName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : AspNetWebApplication.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<AspNetWebApplication.ServiceReference1.IService1>, AspNetWebApplication.ServiceReference1.IService1 {
        
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
        
        public bool ValidateEACCookie(string url, string IASID, string userAccount, string cookie) {
            return base.Channel.ValidateEACCookie(url, IASID, userAccount, cookie);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateEACCookieAsync(string url, string IASID, string userAccount, string cookie) {
            return base.Channel.ValidateEACCookieAsync(url, IASID, userAccount, cookie);
        }
        
        public bool Logout(string cookieName) {
            return base.Channel.Logout(cookieName);
        }
        
        public System.Threading.Tasks.Task<bool> LogoutAsync(string cookieName) {
            return base.Channel.LogoutAsync(cookieName);
        }
    }
}
