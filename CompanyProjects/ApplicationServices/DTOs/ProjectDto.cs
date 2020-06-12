using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.DTOs
{
    public class ProjectDto : BaseDto, IValidate
    {
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public DateTime Created { get; set; }
        [StringLength(40)]
        public string Client { get; set; }
        public double Price { get; set; }

        public int managerId { get; set; }
        public ManagerDto managerDto { get; set; }

        public bool Validate()
        {
            return !String.IsNullOrEmpty(Name);
        }
    }
}
