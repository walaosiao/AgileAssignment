﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAssignment.BusReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BusReference.BusServiceSoap")]
    public interface BusServiceSoap {
        
        // CODEGEN: Generating message contract since element name busID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertLatestCustomers", ReplyAction="*")]
        WebAssignment.BusReference.InsertLatestCustomersResponse InsertLatestCustomers(WebAssignment.BusReference.InsertLatestCustomersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertLatestCustomers", ReplyAction="*")]
        System.Threading.Tasks.Task<WebAssignment.BusReference.InsertLatestCustomersResponse> InsertLatestCustomersAsync(WebAssignment.BusReference.InsertLatestCustomersRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertLatestCustomersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertLatestCustomers", Namespace="http://tempuri.org/", Order=0)]
        public WebAssignment.BusReference.InsertLatestCustomersRequestBody Body;
        
        public InsertLatestCustomersRequest() {
        }
        
        public InsertLatestCustomersRequest(WebAssignment.BusReference.InsertLatestCustomersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertLatestCustomersRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string busID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string busPlateNum;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string busModel;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string busDriver;
        
        public InsertLatestCustomersRequestBody() {
        }
        
        public InsertLatestCustomersRequestBody(string busID, string busPlateNum, string busModel, string busDriver) {
            this.busID = busID;
            this.busPlateNum = busPlateNum;
            this.busModel = busModel;
            this.busDriver = busDriver;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertLatestCustomersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertLatestCustomersResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebAssignment.BusReference.InsertLatestCustomersResponseBody Body;
        
        public InsertLatestCustomersResponse() {
        }
        
        public InsertLatestCustomersResponse(WebAssignment.BusReference.InsertLatestCustomersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertLatestCustomersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int InsertLatestCustomersResult;
        
        public InsertLatestCustomersResponseBody() {
        }
        
        public InsertLatestCustomersResponseBody(int InsertLatestCustomersResult) {
            this.InsertLatestCustomersResult = InsertLatestCustomersResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BusServiceSoapChannel : WebAssignment.BusReference.BusServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BusServiceSoapClient : System.ServiceModel.ClientBase<WebAssignment.BusReference.BusServiceSoap>, WebAssignment.BusReference.BusServiceSoap {
        
        public BusServiceSoapClient() {
        }
        
        public BusServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BusServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BusServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BusServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebAssignment.BusReference.InsertLatestCustomersResponse WebAssignment.BusReference.BusServiceSoap.InsertLatestCustomers(WebAssignment.BusReference.InsertLatestCustomersRequest request) {
            return base.Channel.InsertLatestCustomers(request);
        }
        
        public int InsertLatestCustomers(string busID, string busPlateNum, string busModel, string busDriver) {
            WebAssignment.BusReference.InsertLatestCustomersRequest inValue = new WebAssignment.BusReference.InsertLatestCustomersRequest();
            inValue.Body = new WebAssignment.BusReference.InsertLatestCustomersRequestBody();
            inValue.Body.busID = busID;
            inValue.Body.busPlateNum = busPlateNum;
            inValue.Body.busModel = busModel;
            inValue.Body.busDriver = busDriver;
            WebAssignment.BusReference.InsertLatestCustomersResponse retVal = ((WebAssignment.BusReference.BusServiceSoap)(this)).InsertLatestCustomers(inValue);
            return retVal.Body.InsertLatestCustomersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebAssignment.BusReference.InsertLatestCustomersResponse> WebAssignment.BusReference.BusServiceSoap.InsertLatestCustomersAsync(WebAssignment.BusReference.InsertLatestCustomersRequest request) {
            return base.Channel.InsertLatestCustomersAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebAssignment.BusReference.InsertLatestCustomersResponse> InsertLatestCustomersAsync(string busID, string busPlateNum, string busModel, string busDriver) {
            WebAssignment.BusReference.InsertLatestCustomersRequest inValue = new WebAssignment.BusReference.InsertLatestCustomersRequest();
            inValue.Body = new WebAssignment.BusReference.InsertLatestCustomersRequestBody();
            inValue.Body.busID = busID;
            inValue.Body.busPlateNum = busPlateNum;
            inValue.Body.busModel = busModel;
            inValue.Body.busDriver = busDriver;
            return ((WebAssignment.BusReference.BusServiceSoap)(this)).InsertLatestCustomersAsync(inValue);
        }
    }
}