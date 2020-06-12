using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.DTOs
{
    public class ProjectEmployeeDto : BaseDto
    {
        public int id_project { get; set; }
        public ProjectDto projectDto { get; set; }
        public int id_employee { get; set; }
        public EmployeeDto employeeDto{get;set;}

    }
}
