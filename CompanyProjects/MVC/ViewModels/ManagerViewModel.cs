using ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class ManagerViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(40)]
        [DisplayName("Last name")]
        public string LastName { get; set; }
        [StringLength(30)]
        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }
        [StringLength(90)]
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime? BirthDate { get; set; }
        [StringLength(40)]
        [DisplayName("Nationality")]
        public string Nationality { get; set; }
        [DisplayName("Salary")]
        public double Salary { get; set; }

        public ManagerViewModel() { }

        public ManagerViewModel(ManagerDto managerDto)
        {
            Id = managerDto.Id;
            FirstName = managerDto.FirstName;
            LastName = managerDto.LastName;
            PhoneNumber = managerDto.PhoneNumber;
            Email = managerDto.Email;
            BirthDate = managerDto.BirthDate;
            Nationality = managerDto.Nationality;
            Salary = managerDto.Salary;
        }
    }
}