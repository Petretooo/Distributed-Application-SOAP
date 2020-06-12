﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.DTOs
{
    public class ManagerDto : BaseDto, IValidate
    {
        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(40)]
        public string LastName { get; set; }
        [StringLength(30)]
        public string PhoneNumber { get; set; }
        [StringLength(90)]
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
        [StringLength(40)]
        public string Nationality { get; set; }
        public double Salary { get; set; }

        public bool Validate()
        {
            return !String.IsNullOrEmpty(FirstName);
        }
    }
}