using ApplicationServices.DTOs;
using MVC.CompanyService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class EmployeeViewModel
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
        [StringLength(90)]
        [DisplayName("Position")]
        public string Position { get; set; }
        [DisplayName("Salary")]
        public double Salary { get; set; }

        public EmployeeViewModel() { }

        public EmployeeViewModel(EmployeeDto employeeDto)
        {
            Id = employeeDto.Id;
            FirstName = employeeDto.FirstName;
            LastName = employeeDto.LastName;
            PhoneNumber = employeeDto.PhoneNumber;
            Email = employeeDto.Email;
            BirthDate = employeeDto.BirthDate;
            Position = employeeDto.Position;
            Salary = employeeDto.Salary;
                           
        }
    }
}