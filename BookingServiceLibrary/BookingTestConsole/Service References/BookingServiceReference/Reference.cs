﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookingTestConsole.BookingServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookingData", Namespace="http://schemas.datacontract.org/2004/07/BookingServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class BookingData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EventStartTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EventStopTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EventStartTime {
            get {
                return this.EventStartTimeField;
            }
            set {
                if ((this.EventStartTimeField.Equals(value) != true)) {
                    this.EventStartTimeField = value;
                    this.RaisePropertyChanged("EventStartTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EventStopTime {
            get {
                return this.EventStopTimeField;
            }
            set {
                if ((this.EventStopTimeField.Equals(value) != true)) {
                    this.EventStopTimeField = value;
                    this.RaisePropertyChanged("EventStopTime");
                }
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookingServiceReference.IBooking")]
    public interface IBooking {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBooking/MakeBooking", ReplyAction="http://tempuri.org/IBooking/MakeBookingResponse")]
        bool MakeBooking(BookingTestConsole.BookingServiceReference.BookingData data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBooking/MakeBooking", ReplyAction="http://tempuri.org/IBooking/MakeBookingResponse")]
        System.Threading.Tasks.Task<bool> MakeBookingAsync(BookingTestConsole.BookingServiceReference.BookingData data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBooking/ViewBookingsFrom", ReplyAction="http://tempuri.org/IBooking/ViewBookingsFromResponse")]
        BookingTestConsole.BookingServiceReference.BookingData[] ViewBookingsFrom(System.DateTime when);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBooking/ViewBookingsFrom", ReplyAction="http://tempuri.org/IBooking/ViewBookingsFromResponse")]
        System.Threading.Tasks.Task<BookingTestConsole.BookingServiceReference.BookingData[]> ViewBookingsFromAsync(System.DateTime when);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookingChannel : BookingTestConsole.BookingServiceReference.IBooking, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookingClient : System.ServiceModel.ClientBase<BookingTestConsole.BookingServiceReference.IBooking>, BookingTestConsole.BookingServiceReference.IBooking {
        
        public BookingClient() {
        }
        
        public BookingClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookingClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool MakeBooking(BookingTestConsole.BookingServiceReference.BookingData data) {
            return base.Channel.MakeBooking(data);
        }
        
        public System.Threading.Tasks.Task<bool> MakeBookingAsync(BookingTestConsole.BookingServiceReference.BookingData data) {
            return base.Channel.MakeBookingAsync(data);
        }
        
        public BookingTestConsole.BookingServiceReference.BookingData[] ViewBookingsFrom(System.DateTime when) {
            return base.Channel.ViewBookingsFrom(when);
        }
        
        public System.Threading.Tasks.Task<BookingTestConsole.BookingServiceReference.BookingData[]> ViewBookingsFromAsync(System.DateTime when) {
            return base.Channel.ViewBookingsFromAsync(when);
        }
    }
}
