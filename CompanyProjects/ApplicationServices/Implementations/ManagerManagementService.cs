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
    public class ManagerManagementService
    {
        private CompanyDbContext2 context = new CompanyDbContext2();


        public List<ManagerDto> GetAllByName(string name)
        {
            using (CompanyRepo repo = new CompanyRepo())
            {
                var managers = repo.ManagerRepository.GetAllByName(firstName => firstName.FirstName == name);
                return managers.Select(manager => new ManagerDto
                {
                   Id = manager.Id,
                   FirstName = manager.FirstName,
                   LastName = manager.LastName,
                   PhoneNumber = manager.PhoneNumber,
                   Email = manager.Email,
                   BirthDate = manager.BirthDate,
                   Nationality = manager.Nationality,
                   Salary = manager.Salary
                }).ToList();
            }
        }


        public List<ManagerDto> Get()
        {
            List<ManagerDto> managerDto = new List<ManagerDto>();
            using (CompanyRepo repo = new CompanyRepo())
            {
                foreach(var item in repo.ManagerRepository.Get())
                {
                    managerDto.Add(new ManagerDto 
                    {
                        Id = item.Id,
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        PhoneNumber = item.PhoneNumber,
                        Email = item.Email,
                        BirthDate = item.BirthDate,
                        Nationality = item.Nationality,
                        Salary = item.Salary
                    });
                }
            }
            return managerDto;
        }

        public ManagerDto GetById(int id)
        {
            ManagerDto managerDto = new ManagerDto();
            using (CompanyRepo repo = new CompanyRepo())
            {
                Manager manager = repo.ManagerRepository.GetByID(id);
                if(manager != null)
                {
                    managerDto = new ManagerDto
                    {
                        Id = manager.Id,
                        FirstName = manager.FirstName,
                        LastName = manager.LastName,
                        PhoneNumber = manager.PhoneNumber,
                        Email = manager.Email,
                        BirthDate = manager.BirthDate,
                        Nationality = manager.Nationality,
                        Salary = manager.Salary
                    };
                }
            }

                return managerDto;
        }


        public bool Save(ManagerDto managerDto)
        {
            Manager manager = new Manager
            {
                FirstName = managerDto.FirstName,
                LastName = managerDto.LastName,
                PhoneNumber = managerDto.PhoneNumber,
                Email = managerDto.Email,
                BirthDate = managerDto.BirthDate,
                Nationality = managerDto.Nationality,
                Salary = managerDto.Salary
            };

            try
            {
                using (CompanyRepo repo = new CompanyRepo())
                {
                    repo.ManagerRepository.Insert(manager);
                    repo.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }



        public bool Update(ManagerDto managerDto)
        {
            Manager manager = new Manager
            {
                Id = managerDto.Id,
                FirstName = managerDto.FirstName,
                LastName = managerDto.LastName,
                PhoneNumber = managerDto.PhoneNumber,
                Email = managerDto.Email,
                BirthDate = managerDto.BirthDate,
                Nationality = managerDto.Nationality,
                Salary = managerDto.Salary
            };

            try
            {
                using (CompanyRepo repo = new CompanyRepo())
                {
                    repo.ManagerRepository.Update(manager);
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
                using(CompanyRepo repo = new CompanyRepo())
                {
                    Manager manager = repo.ManagerRepository.GetByID(id);
                    repo.ManagerRepository.Delete(manager);
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
