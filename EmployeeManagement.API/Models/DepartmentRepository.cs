using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbcontext appDbcontext;

        public DepartmentRepository(AppDbcontext appDbcontext)
        {
            this.appDbcontext = appDbcontext;
        }
        public IEnumerable<Department> GetDepartments() {

            return appDbcontext.Departments.ToList<Department>();
        }

       public Department GetDepartment(int departmentId)
        {
            return appDbcontext.Departments.FirstOrDefault(d => d.DepartmentId == departmentId);
        }
    }
}
