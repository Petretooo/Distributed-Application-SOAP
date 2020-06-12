using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Project : BaseEntity
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
        public int Manager_Id { get; set; }
        [ForeignKey("Manager_Id")]
        public virtual Manager manager { get; set; }
        public virtual ICollection<ProjectEmployee> projectEmployees { get; set; }
    }
}
