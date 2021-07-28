﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {        
        public int EmployeeId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Min length 2 of string required")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public int DepartmentId { get; set; }   
        
        public string PhotoPath { get; set; }       
    }
}
