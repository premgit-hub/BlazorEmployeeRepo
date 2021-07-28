using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Models
{
    public class EmployeeRespository : IEmployeeRepository
    {
        private readonly AppDbcontext appDBcontext;
        public EmployeeRespository(AppDbcontext appDbcontext)
        {
            this.appDBcontext = appDbcontext;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await appDBcontext.Employees.AddAsync(employee);
            await appDBcontext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> DeleteEmployee(int employeeId)
        {
            var result = await appDBcontext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            if (result != null)
            {
                appDBcontext.Employees.Remove(result);
                await appDBcontext.SaveChangesAsync();
            }
            return result;      
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await appDBcontext.Employees.FindAsync(employeeId);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await appDBcontext.Employees.ToListAsync<Employee>();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await appDBcontext.Employees
                .FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);

            if (result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.DateOfBirth = employee.DateOfBirth;
                result.Gender = employee.Gender;
                result.DepartmentId = employee.DepartmentId;
                result.PhotoPath = employee.PhotoPath;

                await appDBcontext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async Task<IEnumerable<Employee>> SearchEmployee(string name)
        {
            IQueryable<Employee> employees = appDBcontext.Employees;

            employees = employees.Where(e => e.FirstName.Contains(name) ||
                            e.LastName.Contains(name));

            return await employees.ToListAsync();
        }
    }
}
