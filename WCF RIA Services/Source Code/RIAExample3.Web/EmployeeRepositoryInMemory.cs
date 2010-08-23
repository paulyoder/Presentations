using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RIAExample3.Web
{
    public class EmployeeRepositoryInMemory : IEmployeeRepository
    {

        private static List<Employee> _employees;

        public EmployeeRepositoryInMemory()
        {
            if (_employees == null)
            {
                _employees = new List<Employee>();
                _employees.Add(new Employee() { Id = 1, FirstName = "Paul", LastName = "Yoder" });
                _employees.Add(new Employee() { Id = 2, FirstName = "Abraham", LastName = "Lincoln" });
                _employees.Add(new Employee() { Id = 3, FirstName = "George", LastName = "Washington" });
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            var employeeIndex = _employees.FindIndex(x => x.Id == employee.Id);
            _employees[employeeIndex] = employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _employees.RemoveAll(x => x.Id == employee.Id);
        }
    }
}