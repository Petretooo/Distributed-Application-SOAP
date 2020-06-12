using ApplicationServices.DTOs;
using Data.Context;
using Data.Entities;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Implementations
{
    public class ProjectEmployeeManagementService
    {
        private CompanyDbContext2 context = new CompanyDbContext2();

        public List<ProjectEmployeeDto> Get()
        {
            using (CompanyRepo repo = new CompanyRepo())
            {
                var projectEmployees = repo.ProjectEmployeeRepository.Get();
                var result = projectEmployees.Select(pe => new ProjectEmployeeDto
                {
                    Id = pe.Id,
                    id_project = pe.id_project,
                    projectDto = new ProjectDto 
                    {
                        Id = pe.project.Id,
                        Name = pe.project.Name,
                        Description = pe.project.Description,
                        Created = pe.project.Created,
                        Client = pe.project.Client,
                        Price = pe.project.Price,
                        managerDto = new ManagerDto
                        {
                            Id = pe.project.manager.Id,
                            FirstName = pe.project.manager.FirstName,
                            LastName = pe.project.manager.LastName,
                            PhoneNumber = pe.project.manager.PhoneNumber,
                            Email = pe.project.manager.Email,
                            BirthDate = pe.project.manager.BirthDate,
                            Nationality = pe.project.manager.Nationality,
                            Salary = pe.project.manager.Salary
                        }
                    },
                    id_employee = pe.id_employee,
                    employeeDto = new EmployeeDto
                    {
                        Id = pe.empployee.Id,
                        FirstName = pe.empployee.FirstName,
                        LastName = pe.empployee.LastName,
                        PhoneNumber = pe.empployee.PhoneNumber,
                        Email = pe.empployee.Email,
                        BirthDate = pe.empployee.BirthDate,
                        Position = pe.empployee.Position,
                        Salary = pe.empployee.Salary
                    }
                }).ToList();
                return result;
            }
        }

        public ProjectEmployeeDto GetById(int id)
        {
            using (CompanyRepo repo = new CompanyRepo())
            {
                var projectEmployee = repo.ProjectEmployeeRepository.GetByID(id);
                return projectEmployee == null ? null : new ProjectEmployeeDto
                {
                    Id = projectEmployee.Id,
                    id_project = projectEmployee.id_project,
                    projectDto = new ProjectDto
                    {
                        Id = projectEmployee.project.Id,
                        Name = projectEmployee.project.Name,
                        Description = projectEmployee.project.Description,
                        Created = projectEmployee.project.Created,
                        Client = projectEmployee.project.Client,
                        Price = projectEmployee.project.Price,
                        managerDto = new ManagerDto
                        {
                            Id = projectEmployee.project.manager.Id,
                            FirstName = projectEmployee.project.manager.FirstName,
                            LastName = projectEmployee.project.manager.LastName,
                            PhoneNumber = projectEmployee.project.manager.PhoneNumber,
                            Email = projectEmployee.project.manager.Email,
                            BirthDate = projectEmployee.project.manager.BirthDate,
                            Nationality = projectEmployee.project.manager.Nationality,
                            Salary = projectEmployee.project.manager.Salary
                        }
                    },
                    id_employee = projectEmployee.id_employee,
                    employeeDto = new EmployeeDto
                    {
                        Id = projectEmployee.empployee.Id,
                        FirstName = projectEmployee.empployee.FirstName,
                        LastName = projectEmployee.empployee.LastName,
                        PhoneNumber = projectEmployee.empployee.PhoneNumber,
                        Email = projectEmployee.empployee.Email,
                        BirthDate = projectEmployee.empployee.BirthDate,
                        Position = projectEmployee.empployee.Position,
                        Salary = projectEmployee.empployee.Salary
                    }
                };
            }
        }

        public List<ProjectEmployeeDto> GetAllByName(string name)
        {
            using (CompanyRepo repo = new CompanyRepo())
            {
                var projectEmployees = repo.ProjectEmployeeRepository.GetAllByName(projectName => projectName.project.Name == name);
                return projectEmployees.Select(pe => new ProjectEmployeeDto 
                {
                    Id = pe.Id,
                    id_project = pe.id_project,
                    projectDto = new ProjectDto
                    {
                        Id = pe.project.Id,
                        Name = pe.project.Name,
                        Description = pe.project.Description,
                        Created = pe.project.Created,
                        Client = pe.project.Client,
                        Price = pe.project.Price,
                        managerDto = new ManagerDto
                        {
                            Id = pe.project.manager.Id,
                            FirstName = pe.project.manager.FirstName,
                            LastName = pe.project.manager.LastName,
                            PhoneNumber = pe.project.manager.PhoneNumber,
                            Email = pe.project.manager.Email,
                            BirthDate = pe.project.manager.BirthDate,
                            Nationality = pe.project.manager.Nationality,
                            Salary = pe.project.manager.Salary
                        }
                    },
                    id_employee = pe.id_employee,
                    employeeDto = new EmployeeDto
                    {
                        Id = pe.empployee.Id,
                        FirstName = pe.empployee.FirstName,
                        LastName = pe.empployee.LastName,
                        PhoneNumber = pe.empployee.PhoneNumber,
                        Email = pe.empployee.Email,
                        BirthDate = pe.empployee.BirthDate,
                        Position = pe.empployee.Position,
                        Salary = pe.empployee.Salary
                    }
                }).ToList();
            }
        }

        public bool Save(ProjectEmployeeDto projectEmployeeDto)
        {
            try
            {
                using (CompanyRepo repo = new CompanyRepo())
                {
                    try
                    {
                        var pe = new ProjectEmployee()
                        {
                            id_project = projectEmployeeDto.id_project,
                            project = repo.ProjectRepository.GetByID(projectEmployeeDto.projectDto.Id),
                            id_employee = projectEmployeeDto.id_employee,
                            empployee = repo.EmployeeRepository.GetByID(projectEmployeeDto.employeeDto.Id)
                        };
                        repo.ProjectEmployeeRepository.Insert(pe);
                        repo.Save();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return true;
            }
        }

        public bool Update(ProjectEmployeeDto projectEmployeeDto)
        {
            using (CompanyRepo repo = new CompanyRepo())
            {
                try
                {
                    var result = repo.ProjectEmployeeRepository.GetByID(projectEmployeeDto.Id);
                    if(result == null)
                    {
                        return false;
                    }
                    result.Id = projectEmployeeDto.Id;
                    result.id_project = projectEmployeeDto.id_project;
                    result.id_employee = projectEmployeeDto.id_employee;
                    repo.ProjectEmployeeRepository.Update(result);
                    repo.Save();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (CompanyRepo repo = new CompanyRepo())
                {
                    ProjectEmployee pe = repo.ProjectEmployeeRepository.GetByID(id);
                    repo.ProjectEmployeeRepository.Delete(pe);
                    repo.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
