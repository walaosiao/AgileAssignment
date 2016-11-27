﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAssignment.ScheduleReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ScheduleReference.ScheduleSoap")]
    public interface ScheduleSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateRecord", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int updateRecord(string scheduleid, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateRecord", ReplyAction="*")]
        System.Threading.Tasks.Task<int> updateRecordAsync(string scheduleid, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLatestCustomers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetLatestCustomers(string scheduleid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLatestCustomers", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetLatestCustomersAsync(string scheduleid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertLatestSchedule", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int InsertLatestSchedule(string scheduleID, string destination, string departDate, string departTime, string busID, string driverID, string status, string originLocation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertLatestSchedule", ReplyAction="*")]
        System.Threading.Tasks.Task<int> InsertLatestScheduleAsync(string scheduleID, string destination, string departDate, string departTime, string busID, string driverID, string status, string originLocation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteRecord", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int deleteRecord(string scheduleid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteRecord", ReplyAction="*")]
        System.Threading.Tasks.Task<int> deleteRecordAsync(string scheduleid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ScheduleSoapChannel : WebAssignment.ScheduleReference.ScheduleSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ScheduleSoapClient : System.ServiceModel.ClientBase<WebAssignment.ScheduleReference.ScheduleSoap>, WebAssignment.ScheduleReference.ScheduleSoap {
        
        public ScheduleSoapClient() {
        }
        
        public ScheduleSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScheduleSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScheduleSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScheduleSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int updateRecord(string scheduleid, string status) {
            return base.Channel.updateRecord(scheduleid, status);
        }
        
        public System.Threading.Tasks.Task<int> updateRecordAsync(string scheduleid, string status) {
            return base.Channel.updateRecordAsync(scheduleid, status);
        }
        
        public System.Data.DataSet GetLatestCustomers(string scheduleid) {
            return base.Channel.GetLatestCustomers(scheduleid);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetLatestCustomersAsync(string scheduleid) {
            return base.Channel.GetLatestCustomersAsync(scheduleid);
        }
        
        public int InsertLatestSchedule(string scheduleID, string destination, string departDate, string departTime, string busID, string driverID, string status, string originLocation) {
            return base.Channel.InsertLatestSchedule(scheduleID, destination, departDate, departTime, busID, driverID, status, originLocation);
        }
        
        public System.Threading.Tasks.Task<int> InsertLatestScheduleAsync(string scheduleID, string destination, string departDate, string departTime, string busID, string driverID, string status, string originLocation) {
            return base.Channel.InsertLatestScheduleAsync(scheduleID, destination, departDate, departTime, busID, driverID, status, originLocation);
        }
        
        public int deleteRecord(string scheduleid) {
            return base.Channel.deleteRecord(scheduleid);
        }
        
        public System.Threading.Tasks.Task<int> deleteRecordAsync(string scheduleid) {
            return base.Channel.deleteRecordAsync(scheduleid);
        }
    }
}
