using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ProjectEmployee : BaseEntity
    {
        public int id_project { get; set; }
        [ForeignKey("id_project")]
        public virtual Project project { get; set; }
        public int id_employee { get; set; }
        [ForeignKey("id_employee")]
        public virtual Employee empployee { get; set; }
    }
}
