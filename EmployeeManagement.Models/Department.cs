using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Department
    {        
        public int DepartmentId { get; set; }       
        public string DepartmentName { get; set; }
    }
}
