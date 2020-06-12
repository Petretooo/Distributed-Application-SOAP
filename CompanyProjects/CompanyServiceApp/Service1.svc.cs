using ApplicationServices.DTOs;
using ApplicationServices.Implementations;
using Data.Context;
using Data.Entities;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CompanyServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {





        private EmployeeManagementService employeeService = new EmployeeManagementService();

        public List<EmployeeDto> GetEmployees()
        {
            return employeeService.Get();
        }

        public EmployeeDto GetEmployeeById(int id)
        {
            return employeeService.GetById(id);
        }

        public string PostEmployee(EmployeeDto employeeDto)
        {
            if (!employeeService.Save(employeeDto))
            {
                return "Employee is not inserted";
            }

            return "Employee is inserted";
        }

        public string PutEmployee(EmployeeDto employeeDto)
        {
            if (!employeeService.Update(employeeDto))
            {
                return "Employee is not updated"; 
            }

            return "Employee is updated";
        }

        public string DeleteEmployee(int id)
        {
            if (!employeeService.Delete(id))
            {
                return "Employee is not deleted";
            }

            return "Employee is deleted";
        }

        public string Message()
        {
            return "The WCF service is up.";
        }

        public List<EmployeeDto> GetAllEmployeesByName(string name)
        {
            return employeeService.GetAllByName(name);
        }








        private ManagerManagementService managerService = new ManagerManagementService();

        public List<ManagerDto> GetManagers()
        {
            return managerService.Get();
        }

        public ManagerDto GetManagerById(int id)
        {
            return managerService.GetById(id);
        }

        public string PostManager(ManagerDto managerDto)
        {
            if (!managerService.Save(managerDto))
            {
                return "Manager is not inserted";
            }

            return "Manager is inserted";
        }

        public string PutManager(ManagerDto managerDto)
        {
            if (!managerService.Update(managerDto))
            {
                return "Manager is not updated";
            }

            return "Manager is updated";
        }

        public string DeleteManager(int id)
        {
            if (!managerService.Delete(id))
            {
                return "Manager is not deleted";
            }

            return "Manager is deleted";
        }
        public List<ManagerDto> GetAllManagersByName(string name)
        {
            return managerService.GetAllByName(name);
        }







        private ProjectManagementService projectService = new ProjectManagementService();

        public List<ProjectDto> GetProjects()
        {
            return projectService.Get();
        }

        public ProjectDto GetProjectById(int id)
        {
            return projectService.GetById(id);
        }

        public string PostProject(ProjectDto projectDto)
        {
            if (!projectService.Save(projectDto))
            {
                return "Project is not inserted";
            }
            return "Project is inserted";
        }

        public string PutProject(ProjectDto projectDto)
        {
            if (!projectService.Update(projectDto))
            {
                return "Project is not updated";
            }
            return "Project is updated";
        }

        public string DeleteProject(int id)
        {
            if (!projectService.Delete(id))
            {
                return "Project is not deleted";
            }
            return "Project is deleted";
        }

        public List<ProjectDto> GetAllProjectsByName(string name)
        {
            return projectService.GetAllByName(name);
        }







        private ProjectEmployeeManagementService peService = new ProjectEmployeeManagementService();

        public List<ProjectEmployeeDto> GetProjectEmployees()
        {
            return peService.Get();
        }

        public ProjectEmployeeDto GetProjectEmployeeById(int id)
        {
            return peService.GetById(id);
        }

        public string PostProjectEmployee(ProjectEmployeeDto projectEmployeeDto)
        {
            if (!peService.Save(projectEmployeeDto))
            {
                return "ProjectEmployee is not inserted";
            }
            return "ProjectEmployee is inserted";
        }

        public string PutProjectEmployee(ProjectEmployeeDto projectEmployeeDto)
        {
            if (!peService.Update(projectEmployeeDto))
            {
                return "ProjectEmployee is not updated";
            }
            return "ProjectEmployee is updated";
        }

        public string DeleteProjectEmployee(int id)
        {
            if (!peService.Delete(id))
            {
                return "ProjectEmployee is not deleted";
            }
            return "ProjectEmployee is deleted";
        }

        public List<ProjectEmployeeDto> GetAllProjectEmployeeByName(string name)
        {
            return peService.GetAllByName(name);
        }
    }
}
