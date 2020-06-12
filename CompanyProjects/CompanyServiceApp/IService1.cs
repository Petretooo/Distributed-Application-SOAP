using ApplicationServices.DTOs;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CompanyServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<EmployeeDto> GetEmployees();
        [OperationContract]
        EmployeeDto GetEmployeeById(int id);
        [OperationContract]
        string PostEmployee(EmployeeDto employeeDto);
        [OperationContract]
        string PutEmployee(EmployeeDto employeeDto);
        [OperationContract]
        string DeleteEmployee(int id);
        [OperationContract]
        List<EmployeeDto> GetAllEmployeesByName(string name);





        [OperationContract]
        List<ManagerDto> GetManagers();
        [OperationContract]
        ManagerDto GetManagerById(int id);
        [OperationContract]
        string PostManager(ManagerDto managerDto);
        [OperationContract]
        string PutManager(ManagerDto managerDto);
        [OperationContract]
        string DeleteManager(int id);
        [OperationContract]
        List<ManagerDto> GetAllManagersByName(string name);



        [OperationContract]
        List<ProjectDto> GetProjects();
        [OperationContract]
        ProjectDto GetProjectById(int id);
        [OperationContract]
        string PostProject(ProjectDto projectDto);
        [OperationContract]
        string PutProject(ProjectDto projectDto);
        [OperationContract]
        string DeleteProject(int id);
        [OperationContract]
        List<ProjectDto> GetAllProjectsByName(string name);




        [OperationContract]
        List<ProjectEmployeeDto> GetProjectEmployees();
        [OperationContract]
        ProjectEmployeeDto GetProjectEmployeeById(int id);
        [OperationContract]
        string PostProjectEmployee(ProjectEmployeeDto projectEmployeeDto);
        [OperationContract]
        string PutProjectEmployee(ProjectEmployeeDto projectEmployeeDto);
        [OperationContract]
        string DeleteProjectEmployee(int id);
        [OperationContract]
        List<ProjectEmployeeDto> GetAllProjectEmployeeByName(string name);

    }

}
