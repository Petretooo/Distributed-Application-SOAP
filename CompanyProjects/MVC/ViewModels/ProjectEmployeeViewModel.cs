using ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class ProjectEmployeeViewModel
    {
        public int Id { get; set; }
        [DisplayName("Projects")]
        public int projectID { get; set; }
        [DisplayName("Project name")]
        public string projectName { get; set; }
        public ProjectViewModel projectVM { get; set; }
        [DisplayName("Employees")]
        public int employeeId { get; set; }
        [DisplayName("Employee name")]
        public string empployeeName { get; set; }
        public EmployeeViewModel employeeVM { get; set; }

        public ProjectEmployeeViewModel() { }
        public ProjectEmployeeViewModel(ProjectEmployeeDto projectEmployeeDto)
        {
            Id = projectEmployeeDto.Id;
            projectID = projectEmployeeDto.id_project;
            projectName = projectEmployeeDto.projectDto.Name;
            projectVM = new ProjectViewModel
            {
                Id = projectEmployeeDto.projectDto.Id,
                Name = projectEmployeeDto.projectDto.Name,
                Description = projectEmployeeDto.projectDto.Description,
                Created = projectEmployeeDto.projectDto.Created,
                Client = projectEmployeeDto.projectDto.Client,
                Price = projectEmployeeDto.projectDto.Price,
                managerId = projectEmployeeDto.projectDto.managerId,
                managerName = projectEmployeeDto.projectDto.managerDto.FirstName,
                managerVM = new ManagerViewModel
                { 
                    Id = projectEmployeeDto.projectDto.managerDto.Id,
                    FirstName = projectEmployeeDto.projectDto.managerDto.FirstName,
                    LastName = projectEmployeeDto.projectDto.managerDto.LastName,
                    PhoneNumber = projectEmployeeDto.projectDto.managerDto.PhoneNumber,
                    Email = projectEmployeeDto.projectDto.managerDto.Email,
                    BirthDate = projectEmployeeDto.projectDto.managerDto.BirthDate,
                    Nationality = projectEmployeeDto.projectDto.managerDto.Nationality,
                    Salary = projectEmployeeDto.projectDto.managerDto.Salary
                }
            };
            employeeId = projectEmployeeDto.id_employee;
            empployeeName = projectEmployeeDto.employeeDto.FirstName;
            employeeVM = new EmployeeViewModel
            {
                Id = projectEmployeeDto.employeeDto.Id,
                FirstName = projectEmployeeDto.employeeDto.FirstName,
                LastName = projectEmployeeDto.employeeDto.LastName,
                PhoneNumber = projectEmployeeDto.employeeDto.PhoneNumber,
                Email = projectEmployeeDto.employeeDto.Email,
                BirthDate = projectEmployeeDto.employeeDto.BirthDate,
                Position = projectEmployeeDto.employeeDto.Position,
                Salary = projectEmployeeDto.employeeDto.Salary
                
            };
        }
    }
}