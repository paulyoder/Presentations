using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RIAExample3.Web
{
    public interface IEmployeeRepository
    {

        IEnumerable<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
				
    }
}