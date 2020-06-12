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
    public class ProjectManagementService
    {
        private CompanyDbContext2 context = new CompanyDbContext2();
        
        public List<ProjectDto> GetAllByName(string name)
        {
            using (CompanyRepo repo = new CompanyRepo())
            {
                var projects = repo.ProjectRepository.GetAllByName(projectName => projectName.Name == name);
                return projects.Select(project => new ProjectDto 
                {
                    Id = project.Id,
                    Name = project.Name,
                    Description = project.Description,
                    Created = project.Created,
                    Client = project.Client,
                    Price = project.Price,
                    managerDto = new ManagerDto
                    {
                        Id = project.Manager_Id,
                        FirstName = project.manager.FirstName,
                        LastName = project.manager.LastName,
                        PhoneNumber = project.manager.PhoneNumber,
                        Email = project.manager.Email,
                        BirthDate = project.manager.BirthDate,
                        Nationality = project.manager.Nationality,
                        Salary = project.manager.Salary
                    }

                }).ToList();
            }
        }

        public List<ProjectDto> Get()
        {
            /*List<ProjectDto> projectDto = new List<ProjectDto>();
            using (CompanyRepo repo = new CompanyRepo())
            {
                foreach(var item in repo.ProjectRepository.Get())
                {
                    

                    if(item.Manager_Id != 0 && item.manager != null)
                    {

                        
                        projectDto.Add(new ProjectDto
                        {
                            Id = item.Id,
                            Name = item.Name,
                            Description = item.Description,
                            Created = item.Created,
                            Client = item.Client,
                            Price = item.Price,
                            managerDto = new ManagerDto
                            {
                                Id = item.Manager_Id,
                                FirstName = item.manager.FirstName,
                                LastName = item.manager.LastName,
                                PhoneNumber = item.manager.PhoneNumber,
                                Email = item.manager.Email,
                                BirthDate = item.manager.BirthDate,
                                Nationality = item.manager.Nationality,
                                Salary = item.manager.Salary
                            }
                        });
                    }
                    else
                    {
                        projectDto.Add(new ProjectDto
                        {
                            Id = item.Id,
                            Name = item.Name,
                            Description = item.Description,
                            Created = item.Created,
                            Client = item.Client,
                            Price = item.Price,


                        });
                    }
                }
            }*/

            using (CompanyRepo repo = new CompanyRepo())
            {
                var projects = repo.ProjectRepository.Get();
                var result = projects.Select(project => new ProjectDto
                {
                    Id = project.Id,
                    Name = project.Name,
                    Description = project.Description,
                    Created = project.Created,
                    Client = project.Client,
                    Price = project.Price,
                    managerDto = new ManagerDto 
                    {
                        Id = project.Manager_Id,
                        FirstName = project.manager.FirstName,
                        LastName = project.manager.LastName,
                        PhoneNumber = project.manager.PhoneNumber,
                        Email = project.manager.Email,
                        BirthDate = project.manager.BirthDate,
                        Nationality = project.manager.Nationality,
                        Salary = project.manager.Salary
                    }
                }).ToList();

                return result;
            }

                
        }


        public ProjectDto GetById(int id)
        {
            /* ProjectDto projectDto = new ProjectDto();

             using (CompanyRepo repo = new CompanyRepo())
             {
                 Project project = repo.ProjectRepository.GetByID(id);
                 if (project != null)
                 {
                     projectDto = new ProjectDto
                     {
                         Id = project.Id,
                         Name = project.Name,
                         Description = project.Description,
                         Created = project.Created,
                         Client = project.Client,
                         Price = project.Price,
                         managerDto = new ManagerDto
                         {
                             Id = project.Manager_Id,
                             FirstName = project.manager.FirstName,
                             LastName = project.manager.LastName,
                             PhoneNumber = project.manager.PhoneNumber,
                             Email = project.manager.Email,
                             BirthDate = project.manager.BirthDate,
                             Nationality = project.manager.Nationality,
                             Salary = project.manager.Salary
                         }
                     };
                 }
             }
             return projectDto;*/

            using (CompanyRepo repo = new CompanyRepo())
            {
                var project = repo.ProjectRepository.GetByID(id);
                return project == null ? null : new ProjectDto
                {
                    Id = project.Id,
                    Name = project.Name,
                    Description = project.Description,
                    Created = project.Created,
                    Client = project.Client,
                    Price = project.Price,
                    managerId = project.Manager_Id,
                    managerDto = new ManagerDto
                    {
                        Id = project.Manager_Id,
                        FirstName = project.manager.FirstName,
                        LastName = project.manager.LastName,
                        PhoneNumber = project.manager.PhoneNumber,
                        Email = project.manager.Email,
                        BirthDate = project.manager.BirthDate,
                        Nationality = project.manager.Nationality,
                        Salary = project.manager.Salary
                    }
                };
            }
        }

        public bool Save(ProjectDto projectDto)
        {
            /* if(projectDto.managerDto == null || projectDto.managerDto.Id == 0)
             {
                 return false;
             }

             Manager manager = new Manager
             {
                 FirstName = projectDto.managerDto.FirstName,
                 LastName = projectDto.managerDto.LastName,
                 PhoneNumber = projectDto.managerDto.PhoneNumber,
                 Email = projectDto.managerDto.Email,
                 BirthDate = projectDto.managerDto.BirthDate,
                 Nationality = projectDto.managerDto.Nationality,
                 Salary = projectDto.managerDto.Salary
             };

             Project project = new Project
             {
                 Name = projectDto.Name,
                 Description = projectDto.Description,
                 Created = projectDto.Created,
                 Client = projectDto.Client,
                 Price = projectDto.Price,
                 Manager_Id = projectDto.managerDto.Id,
                 manager = manager

             };

             try
             {
                 using (CompanyRepo repo = new CompanyRepo())
                 {
                     Manager manager1 = repo.ManagerRepository.GetByID(project.Manager_Id);
                     if(manager1 != null)
                     {
                         project.manager = manager1;
                         repo.ProjectRepository.Insert(project);
                         repo.Save();
                         return true;
                     }
                     return false;
                 }
             }
             catch
             {
                 Console.WriteLine(project);
                 return false;
             }*/
            try
            {
                using (CompanyRepo repo = new CompanyRepo())
                {
                    try
                    {
                        var project = new Project()
                        {
                            Name = projectDto.Name,
                            Description = projectDto.Description,
                            Created = projectDto.Created,
                            Client = projectDto.Client,
                            Price = projectDto.Price,
                            Manager_Id = projectDto.managerId,
                            manager = repo.ManagerRepository.GetByID(projectDto.managerId),
                            CreatedOn = DateTime.Now
                        };
                        repo.ProjectRepository.Insert(project);
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


        public bool Update(ProjectDto projectDto)
        {
            /*if(projectDto.managerDto == null || projectDto.managerDto.Id == 0)
            {
                return false;
            }

            Project project = new Project
            {
                Id = projectDto.Id,
                Name = projectDto.Name,
                Description = projectDto.Description,
                Created = projectDto.Created,
                Client = projectDto.Client,
                Price = projectDto.Price,
                Manager_Id = projectDto.managerDto.Id
            };

            try
            {
                using (CompanyRepo repo = new CompanyRepo())
                {
                    Manager manager = repo.ManagerRepository.GetByID(project.Manager_Id);
                    if(manager != null)
                    {
                        project.manager = manager;
                        repo.ProjectRepository.Update(project);
                        repo.Save();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }*/



            using (CompanyRepo repo = new CompanyRepo())
            {
                try
                {
                    var result = repo.ProjectRepository.GetByID(projectDto.Id);
                    if (result == null)
                    {
                        return false;
                    }
                    result.Id = projectDto.Id;
                    result.Name = projectDto.Name;
                    result.Description = projectDto.Description;
                    result.Created = projectDto.Created;
                    result.Client = projectDto.Client;
                    result.Price = projectDto.Price;
                    result.Manager_Id = projectDto.managerId;
                    repo.ProjectRepository.Update(result);
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
                    Project project = repo.ProjectRepository.GetByID(id);
                    repo.ProjectRepository.Delete(project);
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
