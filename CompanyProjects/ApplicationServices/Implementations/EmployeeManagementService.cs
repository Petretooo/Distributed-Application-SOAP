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
    public class EmployeeManagementService
    {
        private CompanyDbContext2 context = new CompanyDbContext2();



        public List<EmployeeDto> GetAllByName(string name)
        {
            using (CompanyRepo repo = new CompanyRepo())
            {
                var employees = repo.EmployeeRepository.GetAllByName(firstName => firstName.FirstName == name);
                return employees.Select(employee => new EmployeeDto
                {
                    Id = employee.Id,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    PhoneNumber = employee.PhoneNumber,
                    Email = employee.Email,
                    BirthDate = employee.BirthDate,
                    Position = employee.Position,
                    Salary = employee.Salary
                }).ToList();
            }
        }



        public List<EmployeeDto> Get()
        {
            List<EmployeeDto> employeeDto = new List<EmployeeDto>();
            using(CompanyRepo repo = new CompanyRepo())
            {
                foreach(var item in repo.EmployeeRepository.Get())
                {
                    employeeDto.Add(new EmployeeDto
                    {
                        Id = item.Id,
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        PhoneNumber = item.PhoneNumber,
                        Email = item.Email,
                        BirthDate = item.BirthDate,
                        Position = item.Position,
                        Salary = item.Salary
                    });
                }
            }
            return employeeDto;
        }


        public EmployeeDto GetById(int id)
        {
            EmployeeDto employeeDto = new EmployeeDto();
            using (CompanyRepo repo = new CompanyRepo())
            {
                Employee employee = repo.EmployeeRepository.GetByID(id);
                if(employee != null)
                {
                    employeeDto = new EmployeeDto
                    {
                        Id = employee.Id,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        PhoneNumber = employee.PhoneNumber,
                        Email = employee.Email,
                        BirthDate = employee.BirthDate,
                        Position = employee.Position,
                        Salary = employee.Salary
                    };
                }
            }

            return employeeDto;
        }

        public bool Save(EmployeeDto employeeDto)
        {
            Employee employee = new Employee
            {
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                PhoneNumber = employeeDto.PhoneNumber,
                Email = employeeDto.Email,
                BirthDate = employeeDto.BirthDate,
                Position = employeeDto.Position,
                Salary = employeeDto.Salary
            };

            try
            {
                using(CompanyRepo repo = new CompanyRepo())
                {
                    repo.EmployeeRepository.Insert(employee);
                    repo.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(EmployeeDto employeeDto)
        {
            Employee employee = new Employee
            {
                Id = employeeDto.Id,
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                PhoneNumber = employeeDto.PhoneNumber,
                Email = employeeDto.Email,
                BirthDate = employeeDto.BirthDate,
                Position = employeeDto.Position,
                Salary = employeeDto.Salary
            };

            try
            {
                using(CompanyRepo repo = new CompanyRepo())
                {
                    repo.EmployeeRepository.Update(employee);
                    repo.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (CompanyRepo repo = new CompanyRepo())
                {
                    Employee employee = repo.EmployeeRepository.GetByID(id);
                    repo.EmployeeRepository.Delete(employee);
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
