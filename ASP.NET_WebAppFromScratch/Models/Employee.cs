﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_WebAppFromScratch.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }

    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
       

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name ="Awais", Department = "HR", Email = "mawas__7@gmail.com"},
                new Employee(){Id = 2, Name ="Asim", Department = "IT", Email = "asim__7@gmail.com"},
                new Employee(){Id = 3, Name ="Mustensar", Department = "IT", Email = "mustensar__7@gmail.com"},
                new Employee(){Id = 4, Name ="Ayesha", Department = "HR", Email = "ayesha__7@gmail.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
