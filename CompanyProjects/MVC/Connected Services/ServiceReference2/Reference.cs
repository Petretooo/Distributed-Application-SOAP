﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeDto", Namespace="http://schemas.datacontract.org/2004/07/ApplicationServices.DTOs")]
    [System.SerializableAttribute()]
    public partial class EmployeeDto : MVC.ServiceReference2.BaseDto {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PositionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double SalaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVC.ServiceReference2.ProjectEmployeeDto[] projectEmployeesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Position {
            get {
                return this.PositionField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionField, value) != true)) {
                    this.PositionField = value;
                    this.RaisePropertyChanged("Position");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MVC.ServiceReference2.ProjectEmployeeDto[] projectEmployees {
            get {
                return this.projectEmployeesField;
            }
            set {
                if ((object.ReferenceEquals(this.projectEmployeesField, value) != true)) {
                    this.projectEmployeesField = value;
                    this.RaisePropertyChanged("projectEmployees");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseDto", Namespace="http://schemas.datacontract.org/2004/07/ApplicationServices.DTOs")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MVC.ServiceReference2.ProjectEmployeeDto))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MVC.ServiceReference2.EmployeeDto))]
    public partial class BaseDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProjectEmployeeDto", Namespace="http://schemas.datacontract.org/2004/07/ApplicationServices.DTOs")]
    [System.SerializableAttribute()]
    public partial class ProjectEmployeeDto : MVC.ServiceReference2.BaseDto {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_employeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_projectField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_employee {
            get {
                return this.id_employeeField;
            }
            set {
                if ((this.id_employeeField.Equals(value) != true)) {
                    this.id_employeeField = value;
                    this.RaisePropertyChanged("id_employee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_project {
            get {
                return this.id_projectField;
            }
            set {
                if ((this.id_projectField.Equals(value) != true)) {
                    this.id_projectField = value;
                    this.RaisePropertyChanged("id_project");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployees", ReplyAction="http://tempuri.org/IService1/GetEmployeesResponse")]
        MVC.ServiceReference2.EmployeeDto[] GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployees", ReplyAction="http://tempuri.org/IService1/GetEmployeesResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReference2.EmployeeDto[]> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeById", ReplyAction="http://tempuri.org/IService1/GetEmployeeByIdResponse")]
        MVC.ServiceReference2.EmployeeDto GetEmployeeById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeById", ReplyAction="http://tempuri.org/IService1/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReference2.EmployeeDto> GetEmployeeByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostEmployee", ReplyAction="http://tempuri.org/IService1/PostEmployeeResponse")]
        string PostEmployee(MVC.ServiceReference2.EmployeeDto employeeDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostEmployee", ReplyAction="http://tempuri.org/IService1/PostEmployeeResponse")]
        System.Threading.Tasks.Task<string> PostEmployeeAsync(MVC.ServiceReference2.EmployeeDto employeeDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutEmployee", ReplyAction="http://tempuri.org/IService1/PutEmployeeResponse")]
        string PutEmployee(MVC.ServiceReference2.EmployeeDto employeeDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutEmployee", ReplyAction="http://tempuri.org/IService1/PutEmployeeResponse")]
        System.Threading.Tasks.Task<string> PutEmployeeAsync(MVC.ServiceReference2.EmployeeDto employeeDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteEmployee", ReplyAction="http://tempuri.org/IService1/DeleteEmployeeResponse")]
        string DeleteEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteEmployee", ReplyAction="http://tempuri.org/IService1/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task<string> DeleteEmployeeAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MVC.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MVC.ServiceReference2.IService1>, MVC.ServiceReference2.IService1 {
        
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
        
        public MVC.ServiceReference2.EmployeeDto[] GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReference2.EmployeeDto[]> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public MVC.ServiceReference2.EmployeeDto GetEmployeeById(int id) {
            return base.Channel.GetEmployeeById(id);
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReference2.EmployeeDto> GetEmployeeByIdAsync(int id) {
            return base.Channel.GetEmployeeByIdAsync(id);
        }
        
        public string PostEmployee(MVC.ServiceReference2.EmployeeDto employeeDto) {
            return base.Channel.PostEmployee(employeeDto);
        }
        
        public System.Threading.Tasks.Task<string> PostEmployeeAsync(MVC.ServiceReference2.EmployeeDto employeeDto) {
            return base.Channel.PostEmployeeAsync(employeeDto);
        }
        
        public string PutEmployee(MVC.ServiceReference2.EmployeeDto employeeDto) {
            return base.Channel.PutEmployee(employeeDto);
        }
        
        public System.Threading.Tasks.Task<string> PutEmployeeAsync(MVC.ServiceReference2.EmployeeDto employeeDto) {
            return base.Channel.PutEmployeeAsync(employeeDto);
        }
        
        public string DeleteEmployee(int id) {
            return base.Channel.DeleteEmployee(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteEmployeeAsync(int id) {
            return base.Channel.DeleteEmployeeAsync(id);
        }
    }
}
