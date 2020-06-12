using ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class ProjectViewModel
    {

        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        [DisplayName("Project name")]
        public string Name { get; set; }
        [StringLength(200)]
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Created")]
        public DateTime Created { get; set; }
        [StringLength(40)]
        [DisplayName("Client name")]
        public string Client { get; set; }
        [DisplayName("Price")]
        public double Price { get; set; }
        [DisplayName("Managers")]
        public int managerId { get; set; }
        [DisplayName("Manager name")]
        public string managerName { get; set; }
        public ManagerViewModel managerVM { get; set; }

        public ProjectViewModel() { }
        public ProjectViewModel(ProjectDto projectDto)
        {
            Id = projectDto.Id;
            Name = projectDto.Name;
            Description = projectDto.Description;
            Created = projectDto.Created;
            Client = projectDto.Client;
            Price = projectDto.Price;
            managerId = projectDto.managerId;
            managerName = projectDto.managerDto.FirstName;
            managerVM = new ManagerViewModel
            {
                Id = projectDto.managerDto.Id,
                FirstName = projectDto.managerDto.FirstName,
                LastName = projectDto.managerDto.LastName,
                PhoneNumber = projectDto.managerDto.PhoneNumber,
                Email = projectDto.managerDto.Email,
                BirthDate = projectDto.managerDto.BirthDate,
                Nationality = projectDto.managerDto.Nationality,
                Salary = projectDto.managerDto.Salary
            };
        }
    }
}