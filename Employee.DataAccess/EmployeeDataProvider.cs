using System;
using System.Collections.Generic;
using System.Diagnostics;
using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;

namespace EmployeeManager.DataAccess
{
    public class EmployeeDataProvider : IEmployeeDataProvider
    {
        public IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee 
                {
                    Id = 1,
                    FirstName = "John",
                    EntryDate = new DateTime(day: 10, month: 3, year: 1989),
                    JobRoleId = 1,
                    IsCoffeeDrinker = true
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Mary",
                    EntryDate = new DateTime(day: 15, month: 5, year: 1991),
                    JobRoleId = 2,
                    IsCoffeeDrinker = true
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Bob",
                    EntryDate = new DateTime(day: 22, month: 1, year: 1973),
                    JobRoleId = 1,
                    IsCoffeeDrinker = false
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "Bill",
                    EntryDate = new DateTime(day: 11, month: 11, year: 1994),
                    JobRoleId = 3,
                    IsCoffeeDrinker = true
                },
                new Employee
                {
                    Id = 5,
                    FirstName = "Rose",
                    EntryDate = new DateTime(day: 26, month: 7, year: 1985),
                    JobRoleId = 4,
                    IsCoffeeDrinker = false
                },
                new Employee
                {
                    Id = 6,
                    FirstName = "Mark",
                    EntryDate = new DateTime(day: 6, month: 12, year: 1970),
                    JobRoleId = 5,
                    IsCoffeeDrinker = true
                },
                new Employee
                {
                    Id = 7,
                    FirstName = "Lisa",
                    EntryDate = new DateTime(day: 16, month: 8, year: 1999),
                    JobRoleId = 4,
                    IsCoffeeDrinker = false
                },
            };
        }

        public IEnumerable<JobRole> LoadJobRoles()
        {
            return new List<JobRole> 
            {
                new JobRole { Id = 1, RoleName = "Manager" },
                new JobRole { Id = 2, RoleName = "CTO" },
                new JobRole { Id = 3, RoleName = "President" },
                new JobRole { Id = 4, RoleName = "Administrator" },
                new JobRole { Id = 5, RoleName = "CEO" },
            };
        }

        public void SaveEmployee(Employee employee)
        {
            Debug.WriteLine($"Employee Saved: {employee.FirstName}.");
        }
    }
}
