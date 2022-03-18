﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdoNetExample.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.CaculatorServiceSoap")]
    public interface CaculatorServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        AdoNetExample.ServiceReference1.HelloWorldResponse HelloWorld(AdoNetExample.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<AdoNetExample.ServiceReference1.HelloWorldResponse> HelloWorldAsync(AdoNetExample.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyCalc", ReplyAction="*")]
        int MyCalc(int a, int b, int c, char choice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyCalc", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MyCalcAsync(int a, int b, int c, char choice);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public AdoNetExample.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(AdoNetExample.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public AdoNetExample.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(AdoNetExample.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CaculatorServiceSoapChannel : AdoNetExample.ServiceReference1.CaculatorServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CaculatorServiceSoapClient : System.ServiceModel.ClientBase<AdoNetExample.ServiceReference1.CaculatorServiceSoap>, AdoNetExample.ServiceReference1.CaculatorServiceSoap {
        
        public CaculatorServiceSoapClient() {
        }
        
        public CaculatorServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CaculatorServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaculatorServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaculatorServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AdoNetExample.ServiceReference1.HelloWorldResponse AdoNetExample.ServiceReference1.CaculatorServiceSoap.HelloWorld(AdoNetExample.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            AdoNetExample.ServiceReference1.HelloWorldRequest inValue = new AdoNetExample.ServiceReference1.HelloWorldRequest();
            inValue.Body = new AdoNetExample.ServiceReference1.HelloWorldRequestBody();
            AdoNetExample.ServiceReference1.HelloWorldResponse retVal = ((AdoNetExample.ServiceReference1.CaculatorServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AdoNetExample.ServiceReference1.HelloWorldResponse> AdoNetExample.ServiceReference1.CaculatorServiceSoap.HelloWorldAsync(AdoNetExample.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<AdoNetExample.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            AdoNetExample.ServiceReference1.HelloWorldRequest inValue = new AdoNetExample.ServiceReference1.HelloWorldRequest();
            inValue.Body = new AdoNetExample.ServiceReference1.HelloWorldRequestBody();
            return ((AdoNetExample.ServiceReference1.CaculatorServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int MyCalc(int a, int b, int c, char choice) {
            return base.Channel.MyCalc(a, b, c, choice);
        }
        
        public System.Threading.Tasks.Task<int> MyCalcAsync(int a, int b, int c, char choice) {
            return base.Channel.MyCalcAsync(a, b, c, choice);
        }
    }
}
