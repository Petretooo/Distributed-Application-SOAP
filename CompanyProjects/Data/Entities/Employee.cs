using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Employee : BaseEntity
    {
        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }
        [StringLength(40)]
        [Required]
        public string LastName { get; set; }
        [StringLength(30)]
        public string PhoneNumber { get; set; }
        [StringLength(90)]
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
        [StringLength(90)]
        public string Position { get; set; }
        public double Salary { get; set; }
        public virtual ICollection<ProjectEmployee> projectEmployees { get; set; }

    }
}
